using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class saldos_media : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        string clv_media = "";

        int last_id = 0;

        string status = "";

        string c_ene, f_ene, c_feb, f_feb, c_mar, f_mar, c_abr, f_abr, c_may, f_may, c_jun, f_jun, c_jul, f_jul, c_ago, f_ago, c_sep, f_sep, c_oct, f_oct, c_nov, f_nov, c_dic, f_dic = "";

        string senero, sfebrero, smarzo, sabril, smayo, sjunio, sjulio, sagosto, sseptiembre, soctubre, snoviembre, sdiciembre = "";

        private void limpiarB_Click(object sender, EventArgs e)
        {

        }

        private void listaSaldos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string RutaImgHM, NombreImgHM, RutaImgHM2, NombreImgHM2, RutaImgHM3, NombreImgHM3, RutaImgHM4, NombreImgHM4, RutaImgHM5, NombreImgHM5, nacional = "";

        public saldos_media()
        {
            con.Close();
            InitializeComponent();
            listaSaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //llenado de la tabla
            llenar();

            //llenado de los ComboBox
            abrevpauta();
            account();
            DAF();
            supply();
            hoteles();

            //seleccionando combox
            comboPauta.SelectedIndex = 0;
            comboAccount.SelectedIndex = 0;
            comboDAF.SelectedIndex = 0;
            comboMarket.SelectedIndex = 0;
            comboHoteles.SelectedIndex = 0;
            comboCategoria.SelectedIndex = 0;
            comboFormaMKF.SelectedIndex = 0;
            comboPorcentajeMKF.SelectedIndex = 0;
            comboPago.SelectedIndex = 0;
            comboDivisa.SelectedIndex = 0;
        }

        public void hoteles()
        {
            try
            {
                con.Close();

                string selectQuery = "select * from abrev_hoteles";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboHoteles.ValueMember = "id";
                comboHoteles.DisplayMember = "hotel";
                //comboHoteles.DisplayMember = "abreviatura_hotel";
                comboHoteles.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void supply()
        {
            try
            {
                con.Close();

                string selectQuery = "select * from supply_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboMarket.ValueMember = "id";
                comboMarket.DisplayMember = "nombre";
                comboMarket.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DAF()
        {
            try
            {
                con.Close();

                string selectQuery = "select * from ejecutivo_daf";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboDAF.ValueMember = "id";
                comboDAF.DisplayMember = "nombre";
                comboDAF.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void account()
        {
            try
            {
                con.Close();

                string selectQuery = "select * from account_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboAccount.ValueMember = "id";
                comboAccount.DisplayMember = "nombre";
                comboAccount.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void abrevpauta()
        {
            try
            {
                con.Close();

                string selectQuery = "select * from abrev_pauta";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboPauta.ValueMember = "idabrev_pauta";
                comboPauta.DisplayMember = "nombre";
                comboPauta.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void llenar()
        {
            try
            {
                con.Close();

                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from saldos_media", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaSaldos.Rows.Add();
                    listaSaldos.Rows[n].Cells[0].Value = item["id_saldos"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["clave_hann"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["siglas"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["fecha"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["folio_m"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["pauta"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["market_manager"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["anticipo"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["estatus_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["estatus_facturacion"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["forma_pago"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["daf"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["comentarios"].ToString();

                    con.Close();
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void limpiar()
        {
            tRazon.Text = "";
            tNombre.Text = "";
            tMonto.Text = "";
            tAnticipo.Text = "";
            tCobrado.Text = "";
            tFacturado.Text = "";
            tEnero.Text = "";
            tFebrero.Text = "";
            tMarzo.Text = "";
            tAbril.Text = "";
            tMayo.Text = "";
            tJunio.Text = "";
            tJulio.Text = "";
            tAgosto.Text = "";
            tSeptiembre.Text = "";
            tOctubre.Text = "";
            tNoviembre.Text = "";
            tDiciembre.Text = "";
            tObservaciones.Text = "";

            //limpiar campos
            tEnero.Text = "";
            cEnero.Checked = false;
            tFebrero.Text = "";
            cFebrero.Checked = false;
            tMarzo.Text = "";
            cMarzo.Checked = false;
            tAbril.Text = "";
            cAbril.Checked = false;
            tMayo.Text = "";
            cMayo.Checked = false;
            tJunio.Text = "";
            cJunio.Checked = false;
            tJulio.Text = "";
            cJulio.Checked = false;
            tAgosto.Text = "";
            cAgosto.Checked = false;
            tSeptiembre.Text = "";
            cSeptiembre.Checked = false;
            tOctubre.Text = "";
            cOctubre.Checked = false;
            tNoviembre.Text = "";
            cNoviembre.Checked = false;
            tDiciembre.Text = "";
            cDiciembre.Checked = false;

            listaSaldos.Rows.Clear();
            listaSaldos.Refresh();

            llenar();
        }

        public void status_check()
        {
            //activo
            if (campaniaStatus.Checked == true)
            {
                status = "SI";
            }
            else
            {
                status = "NO";
            }
            //facturado y cobrado
            if (cene.Checked == true)
            {
                c_ene = "SI";
            }
            else
            {
                c_ene = "NO";
            }

            if (fene.Checked == true)
            {
                f_ene = "SI";
            }
            else
            {
                f_ene = "NO";
            }


            if (cfeb.Checked == true)
            {
                c_feb = "SI";
            }
            else
            {
                c_feb = "NO";
            }

            if (ffeb.Checked == true)
            {
                f_feb = "SI";
            }
            else
            {
                f_feb = "NO";
            }


            if (cmar.Checked == true)
            {
                c_mar = "SI";
            }
            else
            {
                c_mar = "NO";
            }

            if (fmar.Checked == true)
            {
                f_mar = "SI";
            }
            else
            {
                f_mar = "NO";
            }


            if (cabr.Checked == true)
            {
                c_abr = "SI";
            }
            else
            {
                c_abr = "NO";
            }

            if (fabr.Checked == true)
            {
                f_abr = "SI";
            }
            else
            {
                f_abr = "NO";
            }


            if (cmay.Checked == true)
            {
                c_may = "SI";
            }
            else
            {
                c_may = "NO";
            }

            if (fmay.Checked == true)
            {
                f_may = "SI";
            }
            else
            {
                f_may = "NO";
            }


            if (cjun.Checked == true)
            {
                c_jun = "SI";
            }
            else
            {
                c_jun = "NO";
            }

            if (fjun.Checked == true)
            {
                f_jun = "SI";
            }
            else
            {
                f_jun = "NO";
            }


            if (cjul.Checked == true)
            {
                c_jul = "SI";
            }
            else
            {
                c_jul = "NO";
            }

            if (fjul.Checked == true)
            {
                f_jul = "SI";
            }
            else
            {
                f_jul = "NO";
            }


            if (cago.Checked == true)
            {
                c_ago = "SI";
            }
            else
            {
                c_ago = "NO";
            }

            if (fago.Checked == true)
            {
                f_ago = "SI";
            }
            else
            {
                f_ago = "NO";
            }


            if (csep.Checked == true)
            {
                c_sep = "SI";
            }
            else
            {
                c_sep = "NO";
            }

            if (fsep.Checked == true)
            {
                f_sep = "SI";
            }
            else
            {
                f_sep = "NO";
            }


            if (coct.Checked == true)
            {
                c_oct = "SI";
            }
            else
            {
                c_oct = "NO";
            }

            if (foct.Checked == true)
            {
                f_oct = "SI";
            }
            else
            {
                f_oct = "NO";
            }


            if (cnov.Checked == true)
            {
                c_nov = "SI";
            }
            else
            {
                c_nov = "NO";
            }

            if (fnov.Checked == true)
            {
                f_nov = "SI";
            }
            else
            {
                f_nov = "NO";
            }


            if (cdic.Checked == true)
            {
                c_dic = "SI";
            }
            else
            {
                c_dic = "NO";
            }

            if (fdic.Checked == true)
            {
                f_dic = "SI";
            }
            else
            {
                f_dic = "NO";
            }

            //meses activos
            if (cEnero.Checked == true)
            {
                senero = "SI";
            }
            else
            {
                senero = "NO";
            }

            if (cFebrero.Checked == true)
            {
                sfebrero = "SI";
            }
            else
            {
                sfebrero = "NO";
            }

            if (cMarzo.Checked == true)
            {
                smarzo = "SI";
            }
            else
            {
                smarzo = "NO";
            }

            if (cAbril.Checked == true)
            {
                sabril = "SI";
            }
            else
            {
                sabril = "NO";
            }

            if (cMayo.Checked == true)
            {
                smayo = "SI";
            }
            else
            {
                smayo = "NO";
            }

            if (cJunio.Checked == true)
            {
                sjunio = "SI";
            }
            else
            {
                sjunio = "NO";
            }

            if (cJulio.Checked == true)
            {
                sjulio = "SI";
            }
            else
            {
                sjulio = "NO";
            }

            if (cAgosto.Checked == true)
            {
                sagosto = "SI";
            }
            else
            {
                sagosto = "NO";
            }

            if (cSeptiembre.Checked == true)
            {
                sseptiembre = "SI";
            }
            else
            {
                sseptiembre = "NO";
            }

            if (cOctubre.Checked == true)
            {
                soctubre = "SI";
            }
            else
            {
                soctubre = "NO";
            }

            if (cNoviembre.Checked == true)
            {
                snoviembre = "SI";
            }
            else
            {
                snoviembre = "NO";
            }

            if (cDiciembre.Checked == true)
            {
                sdiciembre = "SI";
            }
            else
            {
                sdiciembre = "NO";
            }
        }

        private void listaSaldos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaSaldos.SelectedRows[0].Index;
                id.Text = listaSaldos.Rows[n].Cells[0].Value.ToString();
                tHann.Text = listaSaldos.Rows[n].Cells[1].Value.ToString();
                tSiglas.Text = listaSaldos.Rows[n].Cells[2].Value.ToString();
                fecha_Pauta.Text = listaSaldos.Rows[n].Cells[3].Value.ToString();
                tMedia.Text = listaSaldos.Rows[n].Cells[4].Value.ToString();
                tRazon.Text = listaSaldos.Rows[n].Cells[5].Value.ToString();
                tNombre.Text = listaSaldos.Rows[n].Cells[6].Value.ToString();
                tMonto.Text = listaSaldos.Rows[n].Cells[7].Value.ToString();
                comboDivisa.Text = listaSaldos.Rows[n].Cells[8].Value.ToString();
                comboPauta.Text = listaSaldos.Rows[n].Cells[9].Value.ToString();
                comboMarket.Text = listaSaldos.Rows[n].Cells[10].Value.ToString();
                tAnticipo.Text = listaSaldos.Rows[n].Cells[11].Value.ToString();
                tCobrado.Text = listaSaldos.Rows[n].Cells[12].Value.ToString();
                tFacturado.Text = listaSaldos.Rows[n].Cells[13].Value.ToString();
                tEnero.Text = listaSaldos.Rows[n].Cells[14].Value.ToString();
                tFebrero.Text = listaSaldos.Rows[n].Cells[15].Value.ToString();
                tMarzo.Text = listaSaldos.Rows[n].Cells[16].Value.ToString();
                tAbril.Text = listaSaldos.Rows[n].Cells[17].Value.ToString();
                tMayo.Text = listaSaldos.Rows[n].Cells[18].Value.ToString();
                tJunio.Text = listaSaldos.Rows[n].Cells[19].Value.ToString();
                tJulio.Text = listaSaldos.Rows[n].Cells[20].Value.ToString();
                tAgosto.Text = listaSaldos.Rows[n].Cells[21].Value.ToString();
                tSeptiembre.Text = listaSaldos.Rows[n].Cells[22].Value.ToString();
                tOctubre.Text = listaSaldos.Rows[n].Cells[23].Value.ToString();
                tNoviembre.Text = listaSaldos.Rows[n].Cells[24].Value.ToString();
                tDiciembre.Text = listaSaldos.Rows[n].Cells[25].Value.ToString();
                comboPago.Text = listaSaldos.Rows[n].Cells[26].Value.ToString();
                comboAccount.Text = listaSaldos.Rows[n].Cells[27].Value.ToString();
                comboDAF.Text = listaSaldos.Rows[n].Cells[28].Value.ToString();
                tObservaciones.Text = listaSaldos.Rows[n].Cells[29].Value.ToString();


                try
                {
                    con.Close();

                    con.Open();
                    string sql = "SELECT * FROM saldos_media WHERE id_saldos ='" + id.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        status = Convert.ToString(reader["activa"]);
                        c_ene = Convert.ToString(reader["cene"]);
                        f_ene = Convert.ToString(reader["fene"]);
                        c_feb = Convert.ToString(reader["cfeb"]);
                        f_feb = Convert.ToString(reader["ffeb"]);
                        c_mar = Convert.ToString(reader["cmar"]);
                        f_mar = Convert.ToString(reader["fmar"]);
                        c_abr = Convert.ToString(reader["cabr"]);
                        f_abr = Convert.ToString(reader["fabr"]);
                        c_may = Convert.ToString(reader["cmay"]);
                        f_may = Convert.ToString(reader["fmay"]);
                        c_jun = Convert.ToString(reader["cjun"]);
                        f_jun = Convert.ToString(reader["fjun"]);
                        c_jul = Convert.ToString(reader["cjul"]);
                        f_jul = Convert.ToString(reader["fjul"]);
                        c_ago = Convert.ToString(reader["cago"]);
                        f_ago = Convert.ToString(reader["fago"]);
                        c_sep = Convert.ToString(reader["csep"]);
                        f_sep = Convert.ToString(reader["fsep"]);
                        c_oct = Convert.ToString(reader["coct"]);
                        f_oct = Convert.ToString(reader["foct"]);
                        c_nov = Convert.ToString(reader["cnov"]);
                        f_nov = Convert.ToString(reader["fnov"]);
                        c_dic = Convert.ToString(reader["cdic"]);
                        f_dic = Convert.ToString(reader["fdic"]);
                        //meses
                        senero = Convert.ToString(reader["senero"]);
                        sfebrero = Convert.ToString(reader["sfebrero"]);
                        smarzo = Convert.ToString(reader["smarzo"]);
                        sabril = Convert.ToString(reader["sabril"]);
                        smayo = Convert.ToString(reader["smayo"]);
                        sjunio = Convert.ToString(reader["sjunio"]);
                        sjulio = Convert.ToString(reader["sjulio"]);
                        sagosto = Convert.ToString(reader["sagosto"]);
                        sseptiembre = Convert.ToString(reader["sseptiembre"]);
                        soctubre = Convert.ToString(reader["soctubre"]);
                        snoviembre = Convert.ToString(reader["snoviembre"]);
                        sdiciembre = Convert.ToString(reader["sdiciembre"]);

                        if (status == "SI")
                        {
                            campaniaStatus.Checked = true;
                        }

                        if (f_ene == "SI")
                        {
                            fene.Checked = true;
                        }

                        else
                        {
                            fene.Checked = false;
                        }


                        if (c_ene == "SI")
                        {
                            cene.Checked = true;
                        }

                        else
                        {
                            cene.Checked = false;
                        }


                        if (c_feb == "SI")
                        {
                            cfeb.Checked = true;
                        }

                        else
                        {
                            cfeb.Checked = false;
                        }


                        if (f_feb == "SI")
                        {
                            ffeb.Checked = true;
                        }

                        else
                        {
                            ffeb.Checked = false;
                        }


                        if (c_mar == "SI")
                        {
                            cmar.Checked = true;
                        }

                        else
                        {
                            cmar.Checked = false;
                        }


                        if (f_mar == "SI")
                        {
                            fmar.Checked = true;
                        }

                        else
                        {
                            fmar.Checked = false;
                        }


                        if (c_abr == "SI")
                        {
                            cabr.Checked = true;
                        }

                        else
                        {
                            cabr.Checked = false;
                        }


                        if (f_abr == "SI")
                        {
                            fabr.Checked = true;
                        }

                        else
                        {
                            fabr.Checked = false;
                        }


                        if (f_may == "SI")
                        {
                            cmay.Checked = true;
                        }

                        else
                        {
                            cmay.Checked = false;
                        }


                        if (f_mar == "SI")
                        {
                            fmay.Checked = true;
                        }

                        else
                        {
                            fmay.Checked = false;
                        }


                        if (c_jun == "SI")
                        {
                            cjun.Checked = true;
                        }

                        else
                        {
                            cjun.Checked = false;
                        }


                        if (f_jun == "SI")
                        {
                            fjun.Checked = true;
                        }

                        else
                        {
                            fjun.Checked = false;
                        }


                        if (c_jul == "SI")
                        {
                            cjul.Checked = true;
                        }

                        else
                        {
                            cjul.Checked = false;
                        }


                        if (f_jul == "SI")
                        {
                            fjul.Checked = true;
                        }

                        else
                        {
                            fjul.Checked = false;
                        }


                        if (c_ago == "SI")
                        {
                            cago.Checked = true;
                        }

                        else
                        {
                            cago.Checked = false;
                        }


                        if (f_ago == "SI")
                        {
                            fago.Checked = true;
                        }

                        else
                        {
                            fago.Checked = false;
                        }


                        if (c_sep == "SI")
                        {
                            csep.Checked = true;
                        }

                        else
                        {
                            csep.Checked = false;
                        }


                        if (f_sep == "SI")
                        {
                            fsep.Checked = true;
                        }

                        else
                        {
                            fsep.Checked = false;
                        }


                        if (c_oct == "SI")
                        {
                            coct.Checked = true;
                        }

                        else
                        {
                            coct.Checked = false;
                        }


                        if (f_oct == "SI")
                        {
                            foct.Checked = true;
                        }

                        else
                        {
                            foct.Checked = false;
                        }


                        if (c_nov == "SI")
                        {
                            cnov.Checked = true;
                        }

                        else
                        {
                            cnov.Checked = false;
                        }


                        if (f_nov == "SI")
                        {
                            fnov.Checked = true;
                        }

                        else
                        {
                            fnov.Checked = false;
                        }


                        if (c_dic == "SI")
                        {
                            cdic.Checked = true;
                        }

                        else
                        {
                            cdic.Checked = false;
                        }


                        if (f_dic == "SI")
                        {
                            fdic.Checked = true;
                        }

                        else
                        {
                            fdic.Checked = false;
                        }


                        //MESES ACTIVOS
                        if (senero == "SI")
                        {
                            cEnero.Checked = true;
                        }

                        else
                        {
                            cEnero.Checked = false;
                        }


                        if (sfebrero == "SI")
                        {
                            cFebrero.Checked = true;
                        }

                        else
                        {
                            cFebrero.Checked = false;
                        }


                        if (smarzo == "SI")
                        {
                            cMarzo.Checked = true;
                        }

                        else
                        {
                            cMarzo.Checked = false;
                        }


                        if (sabril == "SI")
                        {
                            cAbril.Checked = true;
                        }

                        else
                        {
                            cAbril.Checked = false;
                        }


                        if (smayo == "SI")
                        {
                            cMayo.Checked = true;
                        }

                        else
                        {
                            cMayo.Checked = false;
                        }


                        if (sjunio == "SI")
                        {
                            cJunio.Checked = true;
                        }

                        else
                        {
                            cJunio.Checked = false;
                        }


                        if (sjulio == "SI")
                        {
                            cJulio.Checked = true;
                        }

                        else
                        {
                            cJulio.Checked = false;
                        }


                        if (sagosto == "SI")
                        {
                            cAgosto.Checked = true;
                        }

                        else
                        {
                            cAgosto.Checked = false;
                        }


                        if (sseptiembre == "SI")
                        {
                            cSeptiembre.Checked = true;
                        }

                        else
                        {
                            cSeptiembre.Checked = false;
                        }


                        if (soctubre == "SI")
                        {
                            cOctubre.Checked = true;
                        }

                        else
                        {
                            cOctubre.Checked = false;
                        }


                        if (snoviembre == "SI")
                        {
                            cNoviembre.Checked = true;
                        }

                        else
                        {
                            cNoviembre.Checked = false;
                        }


                        if (sdiciembre == "SI")
                        {
                            cDiciembre.Checked = true;
                        }

                        else
                        {
                            cDiciembre.Checked = false;
                        }

                        //combo
                        nacional = Convert.ToString(reader["nacional"]);
                        comboNacional.Text = nacional;
                    }

                    con.Close();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                try
                {
                    con.Close();

                    status_check();

                    con.Open();

                    string date = fecha_Pauta.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO saldos_media (`clave_hann` , `siglas` , `folio_m` , `fecha` , `razon_social`, `nombre_comercial`, `monto_pauta` , `divisa`, `pauta`, `market_manager`, `anticipo`, `estatus_cobrado`, `estatus_facturacion`, `enero` , `febrero` , `marzo`  , `abril` , `mayo` , `junio` , `julio` , `agosto` , `septiembre` , `octubre`  , `noviembre` , `diciembre` , `forma_pago` , `account_manager` , `daf` , `comentarios`  , `hotel_siglas`  , `forma_calculo`  , `porcentaje` , `cene`, `fene` , `cfeb`, `ffeb`, `cmar`, `fmar` , `cabr`, `fabr` , `cmay`, `fmay` , `cjun`, `fjun`, `cjul`, `fjul` , `cago`, `fago` , `csep`, `fsep` , `coct`, `foct` , `cnov`, `fnov` , `cdic`, `fdic`, `activa` , `senero` , `sfebrero` , `smarzo`  , `sabril` , `smayo` , `sjunio` , `sjulio` , `sagosto` , `sseptiembre` , `soctubre`  , `snoviembre` , `sdiciembre` , `nacional`) VALUES ('" + tHann.Text + "','" + tSiglas.Text + "','" + tMedia.Text + "','" + date + "','" + tRazon.Text + "','" + tNombre.Text + "','" + Convert.ToDouble(tMonto.Text) + "','" + comboDivisa.Text + "','" + comboPauta.Text + "','" + comboMarket.Text + "','" + tAnticipo.Text + "','" + tCobrado.Text + "','" + tFacturado.Text + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + comboPago.Text + "','" + comboAccount.Text + "','" + comboDAF.Text + "','" + tObservaciones.Text + "','" + comboHoteles.Text + "','" + comboFormaMKF.Text + "','" + comboPorcentajeMKF.Text + "','" + c_ene + "','" + f_ene + "','" + c_feb + "','" + f_feb + "','" + c_mar + "','" + f_mar + "','" + c_abr + "','" + f_abr + "','" + c_may + "','" + f_may + "','" + c_jun + "','" + f_jun + "','" + c_jul + "','" + f_jul + "','" + c_ago + "','" + f_ago + "','" + c_sep + "','" + f_sep + "','" + c_oct + "','" + f_oct + "','" + c_nov + "','" + f_nov + "','" + c_dic + "','" + f_dic + "','" + status + "','" + senero + "','" + sfebrero + "','" + smarzo + "','" + sabril + "','" + smayo + "','" + sjunio + "','" + sjulio + "','" + sagosto + "','" + sseptiembre + "','" + soctubre + "','" + snoviembre + "','" + sdiciembre + "','" + comboNacional.Text + "' )", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    limpiar();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }

            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                status_check();

                string date = fecha_Pauta.Value.ToString("yyyy-MM-dd");

                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `saldos_media` SET `cene`='" + c_ene + "',`fene`='" + f_ene + "',`cfeb`='" + c_feb + "',`ffeb`='" + f_feb + "',`cmar`='" + c_mar + "',`fmar`='" + f_mar + "',`cabr`='" + c_abr + "',`fabr`='" + f_abr + "',`cmay`='" + c_may + "',`fmay`='" + f_may + "',`cjun`='" + c_jun + "',`fjun`='" + f_jun + "',`cjul`='" + c_jul + "',`fjul`='" + f_jul + "',`cago`='" + c_ago + "',`fago`='" + f_ago + "',`csep`='" + c_sep + "',`fsep`='" + f_sep + "',`coct`='" + c_oct + "',`foct`='" + f_oct + "',`cnov`='" + c_nov + "',`fnov`='" + f_nov + "', `cdic`='" + c_dic + "',`fdic`='" + f_dic + "', `clave_hann`='" + tHann.Text + "', `siglas`='" + tSiglas.Text + "', `folio_m`='" + tMedia.Text + "', `fecha`='" + date + "', `razon_social`='" + tRazon.Text + "',`nombre_comercial`='" + tNombre.Text + "',`monto_pauta`='" + tMonto.Text + "',`divisa`='" + comboDivisa.Text + "',`pauta`='" + comboPauta.Text + "',`market_manager`='" + comboMarket.Text + "',`anticipo`='" + tAnticipo.Text + "',`estatus_cobrado`='" + tCobrado.Text + "',`estatus_facturacion`='" + tFacturado.Text + "',`enero`='" + tEnero.Text + "',`febrero`='" + tFebrero.Text + "',`marzo`='" + tMarzo.Text + "',`abril`='" + tAbril.Text + "',`mayo`='" + tMayo.Text + "',`junio`='" + tJunio.Text + "',`julio`='" + tJulio.Text + "',`agosto`='" + tAgosto.Text + "',`septiembre`='" + tSeptiembre.Text + "',`octubre`='" + tOctubre.Text + "',`noviembre`='" + tNoviembre.Text + "',`diciembre`='" + tDiciembre.Text + "',`forma_pago`='" + comboPago.Text + "',`account_manager`='" + comboAccount.Text + "',`daf`='" + comboDAF.Text + "',`comentarios`='" + tObservaciones.Text + "',`activa`='" + status + "',`hotel_siglas`='" + comboHoteles.Text + "',`forma_calculo`='" + comboFormaMKF.Text + "',`porcentaje`='" + comboPorcentajeMKF.Text + "',`nacional`='" + comboNacional.Text + "' WHERE id_saldos = '" + id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();

                limpiar();
                llenar();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                try
                {
                    con.Close();

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `saldos_media` WHERE id_saldos ='" + id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiar();
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
            }
            else
            {
                MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toExcel_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "saldos_media";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < listaSaldos.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listaSaldos.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

            //if (general.Privilegios == "admin")
            //{
            // Creating a Excel object. 
            //    Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            //    Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            //    try
            //    {
            //        worksheet = workbook.ActiveSheet;
            //        worksheet.Name = "ExportedFromDatGrid";

            //        int cellRowIndex = 1;
            //        int cellColumnIndex = 1;

            //        for (int i = 0; i < listaSaldos.Rows.Count - 1; i++)
            //        {
            //            for (int j = 0; j < listaSaldos.Columns.Count; j++)
            //            {
            //                if (cellRowIndex == 1)
            //                {
            //                    worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Columns[j].HeaderText;
            //                }
            //                else
            //                {
            //                    worksheet.Cells[cellRowIndex, cellColumnIndex] = listaSaldos.Rows[i].Cells[j].Value.ToString();
            //                }
            //                cellColumnIndex++;
            //            }
            //            cellColumnIndex = 1;
            //            cellRowIndex++;
            //        }
            //        SaveFileDialog saveDialog = new SaveFileDialog();
            //        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            //        saveDialog.FilterIndex = 2;

            //        if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //        {
            //            workbook.SaveAs(saveDialog.FileName);
            //            MessageBox.Show("Archivo generado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //    }
            //    catch (System.Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    finally
            //    {
            //        excel.Quit();
            //        workbook = null;
            //        excel = null;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No tienes privilegios necesarios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                string sentencia = "";
                string busqueda = "";

                if (cbFechas.Checked == true)
                {
                    string inicio = fechaDesde.Value.ToString("yyyy/MM/dd");
                    string fin = fechaHasta.Value.ToString("yyyy/MM/dd");
                    sentencia = "SELECT * FROM saldos_media WHERE fecha BETWEEN'" + inicio + "'AND'" + fin + "'";
                }


                if (cbRazon.Checked == true)
                {
                    busqueda = tbRazon.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE razon_social LIKE '%" + busqueda + "%'";
                }

                if (cbComercial.Checked == true)
                {
                    busqueda = tbComercial.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE nombre_comercial LIKE '%" + busqueda + "%'";
                }

                if (cbMarket.Checked == true)
                {
                    busqueda = tbMarket.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE market_manager LIKE '%" + busqueda + "%'";
                }

                if (cbAccount.Checked == true)
                {
                    busqueda = tbAccount.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE account_manager LIKE '%" + busqueda + "%'";
                }

                if (cbMedia.Checked == true)
                {
                    busqueda = tbClaveM.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE clave_media LIKE '%" + busqueda + "%'";
                }

                if (cbForma.Checked == true)
                {
                    busqueda = comboBForma.Text;
                    sentencia = "SELECT * FROM saldos_media WHERE forma_pago LIKE '%" + busqueda + "%'";
                }
                con.Close();

                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter(sentencia, con);
                DataTable dt = new DataTable();
                listaSaldos.Rows.Clear();
                listaSaldos.Refresh();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaSaldos.Rows.Add();
                    listaSaldos.Rows[n].Cells[0].Value = item["id_saldos"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["clave_hann"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["siglas"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["folio_m"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["fecha"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["pauta"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["market_manager"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["anticipo"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["estatus_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["estatus_facturacion"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["forma_pago"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["daf"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["comentarios"].ToString();
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void calculo_Click(object sender, EventArgs e)
        {
            try
            {
                int cantMeses = 0;
                double montoPauta = 0;
                double montoAnticipo = 0;
                double subtotal = 0;
                double totalPauta = 0;
                double redondeado = 0;
                double total = 0;

                if (cEnero.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cFebrero.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cMarzo.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cAbril.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cMayo.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cJunio.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cJulio.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cAgosto.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cSeptiembre.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cOctubre.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cNoviembre.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }
                if (cDiciembre.Checked == true)
                {
                    cantMeses = cantMeses + 1;
                    totalMeses.Text = Convert.ToString(cantMeses);
                }

                if (cantMeses == 0)
                {
                    MessageBox.Show("Selecciona al menos un mes.", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (comboNacional.SelectedIndex == 0)
                    {
                        montoPauta = Convert.ToDouble(tMontoIVA.Text);
                    }
                    else if (comboNacional.SelectedIndex == 1)
                    {
                        montoPauta = Convert.ToDouble(tMonto.Text);
                    }

                    montoAnticipo = Convert.ToDouble(tAnticipo.Text);
                    subtotal = montoPauta - montoAnticipo;
                    totalPauta = subtotal / cantMeses;
                    redondeado = Math.Round(totalPauta, 2);
                    total = redondeado;

                    if (cEnero.Checked == true)
                    {
                        tEnero.Text = total.ToString("N2");
                    }
                    if (cFebrero.Checked == true)
                    {
                        tFebrero.Text = total.ToString("N2");
                    }
                    if (cMarzo.Checked == true)
                    {
                        tMarzo.Text = total.ToString("N2");
                    }
                    if (cAbril.Checked == true)
                    {
                        tAbril.Text = total.ToString("N2");
                    }
                    if (cMayo.Checked == true)
                    {
                        tMayo.Text = total.ToString("N2");
                    }
                    if (cJunio.Checked == true)
                    {
                        tJunio.Text = total.ToString("N2");
                    }
                    if (cJulio.Checked == true)
                    {
                        tJulio.Text = total.ToString("N2");
                    }
                    if (cAgosto.Checked == true)
                    {
                        tAgosto.Text = total.ToString("N2");
                    }
                    if (cSeptiembre.Checked == true)
                    {
                        tSeptiembre.Text = total.ToString("N2");
                    }
                    if (cOctubre.Checked == true)
                    {
                        tOctubre.Text = total.ToString("N2");
                    }
                    if (cNoviembre.Checked == true)
                    {
                        tNoviembre.Text = total.ToString("N2");
                    }
                    if (cDiciembre.Checked == true)
                    {
                        tDiciembre.Text = total.ToString("N2");
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error, verifique campos!", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


        }

        private void tMedia_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                con.Open();
                string sql = "SELECT id_saldos FROM saldos_media ORDER BY id_saldos DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    last_id = Convert.ToInt32(reader["id_saldos"]);
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

            DateTime todaysDate = DateTime.Now.Date;
            int year = todaysDate.Year;
            int month = todaysDate.Month;
            int consec = last_id + 1;

            clv_media = Convert.ToString(year) + "-" + Convert.ToString(month) + "-" + labelPauta.Text + "-" + comboCategoria.Text + "-" + labelHotel.Text + "-" + consec;

            tMedia.Text = clv_media;
        }

        private void tMonto_TextChanged(object sender, EventArgs e)
        {
            if (tMonto.Text == "")
            {
                tMonto.Text = "0";
            }
            else
            {
                try
                {
                    double precio = 0;
                    double precioIVA = 0;

                    precio = Convert.ToInt32(tMonto.Text);

                    precioIVA = precio * 1.16;

                    double total = Math.Round(precioIVA, 2);

                    tMontoIVA.Text = Convert.ToString(precioIVA);
                }
                catch (Exception m)
                {
                    MessageBox.Show("Revisa campo de monto", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show(m.Message);
                }
            }
        }

        private void comboHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboHoteles.SelectedIndex);
                int idCombo = valor + 1;
                con.Close();
                con.Open();
                string sql = "SELECT `abreviatura_hotel` FROM `abrev_hoteles` WHERE id = '" + idCombo + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string nombreHotel = Convert.ToString(reader["abreviatura_hotel"]);
                    labelHotel.Text = nombreHotel;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void explor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                linkIUno.Text = fdlg.FileName;
                nombreUno.Text = Path.GetFileName(linkIUno.Text);
            }

            RutaImgHM = fdlg.FileName;
            NombreImgHM = nombreUno.Text;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreImgHM);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaImgHM);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
                //nombreImgHM.Text = "";
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uploadCinco_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreImgHM5);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaImgHM5);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
                //nombreImgHM.Text = "";
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exploreCinco_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                linkCinco.Text = fdlg.FileName;
                nombreCinco.Text = Path.GetFileName(linkCinco.Text);
            }

            RutaImgHM5 = fdlg.FileName;
            NombreImgHM5 = nombreCinco.Text;
        }

        private void uploadCuatro_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreImgHM4);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaImgHM4);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
                //nombreImgHM.Text = "";
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exploreCuatro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                linkCuatro.Text = fdlg.FileName;
                nombreCuatro.Text = Path.GetFileName(linkCuatro.Text);
            }

            RutaImgHM4 = fdlg.FileName;
            NombreImgHM4 = nombreCuatro.Text;
        }

        private void uploadTres_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreImgHM3);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaImgHM3);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
                //nombreImgHM.Text = "";
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exploreTres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                linkTres.Text = fdlg.FileName;
                nombreTres.Text = Path.GetFileName(linkTres.Text);
            }

            RutaImgHM3 = fdlg.FileName;
            NombreImgHM3 = nombreTres.Text;
        }

        private void uploadDos_Click(object sender, EventArgs e)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreImgHM2);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaImgHM2);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //linkHeaderM.Text = "files.000webhost.com/images/" + variables.NombreImgHM;
                //nombreImgHM.Text = "";
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exploreDos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                linkDos.Text = fdlg.FileName;
                nombreDos.Text = Path.GetFileName(linkDos.Text);
            }

            RutaImgHM2 = fdlg.FileName;
            NombreImgHM2 = nombreDos.Text;
        }

        private void tMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPauta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboPauta.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT `abreviatura_pauta` FROM `abrev_pauta` WHERE id = '" + idCombo + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string t_pauta = Convert.ToString(reader["abreviatura_pauta"]);
                    labelPauta.Text = t_pauta;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}