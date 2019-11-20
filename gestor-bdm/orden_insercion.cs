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
    public partial class orden_insercion : MetroFramework.Forms.MetroForm
    {
        public orden_insercion()
        {
            InitializeComponent();
        }

        private void orden_insercion_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
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

                            MySqlCommand cmd = new MySqlCommand("INSERT INTO ordenes_insercion (`fecha_ingreso` ,`folio_media` , `status_OI` , `sigla_pais` , `tipo_pauta` , `categoria`, `contrato`, `razon_social` , `nombre_comercial`, `sigla_hotel`, `sigla_hanna` , `clave_hanna` , `centro_bneficio` , `centro_beneficio_2` , `cuenta_1` , `cuenta_2` , `monto_1` , `monto_2`, `monto_pauta`, `anticipo_pauta`, `porcentaje_mkf` , `vig_desde_mkf` , `vig_hasta_mkf`  , `forma_calculo` , `monto_fijo` , `monto_fijo_iva` , `divisa` , `impuestos_oi` , `vig_monto_desde` , `vig_monto_hasta`, `transf_bancaria` , `compensacion`, `noches` , `cant_noches`,  `importe_noches`,  `ambas`, `esquema_comision`, `q` , `porcentaje_q` , `campo1` , `campo2` , `campo3` , `observaciones`, `supply_manager` , `ejecutivo_daf`, `account_manager` , `archivo` , `archivo_dos` , `archivo_tres` , `enero` , `febrero`, `marzo`, `abril`, `mayo` , `junio`, `julio` , `agosto`, `septiembre` , `octubre`, `noviembre` , `diciembre`, `anio_ene` , `anio_feb`, `anio_mar`, `anio_abr` , `anio_may` , `anio_jun` , `anio_jul`  , `anio_ago` , `anio_sep` , `anio_oct` , `anio_nov` , `anio_dic` , `monto_ene` , `monto_feb`, `monto_mar`, `monto_abr` , `monto_may` , `monto_jun` , `monto_jul`  , `monto_ago` , `monto_sep` , `monto_oct` , `monto_nov` , `monto_dic` , `facturado_ene` , `facturado_feb`, `facturado_mar`, `facturado_abr` , `facturado_may` , `facturado_jun` , `facturado_jul`  , `facturado_ago` , `facturado_sep` , `facturado_oct` , `facturado_nov` , `facturado_dic` , `doc_ene` , `doc_feb`, `doc_mar`, `doc_abr` , `doc_may` , `doc_jun` , `doc_jul`  , `doc_ago` , `doc_sep` , `doc_oct` , `doc_nov` , `doc_dic` , `archivo_ene` , `archivo_feb`, `archivo_mar`, `archivo_abr` , `archivo_may` , `archivo_jun` , `archivo_jul`  , `archivo_ago` , `archivo_sep` , `archivo_oct` , `archivo_nov` , `archivo_dic`, `cobrado_ene` , `cobrado_feb`, `cobrado_mar`, `cobrado_abr` , `cobrado_may` , `cobrado_jun` , `cobrado_jul`  , `cobrado_ago` , `cobrado_sep` , `cobrado_oct` , `cobrado_nov` , `cobrado_dic` , `fecha_cobro_ene` , `fecha_cobro_feb`, `fecha_cobro_mar`, `fecha_cobro_abr` , `fecha_cobro_may` , `fecha_cobro_jun` , `fecha_cobro_jul`  , `fecha_cobro_ago` , `fecha_cobro_sep` , `fecha_cobro_oct` , `fecha_cobro_nov` , `fecha_cobro_dic`  , `esquema_ene` , `esquema_feb`, `esquema_mar`, `esquema_abr` , `esquema_may` , `esquema_jun` , `esquema_jul`  , `esquema_ago` , `esquema_sep` , `esquema_oct` , `esquema_nov` , `esquema_dic` , `fecha_com_ene` , `fecha_com_feb`, `fecha_com_mar`, `fecha_com_abr` , `fecha_com_may` , `fecha_com_jun` , `fecha_com_jul`  , `fecha_com_ago` , `fecha_com_sep` , `fecha_com_oct` , `fecha_com_nov` , `fecha_com_dic` , `monto_pautado` , `monto_facturado` , `monto_cobrado` , `porcentaje_pautado` , `porcentaje_facturado` , `porcentaje_cobrado` , `tipo_op` , `id_maestro_op` , `numero_cuenta_op`, `cuenta_op` , `razon_op`) VALUES ('" + dateIngreso.Value.ToString("yyyy-MM-dd") + "','" + tMedia.Text + "','" + textStatusOI.Text + "','" + textPais.Text + "','" + labelPauta.Text + "','" + comboCategoria.Text + "','" + comboContrato.Text + "','" + comboRazon.Text + "','" + textComercial.Text + "','" + labelHotel.Text + "','" + tSiglas.Text + "','" + tHann.Text + "','" + nombreBeneficio.Text + "','" + nombreBeneficio2.Text + "','" + textMonto.Text + "','" + textMonto2.Text + "','" + cant1.Text + "','" + cant2.Text + "','" + 0 + "','" + 0 + "','" + comboPorcentajeMKF.Text + "','" + date_mkf_desde + "','" + date_mkf_hasta + "','" + forma_calculo + "','" + tMonto.Text + "','" + tMontoIVA.Text + "','" + comboDivisa.Text + "','" + comboNacional.Text + "','" + date_monto_desde + "','" + date_monto_hasta + "','" + transfer_bancaria + "','" + compensacion + "','" + noches + "','" + cantNoches.Text + "','" + importeNoches.Text + "','" + ambos + "','" + comboComisiones.Text + "','" + comboQ.Text + "','" + comboQPorcentaje.Text + "','" + combo1.Text + "','" + combo2.Text + "','" + combo3.Text + "','" + textObservaciones.Text + "','" + comboSupply.Text + "','" + comboEjecutivoDAF.Text + "','" + comboAccount.Text + "','" + nombreUno.Text + "','" + nombreDos.Text + "','" + nombreTres.Text + "','" + senero + "','" + sfebrero + "','" + smarzo + "','" + sabril + "','" + smayo + "','" + sjunio + "','" + sjulio + "','" + sagosto + "','" + sseptiembre + "','" + soctubre + "','" + snoviembre + "','" + sdiciembre + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + montoEne.Text + "','" + montoFeb.Text + "','" + montoMar.Text + "','" + montoAbr.Text + "','" + montoMayo.Text + "','" + montoJun.Text + "','" + montoJul.Text + "','" + montoAgo.Text + "','" + montoSep.Text + "','" + montoOct.Text + "','" + montoNov.Text + "','" + montoDic.Text + "','" + facturadoEne.Text + "','" + facturadoFeb.Text + "','" + facturadoMar.Text + "','" + facturadoAbr.Text + "','" + facturadoMay.Text + "','" + facturadoJun.Text + "','" + facturadoJul.Text + "','" + facturadoAgo.Text + "','" + facturadoSep.Text + "','" + facturadoOct.Text + "','" + facturadoNov.Text + "','" + facturadoDic.Text + "','" + textDocEne.Text + "','" + textDocFeb.Text + "','" + textDocMar.Text + "','" + textDocAbr.Text + "','" + textDocMay.Text + "','" + textDocJun.Text + "','" + textDocJul.Text + "','" + textDocAgo.Text + "','" + textDocSep.Text + "','" + textDocOct.Text + "','" + textDocNov.Text + "','" + textDocDic.Text + "','" + NombreArcEne + "','" + NombreArcFeb + "','" + NombreArcMar + "','" + NombreArcAbr + "','" + NombreArcMay + "','" + NombreArcJun + "','" + NombreArcJul + "','" + NombreArcAgo + "','" + NombreArcSep + "','" + NombreArcOct + "','" + NombreArcNov + "','" + NombreArcDic + "','" + cobradoEne.Text + "','" + cobradoFeb.Text + "','" + cobradoMar.Text + "','" + cobradoAbr.Text + "','" + cobradoMay.Text + "','" + cobradoJun.Text + "','" + cobradoJul.Text + "','" + cobradoAgo.Text + "','" + cobradoSep.Text + "','" + cobradoOct.Text + "','" + cobradoNov.Text + "','" + cobradoDic.Text + "','" + dateEne.Value.ToString("yyyy-MM-dd") + "','" + dateFeb.Value.ToString("yyyy-MM-dd") + "','" + dateMar.Value.ToString("yyyy-MM-dd") + "','" + dateAbr.Value.ToString("yyyy-MM-dd") + "','" + dateMay.Value.ToString("yyyy-MM-dd") + "','" + dateJun.Value.ToString("yyyy-MM-dd") + "','" + dateJul.Value.ToString("yyyy-MM-dd") + "','" + dateAgo.Value.ToString("yyyy-MM-dd") + "','" + dateSep.Value.ToString("yyyy-MM-dd") + "','" + dateOct.Value.ToString("yyyy-MM-dd") + "','" + dateNov.Value.ToString("yyyy-MM-dd") + "','" + dateDic.Value.ToString("yyyy-MM-dd") + "','" + esquemaEne.Text + "','" + esquemaFeb.Text + "','" + esquemaMar.Text + "','" + esquemaAbr.Text + "','" + esquemaMay.Text + "','" + esquemaJun.Text + "','" + esquemaJul.Text + "','" + esquemaAgo.Text + "','" + esquemaSep.Text + "','" + esquemaOct.Text + "','" + esquemaNov.Text + "','" + esquemaDic.Text + "','" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "','" + cantMonto.Text + "','" + cantFacturado.Text + "','" + cantCobrado.Text + "','" + porcentajeMonto.Text + "','" + porcentajeFacturado.Text + "','" + porcentajeCobrado.Text + "','" + comboOp.Text + "','" + textID.Text + "','" + comboCuenta.Text + "','" + comboCuentaOp.Text + "','" + comboRazonOp.Text + "' )", con);
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

                                MySqlCommand cmd = new MySqlCommand("INSERT INTO ordenes_insercion (`fecha_ingreso` ,`folio_media` , `status_OI` , `sigla_pais` , `tipo_pauta` , `categoria`, `contrato`, `razon_social` , `nombre_comercial`, `sigla_hotel`, `sigla_hanna` , `clave_hanna` , `centro_bneficio` , `centro_beneficio_2` , `cuenta_1` , `cuenta_2` , `monto_1` , `monto_2`, `monto_pauta`, `anticipo_pauta`, `porcentaje_mkf` , `vig_desde_mkf` , `vig_hasta_mkf`  , `forma_calculo` , `monto_fijo` , `monto_fijo_iva` , `divisa` , `impuestos_oi` , `vig_monto_desde` , `vig_monto_hasta`, `transf_bancaria` , `compensacion`, `noches` , `cant_noches`,  `importe_noches`,  `ambas`, `esquema_comision`, `q` , `porcentaje_q` , `campo1` , `campo2` , `campo3` , `observaciones`, `supply_manager` , `ejecutivo_daf`, `account_manager` , `archivo` , `archivo_dos` , `archivo_tres` , `enero` , `febrero`, `marzo`, `abril`, `mayo` , `junio`, `julio` , `agosto`, `septiembre` , `octubre`, `noviembre` , `diciembre`, `anio_ene` , `anio_feb`, `anio_mar`, `anio_abr` , `anio_may` , `anio_jun` , `anio_jul`  , `anio_ago` , `anio_sep` , `anio_oct` , `anio_nov` , `anio_dic` , `monto_ene` , `monto_feb`, `monto_mar`, `monto_abr` , `monto_may` , `monto_jun` , `monto_jul`  , `monto_ago` , `monto_sep` , `monto_oct` , `monto_nov` , `monto_dic` , `facturado_ene` , `facturado_feb`, `facturado_mar`, `facturado_abr` , `facturado_may` , `facturado_jun` , `facturado_jul`  , `facturado_ago` , `facturado_sep` , `facturado_oct` , `facturado_nov` , `facturado_dic` , `doc_ene` , `doc_feb`, `doc_mar`, `doc_abr` , `doc_may` , `doc_jun` , `doc_jul`  , `doc_ago` , `doc_sep` , `doc_oct` , `doc_nov` , `doc_dic` , `archivo_ene` , `archivo_feb`, `archivo_mar`, `archivo_abr` , `archivo_may` , `archivo_jun` , `archivo_jul`  , `archivo_ago` , `archivo_sep` , `archivo_oct` , `archivo_nov` , `archivo_dic`, `cobrado_ene` , `cobrado_feb`, `cobrado_mar`, `cobrado_abr` , `cobrado_may` , `cobrado_jun` , `cobrado_jul`  , `cobrado_ago` , `cobrado_sep` , `cobrado_oct` , `cobrado_nov` , `cobrado_dic` , `fecha_cobro_ene` , `fecha_cobro_feb`, `fecha_cobro_mar`, `fecha_cobro_abr` , `fecha_cobro_may` , `fecha_cobro_jun` , `fecha_cobro_jul`  , `fecha_cobro_ago` , `fecha_cobro_sep` , `fecha_cobro_oct` , `fecha_cobro_nov` , `fecha_cobro_dic`  , `esquema_ene` , `esquema_feb`, `esquema_mar`, `esquema_abr` , `esquema_may` , `esquema_jun` , `esquema_jul`  , `esquema_ago` , `esquema_sep` , `esquema_oct` , `esquema_nov` , `esquema_dic` , `fecha_com_ene` , `fecha_com_feb`, `fecha_com_mar`, `fecha_com_abr` , `fecha_com_may` , `fecha_com_jun` , `fecha_com_jul`  , `fecha_com_ago` , `fecha_com_sep` , `fecha_com_oct` , `fecha_com_nov` , `fecha_com_dic` , `monto_pautado` , `monto_facturado` , `monto_cobrado` , `porcentaje_pautado` , `porcentaje_facturado` , `porcentaje_cobrado` , `tipo_op` , `id_maestro_op` , `numero_cuenta_op`, `cuenta_op` , `razon_op`) VALUES ('" + dateIngreso.Value.ToString("yyyy-MM-dd") + "','" + tMedia.Text + "','" + textStatusOI.Text + "','" + textPais.Text + "','" + labelPauta.Text + "','" + comboCategoria.Text + "','" + comboContrato.Text + "','" + comboRazon.Text + "','" + textComercial.Text + "','" + labelHotel.Text + "','" + tSiglas.Text + "','" + tHann.Text + "','" + nombreBeneficio.Text + "','" + nombreBeneficio2.Text + "','" + textMonto.Text + "','" + textMonto2.Text + "','" + cant1.Text + "','" + cant2.Text + "','" + 0 + "','" + 0 + "','" + comboPorcentajeMKF.Text + "','" + date_mkf_desde + "','" + date_mkf_hasta + "','" + forma_calculo + "','" + tMonto.Text + "','" + tMontoIVA.Text + "','" + comboDivisa.Text + "','" + comboNacional.Text + "','" + date_monto_desde + "','" + date_monto_hasta + "','" + transfer_bancaria + "','" + compensacion + "','" + noches + "','" + cantNoches.Text + "','" + importeNoches.Text + "','" + ambos + "','" + comboComisiones.Text + "','" + comboQ.Text + "','" + comboQPorcentaje.Text + "','" + combo1.Text + "','" + combo2.Text + "','" + combo3.Text + "','" + textObservaciones.Text + "','" + comboSupply.Text + "','" + comboEjecutivoDAF.Text + "','" + comboAccount.Text + "','" + nombreUno.Text + "','" + nombreDos.Text + "','" + nombreTres.Text + "','" + senero + "','" + sfebrero + "','" + smarzo + "','" + sabril + "','" + smayo + "','" + sjunio + "','" + sjulio + "','" + sagosto + "','" + sseptiembre + "','" + soctubre + "','" + snoviembre + "','" + sdiciembre + "','" + tEnero.Text + "','" + tFebrero.Text + "','" + tMarzo.Text + "','" + tAbril.Text + "','" + tMayo.Text + "','" + tJunio.Text + "','" + tJulio.Text + "','" + tAgosto.Text + "','" + tSeptiembre.Text + "','" + tOctubre.Text + "','" + tNoviembre.Text + "','" + tDiciembre.Text + "','" + montoEne.Text + "','" + montoFeb.Text + "','" + montoMar.Text + "','" + montoAbr.Text + "','" + montoMayo.Text + "','" + montoJun.Text + "','" + montoJul.Text + "','" + montoAgo.Text + "','" + montoSep.Text + "','" + montoOct.Text + "','" + montoNov.Text + "','" + montoDic.Text + "','" + facturadoEne.Text + "','" + facturadoFeb.Text + "','" + facturadoMar.Text + "','" + facturadoAbr.Text + "','" + facturadoMay.Text + "','" + facturadoJun.Text + "','" + facturadoJul.Text + "','" + facturadoAgo.Text + "','" + facturadoSep.Text + "','" + facturadoOct.Text + "','" + facturadoNov.Text + "','" + facturadoDic.Text + "','" + textDocEne.Text + "','" + textDocFeb.Text + "','" + textDocMar.Text + "','" + textDocAbr.Text + "','" + textDocMay.Text + "','" + textDocJun.Text + "','" + textDocJul.Text + "','" + textDocAgo.Text + "','" + textDocSep.Text + "','" + textDocOct.Text + "','" + textDocNov.Text + "','" + textDocDic.Text + "','" + NombreArcEne + "','" + NombreArcFeb + "','" + NombreArcMar + "','" + NombreArcAbr + "','" + NombreArcMay + "','" + NombreArcJun + "','" + NombreArcJul + "','" + NombreArcAgo + "','" + NombreArcSep + "','" + NombreArcOct + "','" + NombreArcNov + "','" + NombreArcDic + "','" + cobradoEne.Text + "','" + cobradoFeb.Text + "','" + cobradoMar.Text + "','" + cobradoAbr.Text + "','" + cobradoMay.Text + "','" + cobradoJun.Text + "','" + cobradoJul.Text + "','" + cobradoAgo.Text + "','" + cobradoSep.Text + "','" + cobradoOct.Text + "','" + cobradoNov.Text + "','" + cobradoDic.Text + "','" + dateEne.Value.ToString("yyyy-MM-dd") + "','" + dateFeb.Value.ToString("yyyy-MM-dd") + "','" + dateMar.Value.ToString("yyyy-MM-dd") + "','" + dateAbr.Value.ToString("yyyy-MM-dd") + "','" + dateMay.Value.ToString("yyyy-MM-dd") + "','" + dateJun.Value.ToString("yyyy-MM-dd") + "','" + dateJul.Value.ToString("yyyy-MM-dd") + "','" + dateAgo.Value.ToString("yyyy-MM-dd") + "','" + dateSep.Value.ToString("yyyy-MM-dd") + "','" + dateOct.Value.ToString("yyyy-MM-dd") + "','" + dateNov.Value.ToString("yyyy-MM-dd") + "','" + dateDic.Value.ToString("yyyy-MM-dd") + "','" + esquemaEne.Text + "','" + esquemaFeb.Text + "','" + esquemaMar.Text + "','" + esquemaAbr.Text + "','" + esquemaMay.Text + "','" + esquemaJun.Text + "','" + esquemaJul.Text + "','" + esquemaAgo.Text + "','" + esquemaSep.Text + "','" + esquemaOct.Text + "','" + esquemaNov.Text + "','" + esquemaDic.Text + "','" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "','" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "','" + cantMonto.Text + "','" + cantFacturado.Text + "','" + cantCobrado.Text + "','" + porcentajeMonto.Text + "','" + porcentajeFacturado.Text + "','" + porcentajeCobrado.Text + "','" + comboOp.Text + "','" + textID.Text + "','" + comboCuenta.Text + "','" + comboCuentaOp.Text + "','" + comboRazonOp.Text + "' )", con);
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

        private void edit_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("UPDATE `ordenes_insercion` SET `folio_media`='" + tMedia.Text + "',`status_OI`='" + textStatusOI.Text + "',`sigla_pais`='" + textPais.Text + "',`tipo_pauta`='" + labelPauta.Text + "',`categoria`='" + comboCategoria.Text + "',`contrato`='" + comboContrato.Text + "',`razon_social`='" + comboRazon.Text + "',`nombre_comercial`='" + textComercial.Text + "',`sigla_hotel`='" + labelHotel.Text + "',`sigla_hanna`='" + tSiglas.Text + "',`clave_hanna`='" + tHann.Text + "',`centro_bneficio`='" + nombreBeneficio.Text + "',`centro_bneficio_2`='" + nombreBeneficio2.Text + "',`cuenta_1`='" + textMonto.Text + "',`cuenta_2`='" + textMonto2.Text + "',`monto_1`='" + cant1.Text + "',`monto_2`='" + cant2.Text + "',`anticipo_pauta`='" + textAnticipo.Text + "',`porcentaje_mkf`='" + comboPorcentajeMKF.Text + "',`vig_desde_mkf`='" + date_mkf_desde + "',`vig_hasta_mkf`='" + date_mkf_hasta + "',`monto_fijo`='" + tMonto.Text + "',`monto_fijo_iva`='" + tMontoIVA.Text + "',`divisa`='" + comboDivisa.Text + "',`impuestos_oi`='" + comboNacional.Text + "',`vig_monto_desde`='" + date_monto_desde + "',`vig_monto_hasta`='" + date_monto_hasta + "', `transf_bancaria`='" + transfer_bancaria + "',`compensacion`='" + compensacion + "', `noches`='" + noches + "', `cant_noches`='" + cantNoches.Text + "', `importe_noches`='" + importeNoches.Text + "', `ambas`='" + ambos + "', `esquema_comision`='" + comboComisiones.Text + "', `q`='" + comboQ.Text + "', `porcentaje_q`='" + comboQPorcentaje.Text + "', `campo1`='" + combo1.Text + "', `campo2`='" + combo2.Text + "', `campo3`='" + combo3.Text + "', `observaciones`='" + textObservaciones.Text + "', `supply_manager`='" + comboSupply.Text + "',`ejecutivo_daf`='" + comboEjecutivoDAF.Text + "',`account_manager`='" + comboAccount.Text + "',`archivo`='" + nombreUno.Text + "',`archivo_dos`='" + nombreDos.Text + "',`archivo_tres`='" + nombreTres.Text + "',`enero`='" + senero + "',`febrero`='" + sfebrero + "',`marzo`='" + smarzo + "',`abril`='" + sabril + "',`mayo`='" + smayo + "',`junio`='" + sjulio + "',`julio`='" + sjulio + "',`agosto`='" + sagosto + "',`septiembre`='" + sseptiembre + "',`octubre`='" + soctubre + "',`noviembre`='" + snoviembre + "',`diciembre`='" + sdiciembre + "',`anio_ene`='" + tEnero.Text + "',`anio_feb`='" + tFebrero.Text + "',`anio_mar`='" + tMarzo.Text + "',`anio_abr`='" + tAbril.Text + "',`anio_may`='" + tMayo.Text + "',`anio_jun`='" + tJunio.Text + "',`anio_jul`='" + tJulio.Text + "',`anio_ago`='" + tAgosto.Text + "',`anio_sep`='" + tSeptiembre.Text + "',`anio_oct`='" + tOctubre.Text + "',`anio_nov`='" + tNoviembre.Text + "',`anio_dic`='" + tDiciembre.Text + "',`monto_ene`='" + montoEne.Text + "',`monto_feb`='" + montoFeb.Text + "',`monto_mar`='" + montoMar.Text + "',`monto_abr`='" + montoAbr.Text + "',`monto_may`='" + montoMayo.Text + "',`monto_jun`='" + montoJun.Text + "',`monto_jul`='" + montoJul.Text + "',`monto_ago`='" + montoAgo.Text + "',`monto_sep`='" + montoSep.Text + "',`monto_oct`='" + montoOct.Text + "',`monto_nov`='" + montoNov.Text + "',`monto_dic`='" + montoDic.Text + "',`facturado_ene`='" + facturadoEne.Text + "',`facturado_feb`='" + facturadoFeb.Text + "',`facturado_mar`='" + facturadoMar.Text + "',`facturado_abr`='" + facturadoAbr.Text + "',`facturado_may`='" + facturadoMay.Text + "',`facturado_jun`='" + facturadoJun.Text + "',`facturado_jul`='" + facturadoJul.Text + "',`facturado_ago`='" + facturadoAgo.Text + "',`facturado_sep`='" + facturadoSep.Text + "',`facturado_oct`='" + facturadoOct.Text + "',`facturado_nov`='" + facturadoNov.Text + "',`facturado_dic`='" + facturadoDic.Text + "',`doc_ene`='" + textDocEne.Text + "',`doc_feb`='" + textDocFeb.Text + "',`doc_mar`='" + textDocMar.Text + "',`doc_abr`='" + textDocAbr.Text + "',`doc_may`='" + textDocMay.Text + "',`doc_jun`='" + textDocJun.Text + "',`doc_jul`='" + textDocJul.Text + "',`doc_ago`='" + textDocAgo.Text + "',`doc_sep`='" + textDocSep.Text + "',`doc_oct`='" + textDocOct.Text + "',`doc_nov`='" + textDocNov.Text + "',`doc_dic`='" + textDocDic.Text + "',`archivo_ene`='" + NombreArcEne + "',`archivo_feb`='" + NombreArcFeb + "',`archivo_mar`='" + NombreArcMar + "',`archivo_abr`='" + NombreArcAbr + "',`archivo_may`='" + NombreArcMay + "',`archivo_jun`='" + NombreArcJun + "',`archivo_jul`='" + NombreArcJul + "',`archivo_ago`='" + NombreArcAgo + "',`archivo_sep`='" + NombreArcSep + "',`archivo_oct`='" + NombreArcOct + "',`archivo_nov`='" + NombreArcNov + "',`archivo_dic`='" + NombreArcDic + "',`cobrado_ene`='" + cobradoEne.Text + "',`cobrado_feb`='" + cobradoFeb.Text + "',`cobrado_mar`='" + cobradoMar.Text + "',`cobrado_abr`='" + cobradoAbr.Text + "',`cobrado_may`='" + cobradoMay.Text + "',`cobrado_jun`='" + cobradoJun.Text + "',`cobrado_jul`='" + cobradoJul.Text + "',`cobrado_ago`='" + cobradoAgo.Text + "',`cobrado_sep`='" + cobradoSep.Text + "',`cobrado_oct`='" + cobradoOct.Text + "',`cobrado_nov`='" + cobradoNov.Text + "',`cobrado_dic`='" + cobradoDic.Text + "',`fecha_cobro_ene`='" + dateEne.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_feb`='" + dateFeb.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_mar`='" + dateMar.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_abr`='" + dateAbr.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_may`='" + dateMay.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_jun`='" + dateJun.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_jul`='" + dateJul.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_ago`='" + dateAgo.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_sep`='" + dateSep.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_oct`='" + dateOct.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_nov`='" + dateNov.Value.ToString("yyyy-MM-dd") + "',`fecha_cobro_dic`='" + dateDic.Value.ToString("yyyy-MM-dd") + "',`esquema_ene`='" + esquemaEne.Text + "',`esquema_feb`='" + esquemaFeb.Text + "',`esquema_mar`='" + esquemaMar.Text + "',`esquema_abr`='" + esquemaAbr.Text + "',`esquema_may`='" + esquemaMay.Text + "',`esquema_jun`='" + esquemaJun.Text + "',`esquema_jul`='" + esquemaJul.Text + "',`esquema_ago`='" + esquemaAgo.Text + "',`esquema_sep`='" + esquemaSep.Text + "',`esquema_oct`='" + esquemaOct.Text + "',`esquema_nov`='" + esquemaNov.Text + "',`esquema_dic`='" + esquemaDic.Text + "',`fecha_com_ene`='" + esquemaDateEne.Value.ToString("yyyy-MM-dd") + "',`fecha_com_feb`='" + esquemaDateFeb.Value.ToString("yyyy-MM-dd") + "',`fecha_com_mar`='" + esquemaDateMar.Value.ToString("yyyy-MM-dd") + "',`fecha_com_abr`='" + esquemaDateAbr.Value.ToString("yyyy-MM-dd") + "',`fecha_com_may`='" + esquemaDateMay.Value.ToString("yyyy-MM-dd") + "',`fecha_com_jun`='" + esquemaDateJun.Value.ToString("yyyy-MM-dd") + "',`fecha_com_jul`='" + esquemaDateJul.Value.ToString("yyyy-MM-dd") + "',`fecha_com_ago`='" + esquemaDateAgo.Value.ToString("yyyy-MM-dd") + "',`fecha_com_sep`='" + esquemaDateSep.Value.ToString("yyyy-MM-dd") + "',`fecha_com_oct`='" + esquemaDateOct.Value.ToString("yyyy-MM-dd") + "',`fecha_com_nov`='" + esquemaDateNov.Value.ToString("yyyy-MM-dd") + "',`fecha_com_dic`='" + esquemaDateDic.Value.ToString("yyyy-MM-dd") + "',`monto_pautado`='" + cantMonto.Text + "',`monto_facturado`='" + cantFacturado.Text + "',`monto_cobrado`='" + cantCobrado.Text + "',`porcentaje_pautado`='" + porcentajeMonto.Text + "',`porcentaje_facturado`='" + porcentajeFacturado.Text + "',`porcentaje_cobrado`='" + porcentajeCobrado.Text + "',`tipo_op`='" + comboOp.Text + "',`id_maestro_op`='" + textID.Text + "',`numero_cuenta_op`='" + comboCuenta.Text + "',`cuenta_op`='" + comboCuentaOp.Text + "',`razon_op`='" + comboCuentaOp.Text + "' WHERE id_ordenes = '" + id.Text + "'", con);
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

        private void delete_Click(object sender, EventArgs e)
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

        private void clean_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void explor_Click(object sender, EventArgs e)
        {
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
        }

        private void visualizar_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreUno.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void exploreDos_Click(object sender, EventArgs e)
        {
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

        private void explore_2_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreDos.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void exploreTres_Click(object sender, EventArgs e)
        {
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

        private void explore_3_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreTres.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void exploreEne_Click(object sender, EventArgs e)
        {
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
        }

        private void lookEne_Click(object sender, EventArgs e)
        {
            Variables.Ruta_pdf = nombreUno.Text;

            viewer ventana = new viewer();
            ventana.Show();
        }

        private void exploreFeb_Click(object sender, EventArgs e)
        {
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
        }

        private void lookFeb_Click(object sender, EventArgs e)
        {

        }

        private void exploreMar_Click(object sender, EventArgs e)
        {
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
        }

        private void lookMar_Click(object sender, EventArgs e)
        {

        }

        private void exploreAbr_Click(object sender, EventArgs e)
        {
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
            NombreArcAbr = tMedia.Text + "-" + archivoAbr.Text;s
        }

        private void lookAbr_Click(object sender, EventArgs e)
        {

        }

        private void exploreMay_Click(object sender, EventArgs e)
        {
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
        }

        private void lookMay_Click(object sender, EventArgs e)
        {

        }

        private void exploreJun_Click(object sender, EventArgs e)
        {
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
        }

        private void lookJun_Click(object sender, EventArgs e)
        {

        }

        private void exploreJul_Click(object sender, EventArgs e)
        {
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
        }

        private void lookJul_Click(object sender, EventArgs e)
        {

        }

        private void exploreAgo_Click(object sender, EventArgs e)
        {
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
        }

        private void lookAgo_Click(object sender, EventArgs e)
        {

        }

        private void exploreSep_Click(object sender, EventArgs e)
        {
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
        }

        private void lookSep_Click(object sender, EventArgs e)
        {

        }

        private void exploreOct_Click(object sender, EventArgs e)
        {
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
        }

        private void lookOct_Click(object sender, EventArgs e)
        {

        }

        private void exploreNov_Click(object sender, EventArgs e)
        {
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
        }

        private void lookNov_Click(object sender, EventArgs e)
        {

        }

        private void exploreDic_Click(object sender, EventArgs e)
        {
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
        }

        private void lookDic_Click(object sender, EventArgs e)
        {

        }

        private void sumas_Click(object sender, EventArgs e)
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

        private void calculo_Click(object sender, EventArgs e)
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

        private void exportExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void all_Click(object sender, EventArgs e)
        {
            listaSaldos.Rows.Clear();
            listaSaldos.Refresh();

            llenar();
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
    }
}
