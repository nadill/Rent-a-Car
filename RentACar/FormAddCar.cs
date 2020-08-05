using MySql.Data.MySqlClient;
using RentACar.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar
{
    public partial class FormAddCar : Form
    {
        // pole do przekazywania ID rekordu
        public int rowId = 0;

        public FormAddCar()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormAddCar_Load(object sender, EventArgs e)
        {
            LoadDictionaryData();
            nudYear.Maximum = DateTime.Now.Year;
            if (rowId > 0)
            {
                string sql = @"SELECT c.*, m.brand_id
                            FROM cars c, car_models m
                            WHERE c.id={0} AND c.model_id= m.id";
                sql = string.Format(sql, rowId);
                MySqlCommand cmd = new MySqlCommand(sql, GlobalData.connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    nudEngine.Value = Convert.ToInt32(reader["engine"]);
                    nudYear.Value = Convert.ToInt32(reader["manufacturer_year"]);
                    cbFuel.SelectedIndex = cbFuel.Items.IndexOf(reader["fuel"].ToString());
                    mtbRegistration.Text = reader["registration_plate"].ToString();
                    cbTypes.SelectedValue = reader["type_id"];
                    cbBrands.SelectedValue = reader["brand_id"];
                    cbModels.SelectedValue = reader["model_id"];
                    cbModels.Enabled = true;
                    if (!(reader["image"] is DBNull))
                    {
                        byte[] b = (byte[])reader["image"];
                        using(var ms = new MemoryStream(b))
                        {
                            picCar.Image = Image.FromStream(ms);
                        }
                    }
                    reader.Close();


                }
            }

            // tuning GUI
            if (rowId>0)
            {
                btnSave.Text = "Zapisz";
                this.Text = "Edycja pojazdu";
            }
            else
            {
                btnSave.Text = "Dodaj";
                this.Text = "Nowy pojazd";
            }
        }

        BindingSource bsBrands = new BindingSource();
        BindingSource bsModels = new BindingSource();
        BindingSource bsTypes = new BindingSource();
        private string pictureFileName = null;

        private void LoadDictionaryData()
        {
            try
            {
                // Ładowanie słownika producentów
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string sql = @"select id, name from car_brands order by name";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bsBrands.DataSource = dt;
                cbBrands.DataSource = bsBrands;
                cbBrands.DisplayMember = "name";
                cbBrands.ValueMember = "id";
                cbBrands.SelectedIndex = -1;
                //
                cbBrands.SelectedIndexChanged += CbBrands_SelectedIndexChanged;

                // Ładowanie słownika modeli
                sql = @"select id, brand_id, name from car_models order by brand_id asc, name asc";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

                dt = new DataTable();
                adapter.Fill(dt);

                bsModels.DataSource = dt;
                cbModels.DataSource = bsModels;
                cbModels.DisplayMember = "name";
                cbModels.ValueMember = "id";
                cbModels.SelectedIndex = -1;
                cbModels.Enabled = false;

                // Ładowanie słownika typów własności
                sql = @"select id, name from car_types order by name asc";
                adapter.SelectCommand = new MySqlCommand(sql, GlobalData.connection);

                dt = new DataTable();
                adapter.Fill(dt);

                bsTypes.DataSource = dt;
                cbTypes.DataSource = bsTypes;
                cbTypes.DisplayMember = "name";
                cbTypes.ValueMember = "id";
                cbTypes.SelectedIndex = -1;

            } catch (Exception exc)
            {
                DialogHelper.Error(exc.Message);
            }

        }

        private void CbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrands.SelectedIndex > -1)
            {
                bsModels.Filter = "brand_id = " + cbBrands.SelectedValue;
                cbModels.DataSource = bsModels;
                cbModels.SelectedIndex = -1;
                cbModels.Enabled = true;
            }
            
        }

        private void mtbRegistration_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnDeletePic_Click(object sender, EventArgs e)
        {
            if(picCar.Image != null)
            {
                picCar.Image.Dispose();
                picCar.Image = null;
                pictureFileName = null;
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Pliki graficzne|*.jpg;*.png;*.jpeg;*.gif;*.bmp";
            
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                // Ładujemy grafike do komponentu
                picCar.Image = new Bitmap(dialog.FileName);
                pictureFileName = dialog.FileName;
            }

        }

        private void nudEngine_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            try
            {
                string sql = "";
                if (rowId > 0)
                {
                    sql = @"update cars set
                        model_id = @model_id, type_id = @type_id, registration_plate = @reg_plate, engine = @engine, 
                        manufacturer_year = @year, fuel = @fuel, image = @image
                        where
                            id=@row_id";
                }
                else
                {
                    sql = @"insert into cars
                            (model_id, type_id, registration_plate, engine, manufacturer_year, image, fuel, avail) 
                            values 
                            (@model_id, @type_id, @reg_plate, @engine, @year, @image, @fuel, 1)";

                }

                
                MySqlCommand cmd = new MySqlCommand(sql, GlobalData.connection);
                cmd.Parameters.Add("@model_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@type_id", MySqlDbType.Int32);
                cmd.Parameters.Add("@reg_plate", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@engine", MySqlDbType.Int32);
                cmd.Parameters.Add("@year", MySqlDbType.Int32);
                cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@fuel", MySqlDbType.VarChar, 50);
                cmd.Parameters.Add("@row_id", MySqlDbType.Int32);

                cmd.Parameters["@model_id"].Value = cbModels.SelectedValue;
                cmd.Parameters["@type_id"].Value = cbTypes.SelectedValue;
                cmd.Parameters["@reg_plate"].Value = mtbRegistration.Text;
                cmd.Parameters["@engine"].Value = nudEngine.Value;
                cmd.Parameters["@year"].Value = nudYear.Value;
                cmd.Parameters["@fuel"].Value = cbFuel.SelectedItem;
                cmd.Parameters["@row_id"].Value = rowId;

                if (pictureFileName != null)
                {
                    cmd.Parameters["@image"].Value = File.ReadAllBytes(pictureFileName);
                }
                else
                {
                    cmd.Parameters["@image"].Value = null;
                }
                cmd.ExecuteNonQuery();
                DialogResult = DialogResult.OK;
                Close();


            }
            catch (Exception exc)
            {
                DialogHelper.Error(exc.Message);
            }
        }

        private bool ValidateData()
        {
            if (cbBrands.SelectedIndex > -1 && 
                cbModels.SelectedIndex > -1 &&
                cbTypes.SelectedIndex > -1 &&
                cbFuel.SelectedIndex > -1 &&
                mtbRegistration.Text.Replace(" ","").Length > 0 )
            {
                return true;
            }
            else
            {
                DialogHelper.Error("Sprawdź formularz");
                return false;
            }
        }
    }
}
