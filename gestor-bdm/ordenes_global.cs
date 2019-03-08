using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_bdm
{
    public partial class ordenes_global : Form
    {
        MySqlConnection con = new MySqlConnection(Variables.Sentencia);

        public ordenes_global()
        {
            InitializeComponent();
            llenar();
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
                    listaSaldos.Rows[n].Cells[3].Value = item["status_IO"].ToString();
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
                    listaSaldos.Rows[n].Cells[25].Value = item["tranf_bancaria"].ToString();
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
                    listaSaldos.Rows[n].Cells[0].Value = item["id_ordenes"].ToString();
                    listaSaldos.Rows[n].Cells[1].Value = item["fecha_ingreso"].ToString();
                    listaSaldos.Rows[n].Cells[2].Value = item["folio_media"].ToString();
                    listaSaldos.Rows[n].Cells[3].Value = item["status_IO"].ToString();
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
                    listaSaldos.Rows[n].Cells[25].Value = item["tranf_bancaria"].ToString();
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

        private void listaSaldos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //int n = listaSaldos.SelectedRows[0].Index;
                //.Text = listaSaldos.Rows[n].Cells[2].Value.ToString();
                //tHann.Text = listaSaldos.Rows[n].Cells[1].Value.ToString();
                //tSiglas.Text = listaSaldos.Rows[n].Cells[2].Value.ToString();
                //fecha_Pauta.Text = listaSaldos.Rows[n].Cells[3].Value.ToString();
                //tMedia.Text = listaSaldos.Rows[n].Cells[4].Value.ToString();
                //tRazon.Text = listaSaldos.Rows[n].Cells[5].Value.ToString();
                //tNombre.Text = listaSaldos.Rows[n].Cells[6].Value.ToString();
                //tMonto.Text = listaSaldos.Rows[n].Cells[7].Value.ToString();
                //comboDivisa.Text = listaSaldos.Rows[n].Cells[8].Value.ToString();
                //comboPauta.Text = listaSaldos.Rows[n].Cells[9].Value.ToString();
                //comboMarket.Text = listaSaldos.Rows[n].Cells[10].Value.ToString();
                //tAnticipo.Text = listaSaldos.Rows[n].Cells[11].Value.ToString();
                //tCobrado.Text = listaSaldos.Rows[n].Cells[12].Value.ToString();
                //tFacturado.Text = listaSaldos.Rows[n].Cells[13].Value.ToString();
                //tEnero.Text = listaSaldos.Rows[n].Cells[14].Value.ToString();
                //tFebrero.Text = listaSaldos.Rows[n].Cells[15].Value.ToString();
                //tMarzo.Text = listaSaldos.Rows[n].Cells[16].Value.ToString();
                //tAbril.Text = listaSaldos.Rows[n].Cells[17].Value.ToString();
                //tMayo.Text = listaSaldos.Rows[n].Cells[18].Value.ToString();
                //tJunio.Text = listaSaldos.Rows[n].Cells[19].Value.ToString();
                //tJulio.Text = listaSaldos.Rows[n].Cells[20].Value.ToString();
                //tAgosto.Text = listaSaldos.Rows[n].Cells[21].Value.ToString();
                //tSeptiembre.Text = listaSaldos.Rows[n].Cells[22].Value.ToString();
                //tOctubre.Text = listaSaldos.Rows[n].Cells[23].Value.ToString();
                //tNoviembre.Text = listaSaldos.Rows[n].Cells[24].Value.ToString();
                //tDiciembre.Text = listaSaldos.Rows[n].Cells[25].Value.ToString();
                //comboPago.Text = listaSaldos.Rows[n].Cells[26].Value.ToString();
                //comboAccount.Text = listaSaldos.Rows[n].Cells[27].Value.ToString();
                //comboDAF.Text = listaSaldos.Rows[n].Cells[28].Value.ToString();
                //tObservaciones.Text = listaSaldos.Rows[n].Cells[29].Value.ToString();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
        }
    }
}
