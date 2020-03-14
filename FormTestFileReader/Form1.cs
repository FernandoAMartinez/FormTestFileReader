using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public BankFile localBankFile { get; set; }

        public CreditCardFile localCreditCardFile { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbBankFile.Visible = false;
            gbCreditCardFile.Visible = false;

            rbCreditCard.Checked = false;
            rbBank.Checked = false;

            btnProcessFile.Enabled = false;

            dgvBankHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBankDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBankTrailer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCardHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCardLot.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void gbBankFile_Enter(object sender, EventArgs e)
        {

        }

        private void tbBank_CheckedChanged(object sender, EventArgs e)
        {
            gbCreditCardFile.Visible = false;
            gbBankFile.Visible = true;

            gbBankFile.Dock = DockStyle.Fill;
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            gbBankFile.Visible = false;
            gbCreditCardFile.Visible = true;

            gbCreditCardFile.Dock = DockStyle.Fill;
        }

        private void lbSearchFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txFilePath.Text = fileDialog.FileName;
                btnProcessFile.Enabled = true;
            }
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            using (StreamReader stream = new StreamReader(txFilePath.Text))
            {
                if (rbBank.Checked)
                    ProcessBankFile(stream);
                else if (rbCreditCard.Checked)
                    ProcessCreaditCardFile(stream);
            }
        }

        private void ProcessBankFile(StreamReader stream)
        {
            localBankFile = new BankFile();
            BankHeader header = new BankHeader();
            List<BankDetail> details = new List<BankDetail>();
            BankTrailer trailer = new BankTrailer();

            string line = "";

            while (true)
            {
                line = stream.ReadLine();

                if (line.ToString().Substring(0, 2) == "00")
                {
                    header = new BankHeader()
                    {
                        TipoRegistro = line.ToString().Substring(0, 2),
                        NroPrestacion = line.ToString().Substring(2, 6),
                        Servicio = line.ToString().Substring(8, 1),
                        FechaGeneracion = line.ToString().Substring(9, 8),
                        Identificacion = line.ToString().Substring(17, 1),
                        Origen = line.ToString().Substring(18, 7),
                        ImporteTotal = "",
                        CantRegistros = ""
                    };
                }

                if (line.ToString().Substring(0, 4) == "0360" || line.ToString().Substring(0, 4) == "0370")
                {
                    BankDetail detail = new BankDetail()
                    {
                        TipoRegistro = line.ToString().Substring(0, 4),
                        Cliente = line.ToString().Substring(4, 22),
                        Cbu = line.ToString().Substring(26, 26),
                        Referencia = line.ToString().Substring(52, 15),
                        PrimerVencimiento = line.ToString().Substring(67, 8),
                        ImportePrimerVencimiento = line.ToString().Substring(75, 14),
                        SegundoVencimiento = line.ToString().Substring(89, 8),
                        ImporteSegundoVencimiento = line.ToString().Substring(97, 14),
                        TercerVencimiento = line.ToString().Substring(111, 8),
                        ImporteTercerVencimiento = line.ToString().Substring(119, 14),
                        Moneda = line.ToString().Substring(133, 1),
                        MotivoRechazo = line.ToString().Substring(134, 3)
                    };

                    details.Add(detail);
                }

                if (line.ToString().Substring(0, 2) == "99")
                {
                    trailer = new BankTrailer()
                    {
                        TipoRegistro = line.ToString().Substring(0, 2),
                        NroPrestacion = line.ToString().Substring(2, 6),
                        Servicio = line.ToString().Substring(8, 1),
                        FechaGeneracion = line.ToString().Substring(9, 8),
                        Identificacion = line.ToString().Substring(17, 1),
                        Origen = line.ToString().Substring(18, 7),
                        ImporteTotal = line.ToString().Substring(25, 14),
                        CantRegistros = line.ToString().Substring(39, 7)
                    };
                }

                if (stream.EndOfStream) break;
            }

            localBankFile = new BankFile()
            {
                Header = header,
                Details = details,
                Trailer = trailer
            };

            dgvBankHeader.DataSource = new List<BankHeader>() { localBankFile.Header };
            dgvBankDetail.DataSource = localBankFile.Details;
            dgvBankTrailer.DataSource = new List<BankTrailer> { localBankFile.Trailer };
        }

        private void ProcessCreaditCardFile(StreamReader stream)
        {
            localCreditCardFile = new CreditCardFile();
            DN151 cardHeader = new DN151();
            List<DN143> cardLots = new List<DN143>();
            string line = "";

            while (true)
            {
                line = stream.ReadLine();

                if (line.ToString().Substring(0, 5) == "07500" ||
                    line.ToString().Substring(0, 5) == "23000" ||
                    line.ToString().Substring(0, 5) == "12310" ||
                    line.ToString().Substring(0, 5) == "00730" ||
                    line.ToString().Substring(0, 5) == "29500")
                {
                    cardHeader = new DN151()
                    {
                        CodEnt = line.ToString().Substring(0, 5),
                        Sucursal = line.ToString().Substring(5, 5),
                        RegLotes = line.ToString().Substring(10, 5),
                        RegTransac = line.ToString().Substring(15, 6),
                        ImporteTotal = line.ToString().Substring(34, 12)
                    };
                }

                //Iba Aca
                ProcessCardLotMapping(stream, line);

                if (stream.EndOfStream)
                {
                    localCreditCardFile.Header = cardHeader;
                    break;
                };
            }

            dgvCardHeader.DataSource = new List<DN151>() { localCreditCardFile.Header };
            dgvCardLot.DataSource = localCreditCardFile.PaymentLots;

        }

        private void dgvCardLot_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCardLot.SelectedRows.Count == 1)
                dgvTransactions.DataSource = localCreditCardFile.PaymentLots[dgvCardLot.SelectedRows[0].Index].Transacciones;
        }

        private void ProcessCardLotMapping(StreamReader stream, string line)
        {
            if (line.ToString().Substring(0, 2) == "77")
            {
                localCreditCardFile.PaymentLots = new List<DN143>();

                DN143 cardLot = new DN143()
                {
                    CodRegistro = line.ToString().Substring(0, 2),
                    Ordenamiento = line.ToString().Substring(2, 1),
                    Plan = line.ToString().Substring(3, 2),
                    Sucursal = line.ToString().Substring(5, 5),
                    TipoCuenta = line.ToString().Substring(10, 1),
                    Movimiento = line.ToString().Substring(11, 2),
                    FechaProceso = line.ToString().Substring(26, 8),
                    Periodo = line.ToString().Substring(34, 2),
                    Vencimiento = line.ToString().Substring(36, 8),
                    Tarifa = line.ToString().Substring(44, 2),

                    Transacciones = new List<DN144>()
                };

                while (true)
                {
                    line = stream.ReadLine();

                    if (line != null)
                    {

                        if (line.ToString().Substring(0, 2) == "16")
                        {
                            DN144 transaction = new DN144()
                            {
                                CodRegistro = line.ToString().Substring(0, 2),
                                Ordenamiento = line.ToString().Substring(2, 1),
                                Sucursal = line.ToString().Substring(3, 2),
                                Tarjeta = line.ToString().Substring(5, 16),
                                Cliente = line.ToString().Substring(21, 10),
                                Importe = line.ToString().Substring(31, 12),
                                Motivo = line.ToString().Substring(43, 2),
                                Tarifa = line.ToString().Substring(45, 1)
                            };

                            cardLot.Transacciones.Add(transaction);
                        }
                        else
                        {
                            localCreditCardFile.PaymentLots.Add(cardLot);

                            ProcessCardLotMapping(stream, line);
                            //break;
                        }
                    }
                    else
                    {
                        localCreditCardFile.PaymentLots.Add(cardLot);
                        break;
                    }
                }
            }
        }
    }
}

