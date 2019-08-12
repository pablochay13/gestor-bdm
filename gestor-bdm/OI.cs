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
    public partial class OI : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);
        string forma_calculo, transfer_bancaria, compensacion, noches, ambos, t_campo1, t_campo2, t_campo3 = "";
        string senero, sfebrero, smarzo, sabril, smayo, sjunio, sjulio, sagosto, sseptiembre, soctubre, snoviembre, sdiciembre = "";
        string clv_media, RutaImgHM, NombreImgHM, clave_pais, t_pais = "";
        string RutaImgHM2, NombreImgHM2, RutaImgHM3, NombreImgHM3 = "";
        int last_id, cantidad = 0;

        string RutaEne, RutaFeb, RutaMar, RutaAbr, RutaMay, RutaJun, RutaJul, RutaAgo, RutaSep, RutaOct, RutaNov, RutaDic = "";
        string NombreArcEne, NombreArcFeb, NombreArcMar, NombreArcAbr, NombreArcMay, NombreArcJun, NombreArcJul, NombreArcAgo, NombreArcSep, NombreArcOct, NombreArcNov, NombreArcDic = "";

        public OI()
        {
            InitializeComponent();

            listaSaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //llenado combos
            tipoPauta();
            statusContrato();
            hotelOrden();
            supply();
            Daf();
            account();
            paises();
            llenar();
            //seleccion combos 
            comboCategoria.SelectedIndex = 0;
            comboPorcentajeMKF.SelectedIndex = 0;
            comboDivisa.SelectedIndex = 0;
            comboNacional.SelectedIndex = 0;
            comboOp.SelectedIndex = 0;
            comboCuenta.SelectedIndex = 0;
            comboCuentaOp.SelectedIndex = 0;
            comboRazonOp.SelectedIndex = 0;
            comboComisiones.SelectedIndex = 0;
            comboQ.SelectedIndex = 0;
            comboQPorcentaje.SelectedIndex = 0;
            textStatusOI.SelectedIndex = 0;
            //año
            string anio_pauta = "";

            anio_pauta = dateDesdeMKF.Value.Year.ToString();

            tEnero.Text = anio_pauta;
            tFebrero.Text = anio_pauta;
            tMarzo.Text = anio_pauta;
            tAbril.Text = anio_pauta;
            tMayo.Text = anio_pauta;
            tJunio.Text = anio_pauta;
            tJulio.Text = anio_pauta;
            tAgosto.Text = anio_pauta;
            tSeptiembre.Text = anio_pauta;
            tOctubre.Text = anio_pauta;
            tNoviembre.Text = anio_pauta;
            tDiciembre.Text = anio_pauta;

            comboQ.Visible = false;
            label41.Visible = false;

            campo1.Visible = false;
            combo1.Visible = false;

            campo2.Visible = false;
            combo2.Visible = false;

            campo3.Visible = false;
            combo3.Visible = false;
        }

        public void checkStatus()
        {
            if (checkProduccion.Checked == true)
            {
                forma_calculo = "Producción";
            }

            if (checkEmitidos.Checked == true)
            {
                forma_calculo = "Pagos Emitidos";
            }

            if (checkTransferencia.Checked == true)
            {
                transfer_bancaria = "Si";
            }
            else
            {
                transfer_bancaria = "No";
            }

            if (checkBCompensacion.Checked == true)
            {
                compensacion = "Si";
            }
            else
            {
                compensacion = "No";
            }

            if (checkNoches.Checked == true)
            {
                noches = "Si";
            }
            else
            {
                noches = "No";
            }

            if (checkAmbos.Checked == true)
            {
                ambos = "Si";
            }
            else
            {
                ambos = "No";
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

        public void razonSocial()
        {
            try
            {
                con.Close();

                string selectQuery = "select id_clientes, razon_social from clientes where region = '" + clave_pais + "'";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboRazon.ValueMember = "id_clientes";
                comboRazon.DisplayMember = "razon_social";
                comboRazon.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void paises()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, region from paises";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboPais.ValueMember = "id";
                comboPais.DisplayMember = "region";
                comboPais.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void tipoPauta()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, nombre from abrev_pauta";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboPauta.ValueMember = "id";
                comboPauta.DisplayMember = "nombre";
                comboPauta.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void statusContrato()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, concepto from contrato_status";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboContrato.ValueMember = "id";
                comboContrato.DisplayMember = "concepto";
                comboContrato.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void hotelOrden()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, hotel from abrev_hoteles";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboHoteles.ValueMember = "id";
                comboHoteles.DisplayMember = "hotel";
                comboHoteles.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void esquemaComision()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, negociacion from esquema_comision where region = '" + clave_pais + "'";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboComisiones.ValueMember = "id";
                comboComisiones.DisplayMember = "negociacion";
                comboComisiones.DataSource = dt;

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

                string selectQuery = "select id, nombre from supply_manager";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboSupply.ValueMember = "id";
                comboSupply.DisplayMember = "nombre";
                comboSupply.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Daf()
        {
            try
            {
                con.Close();

                string selectQuery = "select id, nombre from ejecutivo_daf";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                comboEjecutivoDAF.ValueMember = "id";
                comboEjecutivoDAF.DisplayMember = "nombre";
                comboEjecutivoDAF.DataSource = dt;

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

                string selectQuery = "select id, nombre from account_manager";
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

        private void Explore_2_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreDos.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void Explore_3_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreTres.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void ExploreEne_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameEne.Text = fdlg.FileName;
                archivoEne.Text = Path.GetFileName(nameEne.Text);
            }

            RutaEne = fdlg.FileName;
            NombreArcEne = tMedia.Text + "-" + archivoEne.Text;
            //MessageBox.Show(NombreArcEne);
        }

        private void ExploreFeb_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameFeb.Text = fdlg.FileName;
                archivoFeb.Text = Path.GetFileName(nameFeb.Text);
            }

            RutaFeb = fdlg.FileName;
            NombreArcFeb = tMedia.Text + "-" + archivoFeb.Text;
            //MessageBox.Show(NombreArcFeb);
        }

        private void ExploreMar_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameMar.Text = fdlg.FileName;
                archivoMar.Text = Path.GetFileName(nameMar.Text);
            }

            RutaMar = fdlg.FileName;
            NombreArcMar = tMedia.Text + "-" + archivoMar.Text;
            //MessageBox.Show(NombreArcMar);
        }

        private void ExploreAbr_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameAbr.Text = fdlg.FileName;
                archivoAbr.Text = Path.GetFileName(nameAbr.Text);
            }

            RutaAbr = fdlg.FileName;
            NombreArcAbr = tMedia.Text + "-" + archivoAbr.Text;
            //MessageBox.Show(NombreArcAbr);
        }

        private void ExploreMay_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameMay.Text = fdlg.FileName;
                archivoMay.Text = Path.GetFileName(nameMay.Text);
            }

            RutaMay = fdlg.FileName;
            NombreArcMay = tMedia.Text + "-" + archivoMay.Text;
            //MessageBox.Show(NombreArcMay);
        }

        private void ExploreJun_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameJun.Text = fdlg.FileName;
                archivoJun.Text = Path.GetFileName(nameJun.Text);
            }

            RutaJun = fdlg.FileName;
            NombreArcJun = tMedia.Text + "-" + archivoJun.Text;
            //MessageBox.Show(NombreArcJun);
        }

        private void ExploreJul_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameJul.Text = fdlg.FileName;
                archivoJul.Text = Path.GetFileName(nameJul.Text);
            }

            RutaJul = fdlg.FileName;
            NombreArcJul = tMedia.Text + "-" + archivoJul.Text;
            //MessageBox.Show(NombreArcJul);
        }

        private void ExploreAgo_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameAgo.Text = fdlg.FileName;
                archivoAgo.Text = Path.GetFileName(nameAgo.Text);
            }

            RutaAgo = fdlg.FileName;
            NombreArcAgo = tMedia.Text + "-" + archivoAgo.Text;
            //MessageBox.Show(NombreArcJul);
        }

        private void ExploreSep_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameSep.Text = fdlg.FileName;
                archivoSep.Text = Path.GetFileName(nameSep.Text);
            }

            RutaSep = fdlg.FileName;
            NombreArcSep = tMedia.Text + "-" + archivoSep.Text;
            //MessageBox.Show(NombreArcSep);
        }

        private void ExploreOct_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameOct.Text = fdlg.FileName;
                archivoOct.Text = Path.GetFileName(nameOct.Text);
            }

            RutaOct = fdlg.FileName;
            NombreArcOct = tMedia.Text + "-" + archivoOct.Text;
            //MessageBox.Show(NombreArcOct);
        }

        private void ExploreNov_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameNov.Text = fdlg.FileName;
                archivoNov.Text = Path.GetFileName(nameNov.Text);
            }

            RutaNov = fdlg.FileName;
            NombreArcNov = tMedia.Text + "-" + archivoNov.Text;
            //MessageBox.Show(NombreArcNov);
        }

        private void ExploreDic_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "BestDay Media";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                nameDic.Text = fdlg.FileName;
                archivoDic.Text = Path.GetFileName(nameDic.Text);
            }

            RutaDic = fdlg.FileName;
            NombreArcDic = tMedia.Text + "-" + archivoDic.Text;
            //MessageBox.Show(NombreArcDic);
        }

        private void LookEne_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreUno.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void Sumas_Click(object sender, EventArgs e)
        {
            double montoPauta = 0;

            if (comboNacional.SelectedIndex == 0)
            {
                montoPauta = Convert.ToDouble(tMontoIVA.Text);
            }
            else
            {
                montoPauta = Convert.ToDouble(tMonto.Text);
            }

            //Facturado
            double suma_facturado;
            double cantCEne = 0; double cantCFeb = 0; double cantCMar = 0; double cantCAbr = 0; double cantCMay = 0; double cantCJun = 0;
            double cantCJul = 0; double cantCAgo = 0; double cantCSep = 0; double cantCOct = 0; double cantCNov = 0; double cantCDic = 0;

            if (facturadoEne.Text == "")
            {
                facturadoEne.Text = "0";
            }
            else
            {
                cantCEne = Convert.ToDouble(facturadoEne.Text);
            }


            if (facturadoFeb.Text == "")
            {
                facturadoFeb.Text = "0";
            }
            else
            {
                cantCFeb = Convert.ToDouble(facturadoFeb.Text);
            }


            if (facturadoMar.Text == "")
            {
                facturadoMar.Text = "0";
            }
            else
            {
                cantCMar = Convert.ToDouble(facturadoMar.Text);
            }


            if (facturadoAbr.Text == "")
            {
                facturadoAbr.Text = "0";
            }
            else
            {
                cantCAbr = Convert.ToDouble(facturadoAbr.Text);
            }


            if (facturadoMay.Text == "")
            {
                facturadoMay.Text = "0";
            }
            else
            {
                cantCMay = Convert.ToDouble(facturadoMay.Text);
            }


            if (facturadoJun.Text == "")
            {
                facturadoJun.Text = "0";
            }
            else
            {
                cantCJun = Convert.ToDouble(facturadoJun.Text);
            }


            if (facturadoJul.Text == "")
            {
                facturadoJul.Text = "0";
            }
            else
            {
                cantCJul = Convert.ToDouble(facturadoJul.Text);
            }


            if (facturadoAgo.Text == "")
            {
                facturadoAgo.Text = "0";
            }
            else
            {
                cantCAgo = Convert.ToDouble(facturadoAgo.Text);
            }


            if (facturadoSep.Text == "")
            {
                facturadoSep.Text = "0";
            }
            else
            {
                cantCSep = Convert.ToDouble(facturadoSep.Text);
            }


            if (facturadoOct.Text == "")
            {
                facturadoOct.Text = "0";
            }
            else
            {
                cantCOct = Convert.ToDouble(facturadoOct.Text);
            }


            if (facturadoNov.Text == "")
            {
                facturadoNov.Text = "0";
            }
            else
            {
                cantCNov = Convert.ToDouble(facturadoNov.Text);
            }

            if (facturadoDic.Text == "")
            {
                facturadoDic.Text = "0";
            }
            else
            {
                cantCDic = Convert.ToDouble(facturadoDic.Text);
            }


            suma_facturado = cantCEne + cantCFeb + cantCMar + cantCAbr + cantCMay + cantCJun + cantCJul + cantCAgo + cantCSep + cantCOct + cantCNov + cantCDic;

            double porcentaje_facturado = (suma_facturado / montoPauta) * 100;

            cantFacturado.Text = Convert.ToString("$" + suma_facturado);
            porcentajeFacturado.Text = Convert.ToString(Math.Round(porcentaje_facturado, 2) + "%");


            //Cobrado
            double suma_cobrado;
            double cantCobEne = 0; double cantCobFeb = 0; double cantCobMar = 0; double cantCobAbr = 0; double cantCobMay = 0; double cantCobJun = 0;
            double cantCobJul = 0; double cantCobAgo = 0; double cantCobSep = 0; double cantCobOct = 0; double cantCobNov = 0; double cantCobDic = 0;

            if (cobradoEne.Text == "")
            {
                cobradoEne.Text = "0";
            }
            else
            {
                cantCobEne = Convert.ToDouble(cobradoEne.Text);
            }


            if (cobradoFeb.Text == "")
            {
                cobradoFeb.Text = "0";
            }
            else
            {
                cantCobFeb = Convert.ToDouble(cobradoFeb.Text);
            }


            if (cobradoMar.Text == "")
            {
                cobradoMar.Text = "0";
            }
            else
            {
                cantCobMar = Convert.ToDouble(cobradoMar.Text);
            }


            if (cobradoAbr.Text == "")
            {
                cobradoAbr.Text = "0";
            }
            else
            {
                cantCobAbr = Convert.ToDouble(cobradoAbr.Text);
            }


            if (cobradoMay.Text == "")
            {
                cobradoMay.Text = "0";
            }
            else
            {
                cantCobMay = Convert.ToDouble(cobradoMay.Text);
            }


            if (cobradoJun.Text == "")
            {
                cobradoJun.Text = "0";
            }
            else
            {
                cantCobJun = Convert.ToDouble(cobradoJun.Text);
            }


            if (cobradoJul.Text == "")
            {
                cobradoJul.Text = "0";
            }
            else
            {
                cantCobJul = Convert.ToDouble(cobradoJul.Text);
            }


            if (cobradoAgo.Text == "")
            {
                cobradoAgo.Text = "0";
            }
            else
            {
                cantCobAgo = Convert.ToDouble(cobradoAgo.Text);
            }


            if (cobradoSep.Text == "")
            {
                cobradoSep.Text = "0";
            }
            else
            {
                cantCobSep = Convert.ToDouble(cobradoSep.Text);
            }


            if (cobradoOct.Text == "")
            {
                cobradoOct.Text = "0";
            }
            else
            {
                cantCobOct = Convert.ToDouble(cobradoOct.Text);
            }


            if (cobradoNov.Text == "")
            {
                cobradoNov.Text = "0";
            }
            else
            {
                cantCobNov = Convert.ToDouble(cobradoNov.Text);
            }

            if (cobradoDic.Text == "")
            {
                cobradoDic.Text = "0";
            }
            else
            {
                cantCobDic = Convert.ToDouble(cobradoDic.Text);
            }


            suma_cobrado = cantCobEne + cantCobFeb + cantCobMar + cantCobAbr + cantCobMay + cantCobJun + cantCobJul + cantCobAgo + cantCobSep + cantCobOct + cantCobNov + cantCobDic;

            double porcentaje_cobrado = (suma_cobrado / montoPauta) * 100;

            cantCobrado.Text = Convert.ToString("$" + suma_cobrado);
            porcentajeCobrado.Text = Convert.ToString(Math.Round(porcentaje_cobrado, 2) + "%");
        }

        private void Calculo_Click(object sender, EventArgs e)
        {
            try
            {
                int cantMeses = 0;

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
                    double montoPauta = 0;
                    double totalPauta = 0;
                    double redondeado = 0;
                    double total = 0;

                    if (comboNacional.SelectedIndex == 0)
                    {
                        montoPauta = Convert.ToDouble(tMontoIVA.Text);
                    }
                    else if (comboNacional.SelectedIndex == 1)
                    {
                        montoPauta = Convert.ToDouble(tMonto.Text);
                    }

                    totalPauta = montoPauta / cantMeses;
                    redondeado = Math.Round(totalPauta, 2);
                    total = redondeado;

                    if (cEnero.Checked == true)
                    {
                        montoEne.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoEne.Text = "0";
                    }

                    if (cFebrero.Checked == true)
                    {
                        montoFeb.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoFeb.Text = "0";
                    }

                    if (cMarzo.Checked == true)
                    {
                        montoMar.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoMar.Text = "0";
                    }

                    if (cAbril.Checked == true)
                    {
                        montoAbr.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoAbr.Text = "0";
                    }

                    if (cMayo.Checked == true)
                    {
                        montoMayo.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoMayo.Text = "0";
                    }

                    if (cJunio.Checked == true)
                    {
                        montoJun.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoJun.Text = "0";
                    }

                    if (cJulio.Checked == true)
                    {
                        montoJul.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoJul.Text = "0";
                    }

                    if (cAgosto.Checked == true)
                    {
                        montoAgo.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoAgo.Text = "0";
                    }

                    if (cSeptiembre.Checked == true)
                    {
                        montoSep.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoSep.Text = "0";
                    }

                    if (cOctubre.Checked == true)
                    {
                        montoOct.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoOct.Text = "0";
                    }

                    if (cNoviembre.Checked == true)
                    {
                        montoNov.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoNov.Text = "0";
                    }

                    if (cDiciembre.Checked == true)
                    {
                        montoDic.Text = Convert.ToString(total);
                    }
                    else
                    {
                        montoDic.Text = "0";
                    }

                    //montos
                    double suma_monto_oi = Convert.ToDouble(montoEne.Text) + Convert.ToDouble(montoFeb.Text) + Convert.ToDouble(montoMar.Text) + Convert.ToDouble(montoAbr.Text) + Convert.ToDouble(montoMayo.Text) + Convert.ToDouble(montoJun.Text) + Convert.ToDouble(montoJul.Text) + Convert.ToDouble(montoAgo.Text) + Convert.ToDouble(montoSep.Text) + Convert.ToDouble(montoOct.Text) + Convert.ToDouble(montoNov.Text) + Convert.ToDouble(montoDic.Text);

                    double porcentaje_suma_monto_oi = (suma_monto_oi / montoPauta) * 100;

                    //String.Format("{0:C}", suma_monto_oi);

                    cantMonto.Text = Convert.ToString(String.Format("{0:C}", suma_monto_oi));

                    porcentajeMonto.Text = Convert.ToString(Math.Round(porcentaje_suma_monto_oi, 2) + "%");
                    //redondeado = Math.Round(totalPauta, 2);
                }
            }
            catch (Exception m)
            {
                //MessageBox.Show("Error, verifique campos!" + " " + m, "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ListaSaldos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int n = listaSaldos.SelectedRows[0].Index;
                id.Text = listaSaldos.Rows[n].Cells[0].Value.ToString();
                dateIngreso.Text = listaSaldos.Rows[n].Cells[1].Value.ToString();
                tMedia.Text = listaSaldos.Rows[n].Cells[2].Value.ToString();
                textStatusOI.Text = listaSaldos.Rows[n].Cells[3].Value.ToString();
                textPais.Text = listaSaldos.Rows[n].Cells[4].Value.ToString();
                labelPauta.Text = listaSaldos.Rows[n].Cells[5].Value.ToString();
                comboCategoria.Text = listaSaldos.Rows[n].Cells[6].Value.ToString();
                comboContrato.Text = listaSaldos.Rows[n].Cells[7].Value.ToString();
                comboRazon.Text = listaSaldos.Rows[n].Cells[8].Value.ToString();
                textComercial.Text = listaSaldos.Rows[n].Cells[9].Value.ToString();
                labelHotel.Text = listaSaldos.Rows[n].Cells[10].Value.ToString();
                tSiglas.Text = listaSaldos.Rows[n].Cells[11].Value.ToString();
                tHann.Text = listaSaldos.Rows[n].Cells[12].Value.ToString();
                nombreBeneficio.Text = listaSaldos.Rows[n].Cells[13].Value.ToString();
                textMonto.Text = listaSaldos.Rows[n].Cells[14].Value.ToString();
                textAnticipo.Text = listaSaldos.Rows[n].Cells[15].Value.ToString();
                comboPorcentajeMKF.Text = listaSaldos.Rows[n].Cells[16].Value.ToString();
                dateDesdeMKF.Text = listaSaldos.Rows[n].Cells[17].Value.ToString();
                dateHastaMKF.Text = listaSaldos.Rows[n].Cells[18].Value.ToString();

                string formaPago = listaSaldos.Rows[n].Cells[19].Value.ToString();
                if (formaPago == "Producción")
                {
                    checkProduccion.Checked = true;
                }
                else
                {
                    checkProduccion.Checked = false;
                }

                if (formaPago == "Pagos Emitidos")
                {
                    checkEmitidos.Checked = true;
                }
                else
                {
                    checkEmitidos.Checked = false;
                }

                tMonto.Text = listaSaldos.Rows[n].Cells[20].Value.ToString();
                tMontoIVA.Text = listaSaldos.Rows[n].Cells[21].Value.ToString();
                comboDivisa.Text = listaSaldos.Rows[n].Cells[22].Value.ToString();
                dateDesdeMonto.Text = listaSaldos.Rows[n].Cells[23].Value.ToString();
                dateHastaMonto.Text = listaSaldos.Rows[n].Cells[24].Value.ToString();

                string tranferencia = listaSaldos.Rows[n].Cells[25].Value.ToString();
                if (tranferencia == "Si")
                {
                    checkTransferencia.Checked = true;
                }
                else
                {
                    checkTransferencia.Checked = false;
                }

                string compensacion = listaSaldos.Rows[n].Cells[26].Value.ToString();
                if (compensacion == "Si")
                {
                    checkBCompensacion.Checked = true;
                }
                else
                {
                    checkBCompensacion.Checked = false;
                }

                string noches = listaSaldos.Rows[n].Cells[27].Value.ToString();
                if (noches == "Si")
                {
                    checkNoches.Checked = true;
                }
                else
                {
                    checkNoches.Checked = false;
                }

                string ambas = listaSaldos.Rows[n].Cells[28].Value.ToString();
                if (ambas == "Si")
                {
                    checkAmbos.Checked = true;
                }
                else
                {
                    checkAmbos.Checked = false;
                }

                comboComisiones.Text = listaSaldos.Rows[n].Cells[29].Value.ToString();
                textObservaciones.Text = listaSaldos.Rows[n].Cells[30].Value.ToString();
                comboSupply.Text = listaSaldos.Rows[n].Cells[31].Value.ToString();
                comboEjecutivoDAF.Text = listaSaldos.Rows[n].Cells[32].Value.ToString();
                comboAccount.Text = listaSaldos.Rows[n].Cells[33].Value.ToString();
                nombreUno.Text = listaSaldos.Rows[n].Cells[34].Value.ToString();
                string enero = listaSaldos.Rows[n].Cells[35].Value.ToString();
                if (enero == "SI")
                {
                    cEnero.Checked = true;
                }
                else
                {
                    cEnero.Checked = false;
                }
                string febrero = listaSaldos.Rows[n].Cells[36].Value.ToString();
                if (febrero == "SI")
                {
                    cFebrero.Checked = true;
                }
                else
                {
                    cFebrero.Checked = false;
                }
                string marzo = listaSaldos.Rows[n].Cells[37].Value.ToString();
                if (marzo == "SI")
                {
                    cMarzo.Checked = true;
                }
                else
                {
                    cMarzo.Checked = false;
                }
                string abril = listaSaldos.Rows[n].Cells[38].Value.ToString();
                if (abril == "SI")
                {
                    cAbril.Checked = true;
                }
                else
                {
                    cAbril.Checked = false;
                }
                string mayo = listaSaldos.Rows[n].Cells[39].Value.ToString();
                if (mayo == "SI")
                {
                    cMayo.Checked = true;
                }
                else
                {
                    cMayo.Checked = false;
                }
                string junio = listaSaldos.Rows[n].Cells[40].Value.ToString();
                if (junio == "SI")
                {
                    cJunio.Checked = true;
                }
                else
                {
                    cJunio.Checked = false;
                }
                string julio = listaSaldos.Rows[n].Cells[41].Value.ToString();
                if (julio == "SI")
                {
                    cJulio.Checked = true;
                }
                else
                {
                    cJulio.Checked = false;
                }
                string agosto = listaSaldos.Rows[n].Cells[42].Value.ToString();
                if (agosto == "SI")
                {
                    cAgosto.Checked = true;
                }
                else
                {
                    cAgosto.Checked = false;
                }
                string septiembre = listaSaldos.Rows[n].Cells[43].Value.ToString();
                if (septiembre == "SI")
                {
                    cSeptiembre.Checked = true;
                }
                else
                {
                    cSeptiembre.Checked = false;
                }
                string octubre = listaSaldos.Rows[n].Cells[44].Value.ToString();
                if (octubre == "SI")
                {
                    cOctubre.Checked = true;
                }
                else
                {
                    cOctubre.Checked = false;
                }
                string noviembre = listaSaldos.Rows[n].Cells[45].Value.ToString();
                if (noviembre == "SI")
                {
                    cNoviembre.Checked = true;
                }
                else
                {
                    cNoviembre.Checked = false;
                }
                string diciembre = listaSaldos.Rows[n].Cells[46].Value.ToString();
                if (diciembre == "SI")
                {
                    cDiciembre.Checked = true;
                }
                else
                {
                    cDiciembre.Checked = false;
                }

                tEnero.Text = listaSaldos.Rows[n].Cells[47].Value.ToString();
                tFebrero.Text = listaSaldos.Rows[n].Cells[48].Value.ToString();
                tMarzo.Text = listaSaldos.Rows[n].Cells[49].Value.ToString();
                tAbril.Text = listaSaldos.Rows[n].Cells[50].Value.ToString();
                tMayo.Text = listaSaldos.Rows[n].Cells[51].Value.ToString();
                tJunio.Text = listaSaldos.Rows[n].Cells[52].Value.ToString();
                tJulio.Text = listaSaldos.Rows[n].Cells[53].Value.ToString();
                tAgosto.Text = listaSaldos.Rows[n].Cells[54].Value.ToString();
                tSeptiembre.Text = listaSaldos.Rows[n].Cells[55].Value.ToString();
                tOctubre.Text = listaSaldos.Rows[n].Cells[56].Value.ToString();
                tNoviembre.Text = listaSaldos.Rows[n].Cells[57].Value.ToString();
                tDiciembre.Text = listaSaldos.Rows[n].Cells[58].Value.ToString();
                montoEne.Text = listaSaldos.Rows[n].Cells[59].Value.ToString();
                montoFeb.Text = listaSaldos.Rows[n].Cells[60].Value.ToString();
                montoMar.Text = listaSaldos.Rows[n].Cells[61].Value.ToString();
                montoAbr.Text = listaSaldos.Rows[n].Cells[62].Value.ToString();
                montoMayo.Text = listaSaldos.Rows[n].Cells[63].Value.ToString();
                montoJun.Text = listaSaldos.Rows[n].Cells[64].Value.ToString();
                montoJul.Text = listaSaldos.Rows[n].Cells[65].Value.ToString();
                montoAgo.Text = listaSaldos.Rows[n].Cells[66].Value.ToString();
                montoSep.Text = listaSaldos.Rows[n].Cells[67].Value.ToString();
                montoOct.Text = listaSaldos.Rows[n].Cells[68].Value.ToString();
                montoNov.Text = listaSaldos.Rows[n].Cells[69].Value.ToString();
                montoDic.Text = listaSaldos.Rows[n].Cells[70].Value.ToString();
                facturadoEne.Text = listaSaldos.Rows[n].Cells[71].Value.ToString();
                facturadoFeb.Text = listaSaldos.Rows[n].Cells[72].Value.ToString();
                facturadoMar.Text = listaSaldos.Rows[n].Cells[73].Value.ToString();
                facturadoAbr.Text = listaSaldos.Rows[n].Cells[74].Value.ToString();
                facturadoMay.Text = listaSaldos.Rows[n].Cells[75].Value.ToString();
                facturadoJun.Text = listaSaldos.Rows[n].Cells[76].Value.ToString();
                facturadoJul.Text = listaSaldos.Rows[n].Cells[77].Value.ToString();
                facturadoAgo.Text = listaSaldos.Rows[n].Cells[78].Value.ToString();
                facturadoSep.Text = listaSaldos.Rows[n].Cells[79].Value.ToString();
                facturadoOct.Text = listaSaldos.Rows[n].Cells[80].Value.ToString();
                facturadoNov.Text = listaSaldos.Rows[n].Cells[81].Value.ToString();
                facturadoDic.Text = listaSaldos.Rows[n].Cells[82].Value.ToString();
                cobradoEne.Text = listaSaldos.Rows[n].Cells[83].Value.ToString();
                cobradoFeb.Text = listaSaldos.Rows[n].Cells[84].Value.ToString();
                cobradoMar.Text = listaSaldos.Rows[n].Cells[85].Value.ToString();
                cobradoAbr.Text = listaSaldos.Rows[n].Cells[86].Value.ToString();
                cobradoMay.Text = listaSaldos.Rows[n].Cells[87].Value.ToString();
                cobradoJun.Text = listaSaldos.Rows[n].Cells[88].Value.ToString();
                cobradoJul.Text = listaSaldos.Rows[n].Cells[89].Value.ToString();
                cobradoAgo.Text = listaSaldos.Rows[n].Cells[90].Value.ToString();
                cobradoSep.Text = listaSaldos.Rows[n].Cells[91].Value.ToString();
                cobradoOct.Text = listaSaldos.Rows[n].Cells[92].Value.ToString();
                cobradoNov.Text = listaSaldos.Rows[n].Cells[93].Value.ToString();
                cobradoDic.Text = listaSaldos.Rows[n].Cells[94].Value.ToString();
                dateEne.Text = listaSaldos.Rows[n].Cells[95].Value.ToString();
                dateFeb.Text = listaSaldos.Rows[n].Cells[96].Value.ToString();
                dateMar.Text = listaSaldos.Rows[n].Cells[97].Value.ToString();
                dateAbr.Text = listaSaldos.Rows[n].Cells[98].Value.ToString();
                dateMay.Text = listaSaldos.Rows[n].Cells[99].Value.ToString();
                dateJun.Text = listaSaldos.Rows[n].Cells[100].Value.ToString();
                dateJul.Text = listaSaldos.Rows[n].Cells[101].Value.ToString();
                dateAgo.Text = listaSaldos.Rows[n].Cells[102].Value.ToString();
                dateSep.Text = listaSaldos.Rows[n].Cells[103].Value.ToString();
                dateOct.Text = listaSaldos.Rows[n].Cells[104].Value.ToString();
                dateNov.Text = listaSaldos.Rows[n].Cells[105].Value.ToString();
                dateDic.Text = listaSaldos.Rows[n].Cells[106].Value.ToString();
                esquemaEne.Text = listaSaldos.Rows[n].Cells[107].Value.ToString();
                esquemaFeb.Text = listaSaldos.Rows[n].Cells[108].Value.ToString();
                esquemaMar.Text = listaSaldos.Rows[n].Cells[109].Value.ToString();
                esquemaAbr.Text = listaSaldos.Rows[n].Cells[110].Value.ToString();
                esquemaMay.Text = listaSaldos.Rows[n].Cells[111].Value.ToString();
                esquemaJun.Text = listaSaldos.Rows[n].Cells[112].Value.ToString();
                esquemaJul.Text = listaSaldos.Rows[n].Cells[113].Value.ToString();
                esquemaAgo.Text = listaSaldos.Rows[n].Cells[114].Value.ToString();
                esquemaSep.Text = listaSaldos.Rows[n].Cells[115].Value.ToString();
                esquemaOct.Text = listaSaldos.Rows[n].Cells[116].Value.ToString();
                esquemaNov.Text = listaSaldos.Rows[n].Cells[117].Value.ToString();
                esquemaDic.Text = listaSaldos.Rows[n].Cells[118].Value.ToString();
                esquemaDateEne.Text = listaSaldos.Rows[n].Cells[119].Value.ToString();
                esquemaDateFeb.Text = listaSaldos.Rows[n].Cells[120].Value.ToString();
                esquemaDateMar.Text = listaSaldos.Rows[n].Cells[121].Value.ToString();
                esquemaDateAbr.Text = listaSaldos.Rows[n].Cells[122].Value.ToString();
                esquemaDateMay.Text = listaSaldos.Rows[n].Cells[123].Value.ToString();
                esquemaDateJun.Text = listaSaldos.Rows[n].Cells[124].Value.ToString();
                esquemaDateJul.Text = listaSaldos.Rows[n].Cells[125].Value.ToString();
                esquemaDateAgo.Text = listaSaldos.Rows[n].Cells[126].Value.ToString();
                esquemaDateSep.Text = listaSaldos.Rows[n].Cells[127].Value.ToString();
                esquemaDateOct.Text = listaSaldos.Rows[n].Cells[128].Value.ToString();
                esquemaDateNov.Text = listaSaldos.Rows[n].Cells[129].Value.ToString();
                esquemaDateDic.Text = listaSaldos.Rows[n].Cells[130].Value.ToString();
                cantMonto.Text = listaSaldos.Rows[n].Cells[131].Value.ToString();
                cantCobrado.Text = listaSaldos.Rows[n].Cells[132].Value.ToString();
                cantFacturado.Text = listaSaldos.Rows[n].Cells[133].Value.ToString();
                porcentajeMonto.Text = listaSaldos.Rows[n].Cells[134].Value.ToString();
                porcentajeCobrado.Text = listaSaldos.Rows[n].Cells[135].Value.ToString();
                porcentajeFacturado.Text = listaSaldos.Rows[n].Cells[136].Value.ToString();

                try
                {
                    con.Close();

                    con.Open();
                    string sql = "SELECT campo1, campo2, campo3, archivo_dos, archivo_tres, cant_noches, importe_noches, enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre, q, porcentaje_q, tipo_op, id_maestro_op, numero_cuenta_op, cuenta_op, razon_op, doc_ene, doc_feb, doc_mar, doc_abr, doc_may, doc_jun, doc_jul, doc_ago, doc_sep, doc_oct, doc_nov, doc_dic ,archivo_ene , archivo_feb, archivo_mar, archivo_abr , archivo_may , archivo_jun , archivo_jul  , archivo_ago , archivo_sep , archivo_oct , `archivo_nov` , archivo_dic FROM ordenes_insercion WHERE id_ordenes ='" + id.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        t_campo1 = Convert.ToString(reader["campo1"]);
                        t_campo2 = Convert.ToString(reader["campo2"]);
                        t_campo3 = Convert.ToString(reader["campo3"]);
                        //archivos
                        string archivo_dos_q = Convert.ToString(reader["archivo_dos"]);
                        nombreDos.Text = archivo_dos_q;
                        string archivo_tres_q = Convert.ToString(reader["archivo_tres"]);
                        nombreTres.Text = archivo_tres_q;

                        //documentos facturas
                        textDocEne.Text = Convert.ToString(reader["doc_ene"]);
                        textDocFeb.Text = Convert.ToString(reader["doc_feb"]);
                        textDocMar.Text = Convert.ToString(reader["doc_mar"]);
                        textDocAbr.Text = Convert.ToString(reader["doc_abr"]);
                        textDocMay.Text = Convert.ToString(reader["doc_may"]);
                        textDocJun.Text = Convert.ToString(reader["doc_jun"]);
                        textDocJul.Text = Convert.ToString(reader["doc_jul"]);
                        textDocAgo.Text = Convert.ToString(reader["doc_ago"]);
                        textDocSep.Text = Convert.ToString(reader["doc_sep"]);
                        textDocOct.Text = Convert.ToString(reader["doc_oct"]);
                        textDocNov.Text = Convert.ToString(reader["doc_nov"]);
                        textDocDic.Text = Convert.ToString(reader["doc_dic"]);

                        //archivos facturas
                        NombreArcEne = Convert.ToString(reader["archivo_ene"]);
                        archivoEne.Text = NombreArcEne;

                        NombreArcFeb = Convert.ToString(reader["archivo_feb"]);
                        archivoFeb.Text = NombreArcFeb;

                        NombreArcMar = Convert.ToString(reader["archivo_mar"]);
                        archivoMar.Text = NombreArcMar;

                        NombreArcAbr = Convert.ToString(reader["archivo_abr"]);
                        archivoAbr.Text = NombreArcAbr;

                        NombreArcMay = Convert.ToString(reader["archivo_may"]);
                        archivoMay.Text = NombreArcMay;

                        NombreArcJun = Convert.ToString(reader["archivo_jun"]);
                        archivoJun.Text = NombreArcJun;

                        NombreArcJul = Convert.ToString(reader["archivo_jul"]);
                        archivoJul.Text = NombreArcJul;

                        NombreArcAgo = Convert.ToString(reader["archivo_ago"]);
                        archivoAgo.Text = NombreArcAgo;

                        NombreArcSep = Convert.ToString(reader["archivo_sep"]);
                        archivoSep.Text = NombreArcSep;

                        NombreArcOct = Convert.ToString(reader["archivo_oct"]);
                        archivoOct.Text = NombreArcOct;

                        NombreArcNov = Convert.ToString(reader["archivo_nov"]);
                        archivoNov.Text = NombreArcNov;

                        NombreArcDic = Convert.ToString(reader["archivo_dic"]);
                        archivoDic.Text = NombreArcDic;

                        //datos RO&AND
                        string tipo_op_q = Convert.ToString(reader["tipo_op"]);
                        comboOp.Text = tipo_op_q;
                        string id_maestro_op_q = Convert.ToString(reader["id_maestro_op"]);
                        textID.Text = id_maestro_op_q;
                        string numero_cuenta_op_q = Convert.ToString(reader["numero_cuenta_op"]);
                        comboCuenta.Text = numero_cuenta_op_q;
                        string cuenta_op_q = Convert.ToString(reader["cuenta_op"]);
                        comboCuentaOp.Text = cuenta_op_q;
                        string razon_op_q = Convert.ToString(reader["razon_op"]);
                        comboRazonOp.Text = razon_op_q;
                        //meses
                        senero = Convert.ToString(reader["enero"]);
                        sfebrero = Convert.ToString(reader["febrero"]);
                        smarzo = Convert.ToString(reader["marzo"]);
                        sabril = Convert.ToString(reader["abril"]);
                        smayo = Convert.ToString(reader["mayo"]);
                        sjunio = Convert.ToString(reader["junio"]);
                        sjulio = Convert.ToString(reader["julio"]);
                        sagosto = Convert.ToString(reader["agosto"]);
                        sseptiembre = Convert.ToString(reader["septiembre"]);
                        soctubre = Convert.ToString(reader["octubre"]);
                        snoviembre = Convert.ToString(reader["noviembre"]);
                        sdiciembre = Convert.ToString(reader["diciembre"]);
                        //Q
                        string q_dato = Convert.ToString(reader["q"]);
                        comboQ.Text = q_dato;

                        string q_porcentaje_dato = Convert.ToString(reader["porcentaje_q"]);
                        comboQPorcentaje.Text = q_porcentaje_dato;
                        //noches
                        string cant_noches_t = Convert.ToString(reader["cant_noches"]);
                        cantNoches.Text = cant_noches_t;
                        string importe_noches = Convert.ToString(reader["importe_noches"]);
                        importeNoches.Text = importe_noches;
                        //if (comboComisiones.Text == "MEDIA" && clave_pais == "MX" || comboComisiones.Text == "Marketing Found" && clave_pais == "MX")
                        //{
                        //    comboQ.Visible = true;
                        //    label41.Visible = true;
                        //    comboQPorcentaje.Visible = false;
                        //    label42.Visible = false;
                        //}
                        //else
                        //{
                        //    comboQPorcentaje.Visible = true;
                        //    label42.Visible = true;

                        //    comboQ.Visible = false;
                        //    label41.Visible = false;
                        //}
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
                        //nacional = Convert.ToString(reader["nacional"]);
                        //comboNacional.Text = nacional;
                    }

                    con.Close();

                    tabControl.SelectedIndex = 0;
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

        public void llenar()
        {
            try
            {
                con.Close();

                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from ordenes_insercion", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = listaSaldos.Rows.Add();
                    listaSaldos.Rows[n].Cells[0].Value = item["id_ordenes"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["fecha_ingreso"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["folio_media"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["status_OI"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["sigla_pais"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["tipo_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["categoria"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["contrato"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["sigla_hotel"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["sigla_hanna"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["clave_hanna"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["centro_bneficio"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["anticipo_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["porcentaje_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["vig_desde_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["vig_hasta_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["forma_calculo"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["monto_fijo"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["monto_fijo_iva"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["vig_monto_desde"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["vig_monto_hasta"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["transf_bancaria"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["compensacion"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["noches"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["ambas"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["esquema_comision"].ToString();
                    listaSaldos.Rows[n].Cells[30].Value = item["observaciones"].ToString();
                    listaSaldos.Rows[n].Cells[31].Value = item["supply_manager"].ToString();
                    listaSaldos.Rows[n].Cells[32].Value = item["ejecutivo_daf"].ToString();
                    listaSaldos.Rows[n].Cells[33].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[34].Value = item["archivo"].ToString();
                    listaSaldos.Rows[n].Cells[35].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[36].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[37].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[38].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[39].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[40].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[41].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[42].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[43].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[44].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[45].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[46].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[47].Value = item["anio_ene"].ToString();
                    listaSaldos.Rows[n].Cells[48].Value = item["anio_feb"].ToString();
                    listaSaldos.Rows[n].Cells[49].Value = item["anio_mar"].ToString();
                    listaSaldos.Rows[n].Cells[50].Value = item["anio_abr"].ToString();
                    listaSaldos.Rows[n].Cells[51].Value = item["anio_may"].ToString();
                    listaSaldos.Rows[n].Cells[52].Value = item["anio_jun"].ToString();
                    listaSaldos.Rows[n].Cells[53].Value = item["anio_jul"].ToString();
                    listaSaldos.Rows[n].Cells[54].Value = item["anio_ago"].ToString();
                    listaSaldos.Rows[n].Cells[55].Value = item["anio_sep"].ToString();
                    listaSaldos.Rows[n].Cells[56].Value = item["anio_oct"].ToString();
                    listaSaldos.Rows[n].Cells[57].Value = item["anio_nov"].ToString();
                    listaSaldos.Rows[n].Cells[58].Value = item["anio_dic"].ToString();
                    listaSaldos.Rows[n].Cells[59].Value = item["monto_ene"].ToString();
                    listaSaldos.Rows[n].Cells[60].Value = item["monto_feb"].ToString();
                    listaSaldos.Rows[n].Cells[61].Value = item["monto_mar"].ToString();
                    listaSaldos.Rows[n].Cells[62].Value = item["monto_abr"].ToString();
                    listaSaldos.Rows[n].Cells[63].Value = item["monto_may"].ToString();
                    listaSaldos.Rows[n].Cells[64].Value = item["monto_jun"].ToString();
                    listaSaldos.Rows[n].Cells[65].Value = item["monto_jul"].ToString();
                    listaSaldos.Rows[n].Cells[66].Value = item["monto_ago"].ToString();
                    listaSaldos.Rows[n].Cells[67].Value = item["monto_sep"].ToString();
                    listaSaldos.Rows[n].Cells[68].Value = item["monto_oct"].ToString();
                    listaSaldos.Rows[n].Cells[69].Value = item["monto_nov"].ToString();
                    listaSaldos.Rows[n].Cells[70].Value = item["monto_dic"].ToString();
                    listaSaldos.Rows[n].Cells[71].Value = item["facturado_ene"].ToString();
                    listaSaldos.Rows[n].Cells[72].Value = item["facturado_feb"].ToString();
                    listaSaldos.Rows[n].Cells[73].Value = item["facturado_mar"].ToString();
                    listaSaldos.Rows[n].Cells[74].Value = item["facturado_abr"].ToString();
                    listaSaldos.Rows[n].Cells[75].Value = item["facturado_may"].ToString();
                    listaSaldos.Rows[n].Cells[76].Value = item["facturado_jun"].ToString();
                    listaSaldos.Rows[n].Cells[77].Value = item["facturado_jul"].ToString();
                    listaSaldos.Rows[n].Cells[78].Value = item["facturado_ago"].ToString();
                    listaSaldos.Rows[n].Cells[79].Value = item["facturado_sep"].ToString();
                    listaSaldos.Rows[n].Cells[80].Value = item["facturado_oct"].ToString();
                    listaSaldos.Rows[n].Cells[81].Value = item["facturado_nov"].ToString();
                    listaSaldos.Rows[n].Cells[82].Value = item["facturado_dic"].ToString();
                    listaSaldos.Rows[n].Cells[83].Value = item["cobrado_ene"].ToString();
                    listaSaldos.Rows[n].Cells[84].Value = item["cobrado_feb"].ToString();
                    listaSaldos.Rows[n].Cells[85].Value = item["cobrado_mar"].ToString();
                    listaSaldos.Rows[n].Cells[86].Value = item["cobrado_abr"].ToString();
                    listaSaldos.Rows[n].Cells[87].Value = item["cobrado_may"].ToString();
                    listaSaldos.Rows[n].Cells[88].Value = item["cobrado_jun"].ToString();
                    listaSaldos.Rows[n].Cells[89].Value = item["cobrado_jul"].ToString();
                    listaSaldos.Rows[n].Cells[90].Value = item["cobrado_ago"].ToString();
                    listaSaldos.Rows[n].Cells[91].Value = item["cobrado_sep"].ToString();
                    listaSaldos.Rows[n].Cells[92].Value = item["cobrado_oct"].ToString();
                    listaSaldos.Rows[n].Cells[93].Value = item["cobrado_nov"].ToString();
                    listaSaldos.Rows[n].Cells[94].Value = item["cobrado_dic"].ToString();
                    listaSaldos.Rows[n].Cells[95].Value = item["fecha_cobro_ene"].ToString();
                    listaSaldos.Rows[n].Cells[96].Value = item["fecha_cobro_feb"].ToString();
                    listaSaldos.Rows[n].Cells[97].Value = item["fecha_cobro_mar"].ToString();
                    listaSaldos.Rows[n].Cells[98].Value = item["fecha_cobro_abr"].ToString();
                    listaSaldos.Rows[n].Cells[99].Value = item["fecha_cobro_may"].ToString();
                    listaSaldos.Rows[n].Cells[100].Value = item["fecha_cobro_jun"].ToString();
                    listaSaldos.Rows[n].Cells[101].Value = item["fecha_cobro_jul"].ToString();
                    listaSaldos.Rows[n].Cells[102].Value = item["fecha_cobro_ago"].ToString();
                    listaSaldos.Rows[n].Cells[103].Value = item["fecha_cobro_sep"].ToString();
                    listaSaldos.Rows[n].Cells[104].Value = item["fecha_cobro_oct"].ToString();
                    listaSaldos.Rows[n].Cells[105].Value = item["fecha_cobro_nov"].ToString();
                    listaSaldos.Rows[n].Cells[106].Value = item["fecha_cobro_dic"].ToString();
                    listaSaldos.Rows[n].Cells[107].Value = item["esquema_ene"].ToString();
                    listaSaldos.Rows[n].Cells[108].Value = item["esquema_feb"].ToString();
                    listaSaldos.Rows[n].Cells[109].Value = item["esquema_mar"].ToString();
                    listaSaldos.Rows[n].Cells[110].Value = item["esquema_abr"].ToString();
                    listaSaldos.Rows[n].Cells[111].Value = item["esquema_may"].ToString();
                    listaSaldos.Rows[n].Cells[112].Value = item["esquema_jun"].ToString();
                    listaSaldos.Rows[n].Cells[113].Value = item["esquema_jul"].ToString();
                    listaSaldos.Rows[n].Cells[114].Value = item["esquema_ago"].ToString();
                    listaSaldos.Rows[n].Cells[115].Value = item["esquema_sep"].ToString();
                    listaSaldos.Rows[n].Cells[116].Value = item["esquema_oct"].ToString();
                    listaSaldos.Rows[n].Cells[117].Value = item["esquema_nov"].ToString();
                    listaSaldos.Rows[n].Cells[118].Value = item["esquema_dic"].ToString();
                    listaSaldos.Rows[n].Cells[119].Value = item["fecha_com_ene"].ToString();
                    listaSaldos.Rows[n].Cells[120].Value = item["fecha_com_feb"].ToString();
                    listaSaldos.Rows[n].Cells[121].Value = item["fecha_com_mar"].ToString();
                    listaSaldos.Rows[n].Cells[122].Value = item["fecha_com_abr"].ToString();
                    listaSaldos.Rows[n].Cells[123].Value = item["fecha_com_may"].ToString();
                    listaSaldos.Rows[n].Cells[124].Value = item["fecha_com_jun"].ToString();
                    listaSaldos.Rows[n].Cells[125].Value = item["fecha_com_jul"].ToString();
                    listaSaldos.Rows[n].Cells[126].Value = item["fecha_com_ago"].ToString();
                    listaSaldos.Rows[n].Cells[127].Value = item["fecha_com_sep"].ToString();
                    listaSaldos.Rows[n].Cells[128].Value = item["fecha_com_oct"].ToString();
                    listaSaldos.Rows[n].Cells[129].Value = item["fecha_com_nov"].ToString();
                    listaSaldos.Rows[n].Cells[130].Value = item["fecha_com_dic"].ToString();
                    listaSaldos.Rows[n].Cells[131].Value = item["monto_pautado"].ToString();
                    listaSaldos.Rows[n].Cells[132].Value = item["monto_facturado"].ToString();
                    listaSaldos.Rows[n].Cells[133].Value = item["monto_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[134].Value = item["porcentaje_pautado"].ToString();
                    listaSaldos.Rows[n].Cells[135].Value = item["porcentaje_facturado"].ToString();
                    listaSaldos.Rows[n].Cells[136].Value = item["porcentaje_cobrado"].ToString();

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
            total.Text = "";
            id.Text = "";
            totalMeses.Text = "";
            textAnticipo.Text = "";
            tMedia.Text = "";
            tMontoIVA.Text = "";
            tMonto.Text = "";
            textObservaciones.Text = "";
            linkIUno.Text = "";
            nombreUno.Text = "";
            cant1.Text = "";
            cant2.Text = "";
            textID.Text = "";
            cantNoches.Text = "";
            importeNoches.Text = "";
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
            montoEne.Text = "";
            montoFeb.Text = "";
            montoMar.Text = "";
            montoAbr.Text = "";
            montoMayo.Text = "";
            montoJun.Text = "";
            montoJul.Text = "";
            montoAgo.Text = "";
            montoSep.Text = "";
            montoOct.Text = "";
            montoNov.Text = "";
            montoDic.Text = "";
            facturadoEne.Text = "";
            facturadoFeb.Text = "";
            facturadoMar.Text = "";
            facturadoAbr.Text = "";
            facturadoMay.Text = "";
            facturadoJun.Text = "";
            facturadoJul.Text = "";
            facturadoAgo.Text = "";
            facturadoSep.Text = "";
            facturadoOct.Text = "";
            facturadoNov.Text = "";
            facturadoDic.Text = "";
            cobradoEne.Text = "";
            cobradoFeb.Text = "";
            cobradoMar.Text = "";
            cobradoAbr.Text = "";
            cobradoMay.Text = "";
            cobradoJun.Text = "";
            cobradoJul.Text = "";
            cobradoAgo.Text = "";
            cobradoSep.Text = "";
            cobradoOct.Text = "";
            cobradoNov.Text = "";
            cobradoDic.Text = "";
            esquemaEne.Text = "";
            esquemaFeb.Text = "";
            esquemaMar.Text = "";
            esquemaAbr.Text = "";
            esquemaMay.Text = "";
            esquemaJun.Text = "";
            esquemaJul.Text = "";
            esquemaAgo.Text = "";
            esquemaSep.Text = "";
            esquemaOct.Text = "";
            esquemaNov.Text = "";
            esquemaDic.Text = "";
            cantMonto.Text = "";
            cantFacturado.Text = "";
            cantCobrado.Text = "";
            porcentajeCobrado.Text = "";
            porcentajeFacturado.Text = "";
            porcentajeMonto.Text = "";
            checkProduccion.Checked = false;
            checkEmitidos.Checked = false;
            checkTransferencia.Checked = false;
            checkNoches.Checked = false;
            checkBCompensacion.Checked = false;
            checkAmbos.Checked = false;
            cEnero.Checked = false;
            cFebrero.Checked = false;
            cMarzo.Checked = false;
            cAbril.Checked = false;
            cMayo.Checked = false;
            cJunio.Checked = false;
            cJulio.Checked = false;
            cAgosto.Checked = false;
            cSeptiembre.Checked = false;
            cOctubre.Checked = false;
            cNoviembre.Checked = false;
            cDiciembre.Checked = false;
            //seleccion combos 
            comboCategoria.SelectedIndex = 0;
            comboPorcentajeMKF.SelectedIndex = 0;
            comboDivisa.SelectedIndex = 0;
            comboNacional.SelectedIndex = 0;
            comboOp.SelectedIndex = 0;
            comboCuenta.SelectedIndex = 0;
            comboCuentaOp.SelectedIndex = 0;
            comboRazonOp.SelectedIndex = 0;
            comboComisiones.SelectedIndex = 0;
            comboQ.SelectedIndex = 0;
            comboQPorcentaje.SelectedIndex = 0;
        }

        public void generaFolio()
        {
            try
            {
                con.Close();

                con.Open();
                string sql = "SELECT id_ordenes FROM ordenes_insercion ORDER BY id_ordenes DESC LIMIT 1";
                //string sql = "SELECT id_saldos FROM saldos_media ORDER BY id_saldos DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    last_id = Convert.ToInt32(reader["id_ordenes"]);
                    //MessageBox.Show(Convert.ToString(last_id));
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }

            //DateTime todaysDate = DateTime.Now;
            int year = dateIngreso.Value.Year;
            int month = dateIngreso.Value.Month;
            int day = dateIngreso.Value.Day;
            int consec = last_id + 1;

            clv_media = Convert.ToString(year) + "-" + Convert.ToString(month) + "-" + consec + "-" + labelPauta.Text + "-" + comboCategoria.Text + "-" + labelHotel.Text + "-" + textPais.Text;

            tMedia.Text = clv_media;
        }

        public void calcula_sumas()
        {
            int cantMeses = 0;
            double montoPauta = 0;

            if (comboNacional.SelectedIndex == 0)
            {
                montoPauta = Convert.ToDouble(tMontoIVA.Text);
            }
            else if (comboNacional.SelectedIndex == 1)
            {
                montoPauta = Convert.ToDouble(tMonto.Text);
            }

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
                //montos
                double suma_monto_oi = Convert.ToDouble(montoEne.Text) + Convert.ToDouble(montoFeb.Text) + Convert.ToDouble(montoMar.Text) + Convert.ToDouble(montoAbr.Text) + Convert.ToDouble(montoMayo.Text) + Convert.ToDouble(montoJun.Text) + Convert.ToDouble(montoJul.Text) + Convert.ToDouble(montoAgo.Text) + Convert.ToDouble(montoSep.Text) + Convert.ToDouble(montoOct.Text) + Convert.ToDouble(montoNov.Text) + Convert.ToDouble(montoDic.Text);

                double porcentaje_suma_monto_oi = (suma_monto_oi / montoPauta) * 100;

                cantMonto.Text = Convert.ToString(suma_monto_oi);

                porcentajeMonto.Text = Convert.ToString(porcentaje_suma_monto_oi + "%");

                //facturado
                double suma_facturado = Convert.ToDouble(facturadoEne.Text) + Convert.ToDouble(facturadoFeb.Text) + Convert.ToDouble(facturadoMar.Text) + Convert.ToDouble(facturadoAbr.Text) + Convert.ToDouble(facturadoMay.Text) + Convert.ToDouble(facturadoJun.Text) + Convert.ToDouble(facturadoJul.Text) + Convert.ToDouble(facturadoAgo.Text) + Convert.ToDouble(facturadoSep.Text) + Convert.ToDouble(facturadoOct.Text) + Convert.ToDouble(facturadoNov.Text) + Convert.ToDouble(facturadoDic.Text);

                double porcentaje_suma_facturado = (suma_facturado / montoPauta) * 100;

                cantFacturado.Text = Convert.ToString(suma_facturado);

                porcentajeFacturado.Text = Convert.ToString(porcentaje_suma_facturado + "%");

                //cobrado
                double suma_cobrado = Convert.ToDouble(cobradoEne.Text) + Convert.ToDouble(cobradoFeb.Text) + Convert.ToDouble(cobradoMar.Text) + Convert.ToDouble(cobradoAbr.Text) + Convert.ToDouble(cobradoMay.Text) + Convert.ToDouble(cobradoJun.Text) + Convert.ToDouble(cobradoJul.Text) + Convert.ToDouble(cobradoAgo.Text) + Convert.ToDouble(cobradoSep.Text) + Convert.ToDouble(cobradoOct.Text) + Convert.ToDouble(cobradoNov.Text) + Convert.ToDouble(cobradoDic.Text);

                double porcentaje_suma_cobrado = (suma_cobrado / montoPauta) * 100;

                cantCobrado.Text = Convert.ToString(suma_cobrado);

                porcentajeCobrado.Text = Convert.ToString(porcentaje_suma_cobrado + "%");
            }
        }

        public void upload()
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
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_dos()
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
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_tres()
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
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        public void upload_ene()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcEne);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaEne);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_feb()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcFeb);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaFeb);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_mar()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcMar);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaMar);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_abr()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcAbr);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaAbr);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
               //MessageBox.Show(ex.Message);
            }
        }

        public void upload_may()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcMay);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaMay);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_jun()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcJun);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaJun);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_jul()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcJul);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaJul);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_ago()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcAgo);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaAgo);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_sep()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcSep);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaSep);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_oct()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcOct);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaOct);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_nov()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcNov);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaNov);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void upload_dic()
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://172.20.3.45/" + NombreArcDic);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("chay0s", "Chay0s1318");
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = true;
                FileStream stream = File.OpenRead(RutaDic);
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                //MessageBox.Show("Archivo subido correctamente!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reqStream.Close();
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void status_pauta()
        {
            try
            {
                con.Close();

                con.Open();
                string sql = "SELECT monto_fijo, monto_cobrado WHERE id_ordenes ='" + id.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //Q
                    string monto_fijo_pauta = Convert.ToString(reader["monto_fijo"]);
                    string monto_cobrado_pauta = Convert.ToString(reader["monto_cobrado"]);

                    if (monto_fijo_pauta == monto_cobrado_pauta)
                    {
                        textStatusOI.Text = "Activo";
                    }
                    else
                    {
                        textStatusOI.Text = "Inactivo";
                    }
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        public void ExportarExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = false;
            worksheet = workbook.Sheets["Hoja1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Datos";
            // Cabeceras
            for (int i = 1; i < listaSaldos.Columns.Count + 1; i++)
            {
                if (i > 1 && i < listaSaldos.Columns.Count)
                {
                    worksheet.Cells[1, i] = listaSaldos.Columns[i - 1].HeaderText;
                }
            }
            // Valores
            for (int i = 0; i < listaSaldos.Rows.Count - 1; i++)
            {
                for (int j = 0; j < listaSaldos.Columns.Count; j++)
                {
                    if (j > 0 && j < listaSaldos.Columns.Count - 1)
                    {
                        worksheet.Cells[i + 2, j + 1] = listaSaldos.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar archivo";
            saveFileDialog.FileName = "Datos ordenes de inserción";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
            }

            MessageBox.Show("Archivo generado", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void comboBeneficio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboNacional_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNacional.Text == "Si")
            {
                label14.Visible = true;
                tMonto.Visible = true;
            }
            else
            {
                label14.Visible = false;
                tMonto.Visible = false;
            }
        }

        private void ComboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboPais.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT `abrev` FROM `paises` WHERE id = '" + idCombo + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    t_pais = Convert.ToString(reader["abrev"]);

                    if (t_pais == "RO&AND")
                    {
                        labelOp.Visible = true;
                        labelCuenta.Visible = true;
                        labelID.Visible = true;
                        labelCuentaOp.Visible = true;
                        labelRazon.Visible = true;

                        comboOp.Visible = true;
                        comboCuentaOp.Visible = true;
                        textID.Visible = true;
                        comboCuenta.Visible = true;
                        comboRazonOp.Visible = true;

                        label8.Visible = false;
                        label18.Visible = false;
                        label7.Visible = false;
                        label43.Visible = false;
                        label9.Visible = false;
                        label17.Visible = false;

                        nombreBeneficio.Visible = false;
                        nombreBeneficio2.Visible = false;
                        textMonto.Visible = false;
                        textMonto2.Visible = false;
                        cant1.Visible = false;
                        cant2.Visible = false;
                    }
                    else
                    {
                        labelOp.Visible = false;
                        labelCuenta.Visible = false;
                        labelID.Visible = false;
                        labelCuentaOp.Visible = false;
                        labelRazon.Visible = false;

                        comboOp.Visible = false;
                        comboCuentaOp.Visible = false;
                        textID.Visible = false;
                        comboCuenta.Visible = false;
                        comboRazonOp.Visible = false;
                        //
                        label8.Visible = true;
                        //label18.Visible = true;
                        label7.Visible = true;
                        //label43.Visible = true;
                        //label9.Visible = true;
                        //label17.Visible = true;

                        //comboBeneficio.Visible = true;
                        //comboBeneficio2.Visible = true;
                        nombreBeneficio.Visible = true;
                        //nombreBeneficio2.Visible = true;
                        textMonto.Visible = true;
                        //textMonto2.Visible = true;
                        //cant1.Visible = true;
                        //cant2.Visible = true;
                    }

                    if (t_pais == "BRA" && checkNoches.Checked == true || t_pais == "RO&AND" && checkNoches.Checked == true)
                    {
                        cantNoches.Visible = true;
                        importeNoches.Visible = true;
                        label44.Visible = true;
                        label45.Visible = true;
                    }
                    else
                    {
                        cantNoches.Visible = false;
                        importeNoches.Visible = false;
                        label44.Visible = false;
                        label45.Visible = false;
                    }

                    textPais.Text = t_pais;
                }

                clave_pais = textPais.Text;

                //centro_beneficio();
                razonSocial();
                esquemaComision();

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void ComboCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCuenta.SelectedIndex == 0)
            {
                comboCuentaOp.SelectedIndex = 0;
            }

            if (comboCuenta.SelectedIndex == 1)
            {
                comboCuentaOp.SelectedIndex = 1;
            }

            if (comboCuenta.SelectedIndex == 2)
            {
                comboCuentaOp.SelectedIndex = 2;
            }
        }

        private void TMedia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            generaFolio();
        }

        private void TMontoIVA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                double precioSINIVA = 0;

                precio = Convert.ToInt32(tMontoIVA.Text);

                precioSINIVA = precio / 1.16;

                double total = Math.Round(precioSINIVA, 2);

                tMonto.Text = Convert.ToString(total);
                //Formato moneda
                //int MyInt = Convert.ToInt32(tMontoIVA.Text);
                //string MyString = MyInt.ToString("C", CultureInfo.InvariantCulture);
                //tMontoIVA.Text = MyString;
                //MessageBox.Show(MyString);
            }
            catch (Exception)
            {
                //MessageBox.Show("Revisa campo de monto" + m, "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //MessageBox.Show(m.Message);
            }
        }

        private void DateDesdeMKF_ValueChanged(object sender, EventArgs e)
        {
            string anio_pauta = "";

            anio_pauta = dateDesdeMKF.Value.Year.ToString();

            tEnero.Text = anio_pauta;
            tFebrero.Text = anio_pauta;
            tMarzo.Text = anio_pauta;
            tAbril.Text = anio_pauta;
            tMayo.Text = anio_pauta;
            tJunio.Text = anio_pauta;
            tJulio.Text = anio_pauta;
            tAgosto.Text = anio_pauta;
            tSeptiembre.Text = anio_pauta;
            tOctubre.Text = anio_pauta;
            tNoviembre.Text = anio_pauta;
            tDiciembre.Text = anio_pauta;
        }

        private void Cant2_TextChanged(object sender, EventArgs e)
        {
            int cantidad1, cantidad2 = 0;

            cantidad1 = Convert.ToInt32(cant1.Text);
            cantidad2 = Convert.ToInt32(cant2.Text);

            cantidad = cantidad1 + cantidad2;

            tMontoIVA.Text = Convert.ToString(cantidad);
        }

        private void CheckNoches_CheckedChanged(object sender, EventArgs e)
        {
            if (t_pais == "BRA" && checkNoches.Checked == true || t_pais == "RO&AND" && checkNoches.Checked == true)
            {
                cantNoches.Visible = true;
                importeNoches.Visible = true;
                label44.Visible = true;
                label45.Visible = true;
            }
            else
            {
                cantNoches.Visible = false;
                importeNoches.Visible = false;
                label44.Visible = false;
                label45.Visible = false;
            }
        }

        private void ComboComisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                string selectQuery = "select id, porcentaje from esquema_comision WHERE negociacion = '" + comboComisiones.Text + "'  AND region = '" + clave_pais + "'";
                con.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, con);

                MySqlDataAdapter mysqldt = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);

                if (comboComisiones.Text == "MEDIA" || comboComisiones.Text == "Marketing Fund")
                {
                    comboQ.Visible = true;
                    label41.Visible = true;
                    comboQPorcentaje.Visible = false;
                    label42.Visible = false;

                    campo1.Visible = false;
                    combo1.Visible = false;

                    campo2.Visible = false;
                    combo2.Visible = false;

                    campo3.Visible = false;
                    combo3.Visible = false;
                }
                else
                {
                    comboQPorcentaje.Visible = true;
                    label42.Visible = true;

                    comboQ.Visible = false;
                    label41.Visible = false;

                    comboQPorcentaje.ValueMember = "id";
                    comboQPorcentaje.DisplayMember = "porcentaje";
                    comboQPorcentaje.DataSource = dt;

                    campo1.Visible = false;
                    combo1.Visible = false;

                    campo2.Visible = false;
                    combo2.Visible = false;

                    campo3.Visible = false;
                    combo3.Visible = false;
                }
                con.Close();

                if (comboComisiones.Text == "Cash In")
                {
                    campo1.Text = "Supply Manager";
                    campo2.Text = "Account Manager";

                    combo1.Items.Clear();
                    combo2.Items.Clear();
                    combo3.Items.Clear();

                    combo1.Items.Add("2%");
                    combo1.Items.Add("3%");
                    combo1.Items.Add("5%");
                    combo1.SelectedIndex = 0;

                    combo2.Items.Add("2%");
                    combo2.Items.Add("No Aplica");
                    combo2.SelectedIndex = 0;

                    campo1.Visible = true;
                    combo1.Visible = true;

                    campo2.Visible = true;
                    combo2.Visible = true;

                    campo3.Visible = false;
                    combo3.Visible = false;
                }

                if (comboComisiones.Text == "Años Anteriores")
                {
                    campo1.Text = "Supply Manager";

                    combo1.Items.Clear();
                    combo2.Items.Clear();
                    combo3.Items.Clear();

                    combo1.Items.Add("3%");
                    combo1.SelectedIndex = 0;

                    campo1.Visible = true;
                    combo1.Visible = true;

                    campo2.Visible = false;
                    combo2.Visible = false;

                    campo3.Visible = false;
                    combo3.Visible = false;
                }

                if (comboComisiones.Text == "BD Travel")
                {
                    campo1.Text = "Steta";
                    campo2.Text = "Receptivo";

                    combo1.Items.Clear();
                    combo2.Items.Clear();
                    combo3.Items.Clear();

                    combo1.Items.Add("5%");
                    combo1.Items.Add("6.5%");
                    combo1.Items.Add("7.5%");
                    combo1.Items.Add("8%");
                    combo1.Items.Add("10%");
                    combo1.SelectedIndex = 0;

                    combo2.Items.Add("1%");
                    combo2.Items.Add("No Aplica");
                    combo2.SelectedIndex = 0;

                    campo1.Visible = true;
                    combo1.Visible = true;

                    campo2.Visible = true;
                    combo2.Visible = true;

                    campo3.Visible = false;
                    combo3.Visible = false;
                }

                if (comboComisiones.Text == "Marketing-Media COO")
                {
                    campo1.Text = "Supply Manager";
                    campo2.Text = "Back Office Marketing";
                    campo3.Text = "Back Office Account";

                    combo1.Items.Clear();
                    combo2.Items.Clear();
                    combo3.Items.Clear();

                    combo1.Items.Add("1.25%");
                    combo1.Items.Add("No Aplica");
                    combo1.SelectedIndex = 0;

                    combo2.Items.Add("0.63%");
                    combo2.Items.Add("No Aplica");
                    combo2.SelectedIndex = 0;

                    combo3.Items.Add("0.63%");
                    combo3.Items.Add("No Aplica");
                    combo3.SelectedIndex = 0;

                    campo1.Visible = true;
                    combo1.Visible = true;

                    campo2.Visible = true;
                    combo2.Visible = true;

                    campo3.Visible = true;
                    combo3.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboPauta_SelectedIndexChanged(object sender, EventArgs e)
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

                if (labelPauta.Text == "MKMMDCO")
                {
                    //comboBeneficio2.Visible = true;
                    nombreBeneficio.Text = "M10XMED000";
                    //comboBeneficio2.Text = "M10XCOM000";
                    nombreBeneficio2.Visible = true;
                    nombreBeneficio2.Text = "M10XCOM000";
                    textMonto2.Visible = true;
                    cant1.Visible = true;
                    cant2.Visible = true;
                    label9.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label43.Visible = true;
                }
                else
                {
                    nombreBeneficio.Visible = false;
                    textMonto2.Visible = false;
                    cant1.Visible = false;
                    cant2.Visible = false;
                    label9.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label43.Visible = false;
                    nombreBeneficio2.Visible = false;
                }

                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void ComboHoteles_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ComboRazon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int valor = Convert.ToInt32(comboRazon.SelectedIndex);
                int idCombo = valor + 1;
                //MessageBox.Show(Convert.ToString(idCombo));
                con.Close();
                con.Open();
                string sql = "SELECT nombre_comercial, id_hanna, siglas_hanna FROM clientes WHERE razon_social = '" + comboRazon.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string t_social = Convert.ToString(reader["nombre_comercial"]);
                    string t_id_hanna = Convert.ToString(reader["id_hanna"]);
                    string t_sigla_hanna = Convert.ToString(reader["siglas_hanna"]);

                    textComercial.Text = t_social;
                    tSiglas.Text = t_id_hanna;
                    tHann.Text = t_sigla_hanna;
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
             if (labelPauta.Text == "MKF")
            {
                if (nombreUno.Text == "")
                {
                    MessageBox.Show("Error, verifica campos vacios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string monto_total = Convert.ToString(cantMonto.Text);
                    string monto_c_iva = Convert.ToString(tMontoIVA.Text);
                    string monto_s_iva = Convert.ToString(tMonto.Text);

                    if (general.Privilegios == "admin")
                    {
                        try
                        {
                            string date_mkf_desde = dateDesdeMKF.Value.ToString("yyyy-MM-dd");
                            string date_mkf_hasta = dateHastaMKF.Value.ToString("yyyy-MM-dd");
                            string date_monto_desde = dateDesdeMonto.Value.ToString("yyyy-MM-dd");
                            string date_monto_hasta = dateHastaMonto.Value.ToString("yyyy-MM-dd");

                            generaFolio();
                            checkStatus();

                            con.Close();
                            con.Open();

                            MySqlCommand cmd = new MySqlCommand("INSERT INTO ordenes_insercion (`fecha_ingreso` ,`folio_media` , `status_OI` , `sigla_pais` , `tipo_pauta` , `categoria`, `contrato`, `razon_social` , `nombre_comercial`, `sigla_hotel`, `sigla_hanna` , `clave_hanna` , `centro_bneficio` , `centro_beneficio_2` , `cuenta_2` , `monto_1` , `monto_2`, `monto_pauta`, `anticipo_pauta`, `porcentaje_mkf` , `vig_desde_mkf` , `vig_hasta_mkf`  , `forma_calculo` , `monto_fijo` , `monto_fijo_iva` , `divisa` , `vig_monto_desde` , `vig_monto_hasta`, `transf_bancaria` , `compensacion`, `noches` , `cant_noches`,  `importe_noches`,  `ambas`, `esquema_comision`, `q` , `porcentaje_q` , `campo1` , `campo2` , `campo3` , `observaciones`, `supply_manager` , `ejecutivo_daf`, `account_manager` , `archivo` , `archivo_dos` , `archivo_tres` , `enero` , `febrero`, `marzo`, `abril`, `mayo` , `junio`, `julio` , `agosto`, `septiembre` , `octubre`, `noviembre` , `diciembre`, `anio_ene` , `anio_feb`, `anio_mar`, `anio_abr` , `anio_may` , `anio_jun` , `anio_jul`  , `anio_ago` , `anio_sep` , `anio_oct` , `anio_nov` , `anio_dic` , `monto_ene` , `monto_feb`, `monto_mar`, `monto_abr` , `monto_may` , `monto_jun` , `monto_jul`  , `monto_ago` , `monto_sep` , `monto_oct` , `monto_nov` , `monto_dic` , `facturado_ene` , `facturado_feb`, `facturado_mar`, `facturado_abr` , `facturado_may` , `facturado_jun` , `facturado_jul`  , `facturado_ago` , `facturado_sep` , `facturado_oct` , `facturado_nov` , `facturado_dic` , `doc_ene` , `doc_feb`, `doc_mar`, `doc_abr` , `doc_may` , `doc_jun` , `doc_jul`  , `doc_ago` , `doc_sep` , `doc_oct` , `doc_nov` , `doc_dic` , `archivo_ene` , `archivo_feb`, `archivo_mar`, `archivo_abr` , `archivo_may` , `archivo_jun` , `archivo_jul`  , `archivo_ago` , `archivo_sep` , `archivo_oct` , `archivo_nov` , `archivo_dic`, `cobrado_ene` , `cobrado_feb`, `cobrado_mar`, `cobrado_abr` , `cobrado_may` , `cobrado_jun` , `cobrado_jul`  , `cobrado_ago` , `cobrado_sep` , `cobrado_oct` , `cobrado_nov` , `cobrado_dic` , `fecha_cobro_ene` , `fecha_cobro_feb`, `fecha_cobro_mar`, `fecha_cobro_abr` , `fecha_cobro_may` , `fecha_cobro_jun` , `fecha_cobro_jul`  , `fecha_cobro_ago` , `fecha_cobro_sep` , `fecha_cobro_oct` , `fecha_cobro_nov` , `fecha_cobro_dic`  , `esquema_ene` , `esquema_feb`, `esquema_mar`, `esquema_abr` , `esquema_may` , `esquema_jun` , `esquema_jul`  , `esquema_ago` , `esquema_sep` , `esquema_oct` , `esquema_nov` , `esquema_dic` , `fecha_com_ene` , `fecha_com_feb`, `fecha_com_mar`, `fecha_com_abr` , `fecha_com_may` , `fecha_com_jun` , `fecha_com_jul`  , `fecha_com_ago` , `fecha_com_sep` , `fecha_com_oct` , `fecha_com_nov` , `fecha_com_dic` , `monto_pautado` , `monto_facturado` , `monto_cobrado` , `porcentaje_pautado` , `porcentaje_facturado` , `porcentaje_cobrado` , `tipo_op` , `id_maestro_op` , `numero_cuenta_op`, `cuenta_op` , `razon_op`) VALUES ('" + dateIngreso.Value.ToString("yyyy-MM-dd") + "','" + tMedia.Text + "','" + textStatusOI.Text + "','" + textPais.Text + "','" + labelPauta.Text + "','" + comboCategoria.Text + "','" + comboContrato.Text + "','" + comboRazon.Text + "','" + textComercial.Text + "','" + labelHotel.Text + "','" + tSiglas.Text + "','" + tHann.Text + "','" + nombreBeneficio.Text + "','" + nombreBeneficio2.Text + "','" + textMonto2.Text + "','" + cant1.Text + "','" + cant2.Text + "','" + 0 + "','" + 0 + "','" + comboPorcentajeMKF.Text + "','" + date_mkf_desde + "','" + date_mkf_hasta + "','" + forma_calculo + "','" + tMonto.Text + "','" + tMontoIVA.Text + "','" + comboDivisa.Text + "','" + date_monto_desde + "','" + date_monto_hasta + "','" + transfer_bancaria + "','" + compensacion + "','" + noches + "','" + cantNoches.Text + "','" + importeNoches.Text + "','" + ambos + "','" + comboComisiones.Text + "','" + comboQ.Text + "','" + comboQPorcentaje.Text + "','" + combo1.Text + "','" + combo2.Text + "','" + combo3.Text + "','" + textObservaciones.Text + "','" + comboSupply.Text + "','" + comboEjecutivoDAF.Text + "','" + comboAccount.Text + "','" + nombreUno.Text + "','" + nombreDos.Text + "','" + nombreTres.Text + "','" + senero + "','" + sfebrero + "','" + smarzo + "','" + sabril + "','" + smayo + "','" + sjunio + "','" + sjulio + "','" + sagosto + "','" + sseptiembre + "','" + soctubre + "','" + snoviembre + "','" + sdiciembre + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + montoEne.Text + "','" + montoFeb.Text + "','" + montoMar.Text + "','" + montoAbr.Text + "','" + montoMayo.Text + "','" + montoJun.Text + "','" + montoJul.Text + "','" + montoAgo.Text + "','" + montoSep.Text + "','" + montoOct.Text + "','" + montoNov.Text + "','" + montoDic.Text + "','" + facturadoEne.Text + "','" + facturadoFeb.Text + "','" + facturadoMar.Text + "','" + facturadoAbr.Text + "','" + facturadoMay.Text + "','" + facturadoJun.Text + "','" + facturadoJul.Text + "','" + facturadoAgo.Text + "','" + facturadoSep.Text + "','" + facturadoOct.Text + "','" + facturadoNov.Text + "','" + facturadoDic.Text + "','" + textDocEne.Text + "','" + textDocFeb.Text + "','" + textDocMar.Text + "','" + textDocAbr.Text + "','" + textDocMay.Text + "','" + textDocJun.Text + "','" + textDocJul.Text + "','" + textDocAgo.Text + "','" + textDocSep.Text + "','" + textDocOct.Text + "','" + textDocNov.Text + "','" + textDocDic.Text + "','" + NombreArcEne + "','" + NombreArcFeb + "','" + NombreArcMar + "','" + NombreArcAbr + "','" + NombreArcMay + "','" + NombreArcJun + "','" + NombreArcJul + "','" + NombreArcAgo + "','" + NombreArcSep + "','" + NombreArcOct + "','" + NombreArcNov + "','" + NombreArcDic + "','" + cobradoEne.Text + "','" + cobradoFeb.Text + "','" + cobradoMar.Text + "','" + cobradoAbr.Text + "','" + cobradoMay.Text + "','" + cobradoJun.Text + "','" + cobradoJul.Text + "','" + cobradoAgo.Text + "','" + cobradoSep.Text + "','" + cobradoOct.Text + "','" + cobradoNov.Text + "','" + cobradoDic.Text + "','" + dateEne.Value.ToString("yyyy-MM-dd") + "','" + dateFeb.Value.ToString("yyyy-MM-dd") + "','" + dateMar.Value.ToString("yyyy-MM-dd") + "','" + dateAbr.Value.ToString("yyyy-MM-dd") + "','" + dateMay.Value.ToString("yyyy-MM-dd") + "','" + dateJun.Value.ToString("yyyy-MM-dd") + "','" + dateJul.Value.ToString("yyyy-MM-dd") + "','" + dateAgo.Value.ToString("yyyy-MM-dd") + "','" + dateSep.Value.ToString("yyyy-MM-dd") + "','" + dateOct.Value.ToString("yyyy-MM-dd") + "','" + dateNov.Value.ToString("yyyy-MM-dd") + "','" + dateDic.Value.ToString("yyyy-MM-dd") + "','" + esquemaEne.Text + "','" + esquemaFeb.Text + "','" + esquemaMar.Text + "','" + esquemaAbr.Text + "','" + esquemaMay.Text + "','" + esquemaJun.Text + "','" + esquemaJul.Text + "','" + esquemaAgo.Text + "','" + esquemaSep.Text + "','" + esquemaOct.Text + "','" + esquemaNov.Text + "','" + esquemaDic.Text + "','" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "','" + cantMonto.Text + "','" + cantFacturado.Text + "','" + cantCobrado.Text + "','" + porcentajeMonto.Text + "','" + porcentajeFacturado.Text + "','" + porcentajeCobrado.Text + "','" + comboOp.Text + "','" + textID.Text + "','" + comboCuenta.Text + "','" + comboCuentaOp.Text + "','" + comboRazonOp.Text + "' )", con);
                            cmd.ExecuteNonQuery();
                            upload();
                            upload_dos();
                            upload_tres();
                            upload_ene();
                            upload_feb();
                            upload_mar();
                            upload_abr();
                            upload_may();
                            upload_jun();
                            upload_jul();
                            upload_ago();
                            upload_sep();
                            upload_oct();
                            upload_nov();
                            upload_dic();
                            MessageBox.Show("Archivos subidos correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            }
            else
            {
                if (tMonto.Text == "" || tMontoIVA.Text == "" || nombreUno.Text == "")
                {
                    MessageBox.Show("Error, verifica campos vacios", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string monto_total = Convert.ToString(cantMonto.Text);
                    string monto_c_iva = Convert.ToString(tMontoIVA.Text);
                    string monto_s_iva = Convert.ToString(tMonto.Text);

                    if (cantMonto.Text == "")
                    {
                        MessageBox.Show("Error, verifica montos de pauta diferentes", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (general.Privilegios == "admin")
                        {
                            try
                            {
                                string date_mkf_desde = dateDesdeMKF.Value.ToString("yyyy-MM-dd");
                                string date_mkf_hasta = dateHastaMKF.Value.ToString("yyyy-MM-dd");
                                string date_monto_desde = dateDesdeMonto.Value.ToString("yyyy-MM-dd");
                                string date_monto_hasta = dateHastaMonto.Value.ToString("yyyy-MM-dd");

                                generaFolio();
                                checkStatus();

                                con.Close();
                                con.Open();

                                MySqlCommand cmd = new MySqlCommand("INSERT INTO ordenes_insercion (`fecha_ingreso` ,`folio_media` , `status_OI` , `sigla_pais` , `tipo_pauta` , `categoria`, `contrato`, `razon_social` , `nombre_comercial`, `sigla_hotel`, `sigla_hanna` , `clave_hanna` , `centro_bneficio` , `centro_beneficio_2` , `cuenta_2` , `monto_1` , `monto_2`, `monto_pauta`, `anticipo_pauta`, `porcentaje_mkf` , `vig_desde_mkf` , `vig_hasta_mkf`  , `forma_calculo` , `monto_fijo` , `monto_fijo_iva` , `divisa` , `vig_monto_desde` , `vig_monto_hasta`, `transf_bancaria` , `compensacion`, `noches` , `cant_noches`,  `importe_noches`,  `ambas`, `esquema_comision`, `q` , `porcentaje_q` , `campo1` , `campo2` , `campo3` , `observaciones`, `supply_manager` , `ejecutivo_daf`, `account_manager` , `archivo` , `archivo_dos` , `archivo_tres` , `enero` , `febrero`, `marzo`, `abril`, `mayo` , `junio`, `julio` , `agosto`, `septiembre` , `octubre`, `noviembre` , `diciembre`, `anio_ene` , `anio_feb`, `anio_mar`, `anio_abr` , `anio_may` , `anio_jun` , `anio_jul`  , `anio_ago` , `anio_sep` , `anio_oct` , `anio_nov` , `anio_dic` , `monto_ene` , `monto_feb`, `monto_mar`, `monto_abr` , `monto_may` , `monto_jun` , `monto_jul`  , `monto_ago` , `monto_sep` , `monto_oct` , `monto_nov` , `monto_dic` , `facturado_ene` , `facturado_feb`, `facturado_mar`, `facturado_abr` , `facturado_may` , `facturado_jun` , `facturado_jul`  , `facturado_ago` , `facturado_sep` , `facturado_oct` , `facturado_nov` , `facturado_dic` , `doc_ene` , `doc_feb`, `doc_mar`, `doc_abr` , `doc_may` , `doc_jun` , `doc_jul`  , `doc_ago` , `doc_sep` , `doc_oct` , `doc_nov` , `doc_dic` , `archivo_ene` , `archivo_feb`, `archivo_mar`, `archivo_abr` , `archivo_may` , `archivo_jun` , `archivo_jul`  , `archivo_ago` , `archivo_sep` , `archivo_oct` , `archivo_nov` , `archivo_dic`, `cobrado_ene` , `cobrado_feb`, `cobrado_mar`, `cobrado_abr` , `cobrado_may` , `cobrado_jun` , `cobrado_jul`  , `cobrado_ago` , `cobrado_sep` , `cobrado_oct` , `cobrado_nov` , `cobrado_dic` , `fecha_cobro_ene` , `fecha_cobro_feb`, `fecha_cobro_mar`, `fecha_cobro_abr` , `fecha_cobro_may` , `fecha_cobro_jun` , `fecha_cobro_jul`  , `fecha_cobro_ago` , `fecha_cobro_sep` , `fecha_cobro_oct` , `fecha_cobro_nov` , `fecha_cobro_dic`  , `esquema_ene` , `esquema_feb`, `esquema_mar`, `esquema_abr` , `esquema_may` , `esquema_jun` , `esquema_jul`  , `esquema_ago` , `esquema_sep` , `esquema_oct` , `esquema_nov` , `esquema_dic` , `fecha_com_ene` , `fecha_com_feb`, `fecha_com_mar`, `fecha_com_abr` , `fecha_com_may` , `fecha_com_jun` , `fecha_com_jul`  , `fecha_com_ago` , `fecha_com_sep` , `fecha_com_oct` , `fecha_com_nov` , `fecha_com_dic` , `monto_pautado` , `monto_facturado` , `monto_cobrado` , `porcentaje_pautado` , `porcentaje_facturado` , `porcentaje_cobrado` , `tipo_op` , `id_maestro_op` , `numero_cuenta_op`, `cuenta_op` , `razon_op`) VALUES ('" + dateIngreso.Value.ToString("yyyy-MM-dd") + "','" + tMedia.Text + "','" + textStatusOI.Text + "','" + textPais.Text + "','" + labelPauta.Text + "','" + comboCategoria.Text + "','" + comboContrato.Text + "','" + comboRazon.Text + "','" + textComercial.Text + "','" + labelHotel.Text + "','" + tSiglas.Text + "','" + tHann.Text + "','" + nombreBeneficio.Text + "','" + nombreBeneficio2.Text + "','" + textMonto2.Text + "','" + cant1.Text + "','" + cant2.Text + "','" + 0 + "','" + 0 + "','" + comboPorcentajeMKF.Text + "','" + date_mkf_desde + "','" + date_mkf_hasta + "','" + forma_calculo + "','" + tMonto.Text + "','" + tMontoIVA.Text + "','" + comboDivisa.Text + "','" + date_monto_desde + "','" + date_monto_hasta + "','" + transfer_bancaria + "','" + compensacion + "','" + noches + "','" + cantNoches.Text + "','" + importeNoches.Text + "','" + ambos + "','" + comboComisiones.Text + "','" + comboQ.Text + "','" + comboQPorcentaje.Text + "','" + combo1.Text + "','" + combo2.Text + "','" + combo3.Text + "','" + textObservaciones.Text + "','" + comboSupply.Text + "','" + comboEjecutivoDAF.Text + "','" + comboAccount.Text + "','" + nombreUno.Text + "','" + nombreDos.Text + "','" + nombreTres.Text + "','" + senero + "','" + sfebrero + "','" + smarzo + "','" + sabril + "','" + smayo + "','" + sjunio + "','" + sjulio + "','" + sagosto + "','" + sseptiembre + "','" + soctubre + "','" + snoviembre + "','" + sdiciembre + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + montoEne.Text + "','" + montoFeb.Text + "','" + montoMar.Text + "','" + montoAbr.Text + "','" + montoMayo.Text + "','" + montoJun.Text + "','" + montoJul.Text + "','" + montoAgo.Text + "','" + montoSep.Text + "','" + montoOct.Text + "','" + montoNov.Text + "','" + montoDic.Text + "','" + facturadoEne.Text + "','" + facturadoFeb.Text + "','" + facturadoMar.Text + "','" + facturadoAbr.Text + "','" + facturadoMay.Text + "','" + facturadoJun.Text + "','" + facturadoJul.Text + "','" + facturadoAgo.Text + "','" + facturadoSep.Text + "','" + facturadoOct.Text + "','" + facturadoNov.Text + "','" + facturadoDic.Text + "','" + textDocEne.Text + "','" + textDocFeb.Text + "','" + textDocMar.Text + "','" + textDocAbr.Text + "','" + textDocMay.Text + "','" + textDocJun.Text + "','" + textDocJul.Text + "','" + textDocAgo.Text + "','" + textDocSep.Text + "','" + textDocOct.Text + "','" + textDocNov.Text + "','" + textDocDic.Text + "','" + NombreArcEne + "','" + NombreArcFeb + "','" + NombreArcMar + "','" + NombreArcAbr + "','" + NombreArcMay + "','" + NombreArcJun + "','" + NombreArcJul + "','" + NombreArcAgo + "','" + NombreArcSep + "','" + NombreArcOct + "','" + NombreArcNov + "','" + NombreArcDic + "','" + cobradoEne.Text + "','" + cobradoFeb.Text + "','" + cobradoMar.Text + "','" + cobradoAbr.Text + "','" + cobradoMay.Text + "','" + cobradoJun.Text + "','" + cobradoJul.Text + "','" + cobradoAgo.Text + "','" + cobradoSep.Text + "','" + cobradoOct.Text + "','" + cobradoNov.Text + "','" + cobradoDic.Text + "','" + dateEne.Value.ToString("yyyy-MM-dd") + "','" + dateFeb.Value.ToString("yyyy-MM-dd") + "','" + dateMar.Value.ToString("yyyy-MM-dd") + "','" + dateAbr.Value.ToString("yyyy-MM-dd") + "','" + dateMay.Value.ToString("yyyy-MM-dd") + "','" + dateJun.Value.ToString("yyyy-MM-dd") + "','" + dateJul.Value.ToString("yyyy-MM-dd") + "','" + dateAgo.Value.ToString("yyyy-MM-dd") + "','" + dateSep.Value.ToString("yyyy-MM-dd") + "','" + dateOct.Value.ToString("yyyy-MM-dd") + "','" + dateNov.Value.ToString("yyyy-MM-dd") + "','" + dateDic.Value.ToString("yyyy-MM-dd") + "','" + esquemaEne.Text + "','" + esquemaFeb.Text + "','" + esquemaMar.Text + "','" + esquemaAbr.Text + "','" + esquemaMay.Text + "','" + esquemaJun.Text + "','" + esquemaJul.Text + "','" + esquemaAgo.Text + "','" + esquemaSep.Text + "','" + esquemaOct.Text + "','" + esquemaNov.Text + "','" + esquemaDic.Text + "','" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "','" + cantMonto.Text + "','" + cantFacturado.Text + "','" + cantCobrado.Text + "','" + porcentajeMonto.Text + "','" + porcentajeFacturado.Text + "','" + porcentajeCobrado.Text + "','" + comboOp.Text + "','" + textID.Text + "','" + comboCuenta.Text + "','" + comboCuentaOp.Text + "','" + comboRazonOp.Text + "' )", con);
                                cmd.ExecuteNonQuery();
                                upload();
                                upload_dos();
                                upload_tres();
                                upload_ene();
                                upload_feb();
                                upload_mar();
                                upload_abr();
                                upload_may();
                                upload_jun();
                                upload_jul();
                                upload_ago();
                                upload_sep();
                                upload_oct();
                                upload_nov();
                                upload_dic();
                                MessageBox.Show("Archivos subidos correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();

                checkStatus();

                string date_mkf_desde = dateDesdeMKF.Value.ToString("yyyy-MM-dd");
                string date_mkf_hasta = dateHastaMKF.Value.ToString("yyyy-MM-dd");
                string date_monto_desde = dateDesdeMonto.Value.ToString("yyyy-MM-dd");
                string date_monto_hasta = dateHastaMonto.Value.ToString("yyyy-MM-dd");

                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE `ordenes_insercion` SET `folio_media`='" + tMedia.Text + "',`status_OI`='" + textStatusOI.Text + "',`sigla_pais`='" + textPais.Text + "',`tipo_pauta`='" + labelPauta.Text + "',`categoria`='" + comboCategoria.Text + "',`contrato`='" + comboContrato.Text + "',`razon_social`='" + comboRazon.Text + "',`nombre_comercial`='" + textComercial.Text + "',`sigla_hotel`='" + labelHotel.Text + "',`sigla_hanna`='" + tSiglas.Text + "',`clave_hanna`='" + tHann.Text + "',`centro_bneficio`='" + nombreBeneficio.Text + "',`monto_pauta`='" + textMonto.Text + "',`anticipo_pauta`='" + textAnticipo.Text + "',`porcentaje_mkf`='" + comboPorcentajeMKF.Text + "',`vig_desde_mkf`='" + date_mkf_desde + "',`vig_hasta_mkf`='" + date_mkf_hasta + "',`monto_fijo`='" + tMonto.Text + "',`monto_fijo_iva`='" + tMontoIVA.Text + "',`divisa`='" + comboDivisa.Text + "',`vig_monto_desde`='" + date_monto_desde + "',`vig_monto_hasta`='" + date_monto_hasta + "', `transf_bancaria`='" + transfer_bancaria + "',`compensacion`='" + compensacion + "', `noches`='" + noches + "', `cant_noches`='" + cantNoches.Text + "', `importe_noches`='" + importeNoches.Text + "', `ambas`='" + ambos + "', `esquema_comision`='" + comboComisiones.Text + "', `q`='" + comboQ.Text + "', `porcentaje_q`='" + comboQPorcentaje.Text + "', `campo1`='" + combo1.Text + "', `campo2`='" + combo2.Text + "', `campo3`='" + combo3.Text + "', `observaciones`='" + textObservaciones.Text + "', `supply_manager`='" + comboSupply.Text + "',`ejecutivo_daf`='" + comboEjecutivoDAF.Text + "',`account_manager`='" + comboAccount.Text + "',`archivo`='" + nombreUno.Text + "',`archivo_dos`='" + nombreDos.Text + "',`archivo_tres`='" + nombreTres.Text + "',`enero`='" + senero + "',`febrero`='" + sfebrero + "',`marzo`='" + smarzo + "',`abril`='" + sabril + "',`mayo`='" + smayo + "',`junio`='" + sjulio + "',`julio`='" + sjulio + "',`agosto`='" + sagosto + "',`septiembre`='" + sseptiembre + "',`octubre`='" + soctubre + "',`noviembre`='" + snoviembre + "',`diciembre`='" + sdiciembre + "',`anio_ene`='" + tEnero.Text + "',`anio_feb`='" + tFebrero.Text + "',`anio_mar`='" + tMarzo.Text + "',`anio_abr`='" + tAbril.Text + "',`anio_may`='" + tMayo.Text + "',`anio_jun`='" + tJunio.Text + "',`anio_jul`='" + tJulio.Text + "',`anio_ago`='" + tAgosto.Text + "',`anio_sep`='" + tSeptiembre.Text + "',`anio_oct`='" + tOctubre.Text + "',`anio_nov`='" + tNoviembre.Text + "',`anio_dic`='" + tDiciembre.Text + "',`monto_ene`='" + montoEne.Text + "',`monto_feb`='" + montoFeb.Text + "',`monto_mar`='" + montoMar.Text + "',`monto_abr`='" + montoAbr.Text + "',`monto_may`='" + montoMayo.Text + "',`monto_jun`='" + montoJun.Text + "',`monto_jul`='" + montoJul.Text + "',`monto_ago`='" + montoAgo.Text + "',`monto_sep`='" + montoSep.Text + "',`monto_oct`='" + montoOct.Text + "',`monto_nov`='" + montoNov.Text + "',`monto_dic`='" + montoDic.Text + "',`facturado_ene`='" + facturadoEne.Text + "',`facturado_feb`='" + facturadoFeb.Text + "',`facturado_mar`='" + facturadoMar.Text + "',`facturado_abr`='" + facturadoAbr.Text + "',`facturado_may`='" + facturadoMay.Text + "',`facturado_jun`='" + facturadoJun.Text + "',`facturado_jul`='" + facturadoJul.Text + "',`facturado_ago`='" + facturadoAgo.Text + "',`facturado_sep`='" + facturadoSep.Text + "',`facturado_oct`='" + facturadoOct.Text + "',`facturado_nov`='" + facturadoNov.Text + "',`facturado_dic`='" + facturadoDic.Text + "',`doc_ene`='" + textDocEne.Text + "',`doc_feb`='" + textDocFeb.Text + "',`doc_mar`='" + textDocMar.Text + "',`doc_abr`='" + textDocAbr.Text + "',`doc_may`='" + textDocMay.Text + "',`doc_jun`='" + textDocJun.Text + "',`doc_jul`='" + textDocJul.Text + "',`doc_ago`='" + textDocAgo.Text + "',`doc_sep`='" + textDocSep.Text + "',`doc_oct`='" + textDocOct.Text + "',`doc_nov`='" + textDocNov.Text + "',`doc_dic`='" + textDocDic.Text + "',`archivo_ene`='" + NombreArcEne + "',`archivo_feb`='" + NombreArcFeb + "',`archivo_mar`='" + NombreArcMar + "',`archivo_abr`='" + NombreArcAbr + "',`archivo_may`='" + NombreArcMay + "',`archivo_jun`='" + NombreArcJun + "',`archivo_jul`='" + NombreArcJul + "',`archivo_ago`='" + NombreArcAgo + "',`archivo_sep`='" + NombreArcSep + "',`archivo_oct`='" + NombreArcOct + "',`archivo_nov`='" + NombreArcNov + "',`archivo_dic`='" + NombreArcDic + "',`cobrado_ene`='" + cobradoEne.Text + "',`cobrado_feb`='" + cobradoFeb.Text + "',`cobrado_mar`='" + cobradoMar.Text + "',`cobrado_abr`='" + cobradoAbr.Text + "',`cobrado_may`='" + cobradoMay.Text + "',`cobrado_jun`='" + cobradoJun.Text + "',`cobrado_jul`='" + cobradoJul.Text + "',`cobrado_ago`='" + cobradoAgo.Text + "',`cobrado_sep`='" + cobradoSep.Text + "',`cobrado_oct`='" + cobradoOct.Text + "',`cobrado_nov`='" + cobradoNov.Text + "',`cobrado_dic`='" + cobradoDic.Text + "',`fecha_cobro_ene`='" + dateEne.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_feb`='" + dateFeb.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_mar`='" + dateMar.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_abr`='" + dateAbr.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_may`='" + dateMay.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_jun`='" + dateJun.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_jul`='" + dateJul.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_ago`='" + dateAgo.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_sep`='" + dateSep.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_oct`='" + dateOct.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_nov`='" + dateNov.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_dic`='" + dateDic.Value.ToString("yyyy-MM-dd") + "',`esquema_ene`='" + esquemaEne.Text + "',`esquema_feb`='" + esquemaFeb.Text + "',`esquema_mar`='" + esquemaMar.Text + "',`esquema_abr`='" + esquemaAbr.Text + "',`esquema_may`='" + esquemaMay.Text + "',`esquema_jun`='" + esquemaJun.Text + "',`esquema_jul`='" + esquemaJul.Text + "',`esquema_ago`='" + esquemaAgo.Text + "',`esquema_sep`='" + esquemaSep.Text + "',`esquema_oct`='" + esquemaOct.Text + "',`esquema_nov`='" + esquemaNov.Text + "',`esquema_dic`='" + esquemaDic.Text + "',`fecha_com_ene`='" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "',`fecha_com_feb`='" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "',`fecha_com_mar`='" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "',`fecha_com_abr`='" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "',`fecha_com_may`='" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "',`fecha_com_jun`='" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "',`fecha_com_jul`='" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "',`fecha_com_ago`='" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "',`fecha_com_sep`='" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "',`fecha_com_oct`='" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "',`fecha_com_nov`='" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "',`fecha_com_dic`='" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "',`monto_pautado`='" + cantMonto.Text + "',`monto_facturado`='" + cantFacturado.Text + "',`monto_cobrado`='" + cantCobrado.Text + "',`porcentaje_pautado`='" + porcentajeMonto.Text + "',`porcentaje_facturado`='" + porcentajeFacturado.Text + "',`porcentaje_cobrado`='" + porcentajeCobrado.Text + "',`tipo_op`='" + comboOp.Text + "',`id_maestro_op`='" + textID.Text + "',`numero_cuenta_op`='" + comboCuenta.Text + "',`cuenta_op`='" + comboCuentaOp.Text + "',`razon_op`='" + comboCuentaOp.Text + "' WHERE id_ordenes = '" + id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();

                //limpiar();
                llenar();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (general.Privilegios == "admin")
            {
                try
                {
                    con.Close();

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `ordenes_insercion` WHERE id_ordenes ='" + id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registro eliminado correctamente", "Sistema BestDay Media", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    limpiar();
                    llenar();
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

        private void Explor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            NombreImgHM = tMedia.Text + "-" + nombreUno.Text;
            //MessageBox.Show(NombreImgHM);
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreUno.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void ExploreTres_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ExploreDos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Recuerda nombrar el archivo de la forma correcta", "Recuerda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void All_Click(object sender, EventArgs e)
        {
            listaSaldos.Rows.Clear();
            listaSaldos.Refresh();

            llenar();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string sentencia = "";
                string busqueda = "";

                if (cbFechas.Checked == true)
                {
                    string inicio = fechaDesde.Value.ToString("yyyy/MM/dd");
                    string fin = fechaHasta.Value.ToString("yyyy/MM/dd");
                    sentencia = "SELECT * FROM ordenes_insercion WHERE fecha_ingreso BETWEEN'" + inicio + "'AND'" + fin + "'";
                }


                if (cbRazon.Checked == true)
                {
                    busqueda = tbRazon.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE razon_social LIKE '%" + busqueda + "%'";
                }

                if (cbComercial.Checked == true)
                {
                    busqueda = tbComercial.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE nombre_comercial LIKE '%" + busqueda + "%'";
                }

                if (cbMarket.Checked == true)
                {
                    busqueda = tbMarket.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE market_manager LIKE '%" + busqueda + "%'";
                }

                if (cbAccount.Checked == true)
                {
                    busqueda = tbAccount.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE account_manager LIKE '%" + busqueda + "%'";
                }

                if (cbMedia.Checked == true)
                {
                    busqueda = tbClaveM.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE clave_media LIKE '%" + busqueda + "%'";
                }

                if (cbForma.Checked == true)
                {
                    busqueda = comboBForma.Text;
                    sentencia = "SELECT * FROM ordenes_insercion WHERE forma_pago LIKE '%" + busqueda + "%'";
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
                    listaSaldos.Rows[n].Cells[0].Value = item["id_ordenes"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["fecha_ingreso"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["folio_media"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["status_OI"].ToString();
                    listaSaldos.Rows[n].Cells[4].Value = item["sigla_pais"].ToString();
                    listaSaldos.Rows[n].Cells[5].Value = item["tipo_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[6].Value = item["categoria"].ToString();
                    listaSaldos.Rows[n].Cells[7].Value = item["contrato"].ToString();
                    listaSaldos.Rows[n].Cells[8].Value = item["razon_social"].ToString();
                    listaSaldos.Rows[n].Cells[9].Value = item["nombre_comercial"].ToString();
                    listaSaldos.Rows[n].Cells[10].Value = item["sigla_hotel"].ToString();
                    listaSaldos.Rows[n].Cells[11].Value = item["sigla_hanna"].ToString();
                    listaSaldos.Rows[n].Cells[12].Value = item["clave_hanna"].ToString();
                    listaSaldos.Rows[n].Cells[13].Value = item["centro_bneficio"].ToString();
                    listaSaldos.Rows[n].Cells[14].Value = item["monto_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[15].Value = item["anticipo_pauta"].ToString();
                    listaSaldos.Rows[n].Cells[16].Value = item["porcentaje_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[17].Value = item["vig_desde_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[18].Value = item["vig_hasta_mkf"].ToString();
                    listaSaldos.Rows[n].Cells[19].Value = item["forma_calculo"].ToString();
                    listaSaldos.Rows[n].Cells[20].Value = item["monto_fijo"].ToString();
                    listaSaldos.Rows[n].Cells[21].Value = item["monto_fijo_iva"].ToString();
                    listaSaldos.Rows[n].Cells[22].Value = item["divisa"].ToString();
                    listaSaldos.Rows[n].Cells[23].Value = item["vig_monto_desde"].ToString();
                    listaSaldos.Rows[n].Cells[24].Value = item["vig_monto_hasta"].ToString();
                    listaSaldos.Rows[n].Cells[25].Value = item["transf_bancaria"].ToString();
                    listaSaldos.Rows[n].Cells[26].Value = item["compensacion"].ToString();
                    listaSaldos.Rows[n].Cells[27].Value = item["noches"].ToString();
                    listaSaldos.Rows[n].Cells[28].Value = item["ambas"].ToString();
                    listaSaldos.Rows[n].Cells[29].Value = item["esquema_comision"].ToString();
                    listaSaldos.Rows[n].Cells[30].Value = item["observaciones"].ToString();
                    listaSaldos.Rows[n].Cells[31].Value = item["supply_manager"].ToString();
                    listaSaldos.Rows[n].Cells[32].Value = item["ejecutivo_daf"].ToString();
                    listaSaldos.Rows[n].Cells[33].Value = item["account_manager"].ToString();
                    listaSaldos.Rows[n].Cells[34].Value = item["archivo"].ToString();
                    listaSaldos.Rows[n].Cells[35].Value = item["enero"].ToString();
                    listaSaldos.Rows[n].Cells[36].Value = item["febrero"].ToString();
                    listaSaldos.Rows[n].Cells[37].Value = item["marzo"].ToString();
                    listaSaldos.Rows[n].Cells[38].Value = item["abril"].ToString();
                    listaSaldos.Rows[n].Cells[39].Value = item["mayo"].ToString();
                    listaSaldos.Rows[n].Cells[40].Value = item["junio"].ToString();
                    listaSaldos.Rows[n].Cells[41].Value = item["julio"].ToString();
                    listaSaldos.Rows[n].Cells[42].Value = item["agosto"].ToString();
                    listaSaldos.Rows[n].Cells[43].Value = item["septiembre"].ToString();
                    listaSaldos.Rows[n].Cells[44].Value = item["octubre"].ToString();
                    listaSaldos.Rows[n].Cells[45].Value = item["noviembre"].ToString();
                    listaSaldos.Rows[n].Cells[46].Value = item["diciembre"].ToString();
                    listaSaldos.Rows[n].Cells[47].Value = item["anio_ene"].ToString();
                    listaSaldos.Rows[n].Cells[48].Value = item["anio_feb"].ToString();
                    listaSaldos.Rows[n].Cells[49].Value = item["anio_mar"].ToString();
                    listaSaldos.Rows[n].Cells[50].Value = item["anio_abr"].ToString();
                    listaSaldos.Rows[n].Cells[51].Value = item["anio_may"].ToString();
                    listaSaldos.Rows[n].Cells[52].Value = item["anio_jun"].ToString();
                    listaSaldos.Rows[n].Cells[53].Value = item["anio_jul"].ToString();
                    listaSaldos.Rows[n].Cells[54].Value = item["anio_ago"].ToString();
                    listaSaldos.Rows[n].Cells[55].Value = item["anio_sep"].ToString();
                    listaSaldos.Rows[n].Cells[56].Value = item["anio_oct"].ToString();
                    listaSaldos.Rows[n].Cells[57].Value = item["anio_nov"].ToString();
                    listaSaldos.Rows[n].Cells[58].Value = item["anio_dic"].ToString();
                    listaSaldos.Rows[n].Cells[59].Value = item["monto_ene"].ToString();
                    listaSaldos.Rows[n].Cells[60].Value = item["monto_feb"].ToString();
                    listaSaldos.Rows[n].Cells[61].Value = item["monto_mar"].ToString();
                    listaSaldos.Rows[n].Cells[62].Value = item["monto_abr"].ToString();
                    listaSaldos.Rows[n].Cells[63].Value = item["monto_may"].ToString();
                    listaSaldos.Rows[n].Cells[64].Value = item["monto_jun"].ToString();
                    listaSaldos.Rows[n].Cells[65].Value = item["monto_jul"].ToString();
                    listaSaldos.Rows[n].Cells[66].Value = item["monto_ago"].ToString();
                    listaSaldos.Rows[n].Cells[67].Value = item["monto_sep"].ToString();
                    listaSaldos.Rows[n].Cells[68].Value = item["monto_oct"].ToString();
                    listaSaldos.Rows[n].Cells[69].Value = item["monto_nov"].ToString();
                    listaSaldos.Rows[n].Cells[70].Value = item["monto_dic"].ToString();
                    listaSaldos.Rows[n].Cells[71].Value = item["facturado_ene"].ToString();
                    listaSaldos.Rows[n].Cells[72].Value = item["facturado_feb"].ToString();
                    listaSaldos.Rows[n].Cells[73].Value = item["facturado_mar"].ToString();
                    listaSaldos.Rows[n].Cells[74].Value = item["facturado_abr"].ToString();
                    listaSaldos.Rows[n].Cells[75].Value = item["facturado_may"].ToString();
                    listaSaldos.Rows[n].Cells[76].Value = item["facturado_jun"].ToString();
                    listaSaldos.Rows[n].Cells[77].Value = item["facturado_jul"].ToString();
                    listaSaldos.Rows[n].Cells[78].Value = item["facturado_ago"].ToString();
                    listaSaldos.Rows[n].Cells[79].Value = item["facturado_sep"].ToString();
                    listaSaldos.Rows[n].Cells[80].Value = item["facturado_oct"].ToString();
                    listaSaldos.Rows[n].Cells[81].Value = item["facturado_nov"].ToString();
                    listaSaldos.Rows[n].Cells[82].Value = item["facturado_dic"].ToString();
                    listaSaldos.Rows[n].Cells[83].Value = item["cobrado_ene"].ToString();
                    listaSaldos.Rows[n].Cells[84].Value = item["cobrado_feb"].ToString();
                    listaSaldos.Rows[n].Cells[85].Value = item["cobrado_mar"].ToString();
                    listaSaldos.Rows[n].Cells[86].Value = item["cobrado_abr"].ToString();
                    listaSaldos.Rows[n].Cells[87].Value = item["cobrado_may"].ToString();
                    listaSaldos.Rows[n].Cells[88].Value = item["cobrado_jun"].ToString();
                    listaSaldos.Rows[n].Cells[89].Value = item["cobrado_jul"].ToString();
                    listaSaldos.Rows[n].Cells[90].Value = item["cobrado_ago"].ToString();
                    listaSaldos.Rows[n].Cells[91].Value = item["cobrado_sep"].ToString();
                    listaSaldos.Rows[n].Cells[92].Value = item["cobrado_oct"].ToString();
                    listaSaldos.Rows[n].Cells[93].Value = item["cobrado_nov"].ToString();
                    listaSaldos.Rows[n].Cells[94].Value = item["cobrado_dic"].ToString();
                    listaSaldos.Rows[n].Cells[95].Value = item["fecha_cobro_ene"].ToString();
                    listaSaldos.Rows[n].Cells[96].Value = item["fecha_cobro_feb"].ToString();
                    listaSaldos.Rows[n].Cells[97].Value = item["fecha_cobro_mar"].ToString();
                    listaSaldos.Rows[n].Cells[98].Value = item["fecha_cobro_abr"].ToString();
                    listaSaldos.Rows[n].Cells[99].Value = item["fecha_cobro_may"].ToString();
                    listaSaldos.Rows[n].Cells[100].Value = item["fecha_cobro_jun"].ToString();
                    listaSaldos.Rows[n].Cells[101].Value = item["fecha_cobro_jul"].ToString();
                    listaSaldos.Rows[n].Cells[102].Value = item["fecha_cobro_ago"].ToString();
                    listaSaldos.Rows[n].Cells[103].Value = item["fecha_cobro_sep"].ToString();
                    listaSaldos.Rows[n].Cells[104].Value = item["fecha_cobro_oct"].ToString();
                    listaSaldos.Rows[n].Cells[105].Value = item["fecha_cobro_nov"].ToString();
                    listaSaldos.Rows[n].Cells[106].Value = item["fecha_cobro_dic"].ToString();
                    listaSaldos.Rows[n].Cells[107].Value = item["esquema_ene"].ToString();
                    listaSaldos.Rows[n].Cells[108].Value = item["esquema_feb"].ToString();
                    listaSaldos.Rows[n].Cells[109].Value = item["esquema_mar"].ToString();
                    listaSaldos.Rows[n].Cells[110].Value = item["esquema_abr"].ToString();
                    listaSaldos.Rows[n].Cells[111].Value = item["esquema_may"].ToString();
                    listaSaldos.Rows[n].Cells[112].Value = item["esquema_jun"].ToString();
                    listaSaldos.Rows[n].Cells[113].Value = item["esquema_jul"].ToString();
                    listaSaldos.Rows[n].Cells[114].Value = item["esquema_ago"].ToString();
                    listaSaldos.Rows[n].Cells[115].Value = item["esquema_sep"].ToString();
                    listaSaldos.Rows[n].Cells[116].Value = item["esquema_oct"].ToString();
                    listaSaldos.Rows[n].Cells[117].Value = item["esquema_nov"].ToString();
                    listaSaldos.Rows[n].Cells[118].Value = item["esquema_dic"].ToString();
                    listaSaldos.Rows[n].Cells[119].Value = item["fecha_com_ene"].ToString();
                    listaSaldos.Rows[n].Cells[120].Value = item["fecha_com_feb"].ToString();
                    listaSaldos.Rows[n].Cells[121].Value = item["fecha_com_mar"].ToString();
                    listaSaldos.Rows[n].Cells[122].Value = item["fecha_com_abr"].ToString();
                    listaSaldos.Rows[n].Cells[123].Value = item["fecha_com_may"].ToString();
                    listaSaldos.Rows[n].Cells[124].Value = item["fecha_com_jun"].ToString();
                    listaSaldos.Rows[n].Cells[125].Value = item["fecha_com_jul"].ToString();
                    listaSaldos.Rows[n].Cells[126].Value = item["fecha_com_ago"].ToString();
                    listaSaldos.Rows[n].Cells[127].Value = item["fecha_com_sep"].ToString();
                    listaSaldos.Rows[n].Cells[128].Value = item["fecha_com_oct"].ToString();
                    listaSaldos.Rows[n].Cells[129].Value = item["fecha_com_nov"].ToString();
                    listaSaldos.Rows[n].Cells[130].Value = item["fecha_com_dic"].ToString();
                    listaSaldos.Rows[n].Cells[131].Value = item["monto_pautado"].ToString();
                    listaSaldos.Rows[n].Cells[132].Value = item["monto_facturado"].ToString();
                    listaSaldos.Rows[n].Cells[133].Value = item["monto_cobrado"].ToString();
                    listaSaldos.Rows[n].Cells[134].Value = item["porcentaje_pautado"].ToString();
                    listaSaldos.Rows[n].Cells[135].Value = item["porcentaje_facturado"].ToString();
                    listaSaldos.Rows[n].Cells[136].Value = item["porcentaje_cobrado"].ToString();
                }
                con.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
