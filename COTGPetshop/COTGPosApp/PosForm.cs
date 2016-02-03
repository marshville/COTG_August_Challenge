using COTGPetshop.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COTGPetshop.PosApp
{
    public partial class PosForm : Form
    {
        private POSModel _model;
        public PosForm()
        {
            InitializeComponent();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            if (_model == null)
                Initialise(new POSModel());
        }

        public void Initialise(POSModel model)
        {
            _model = model;
            modelBindingSource.DataSource = _model;
            Text = POSModel.POSTitle;
            _model.Sales.ListChanged += Sales_ListChanged;
        }

        void Sales_ListChanged(object sender, ListChangedEventArgs e)
        {
            List<SaleItem> todaysSales = _model.Sales.OrderByDescending(s => s.SaleDate)
                                                      .Where(s => s.SaleDate.Date == DateTime.Today).ToList();

            salesHistory.Lines = todaysSales.Select(s => s.ToString()).ToArray();
        }

        private void animalsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            var buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn != null && e.RowIndex >= 0)
            {
                if (buttonColumn.Name.Equals("Sell", StringComparison.CurrentCultureIgnoreCase))
                {
                    IProduct product = senderGrid.Rows[e.RowIndex].DataBoundItem as IProduct;
                    if (product != null)
                    {
                       MakeSaleAsync(product);
                    }
                }
            }
        }

        private async void MakeSaleAsync(IProduct product)
        {
            _model.MakeSale(product);

            salesHistory.Lines = _model.Sales.OrderByDescending(s => s.SaleDate)
                .Where(s => s.SaleDate.Date == DateTime.Today)
                .Select(s => s.ToString()).ToArray();

            var todaysSalesTotals = await async () => {}
            {
                return _model.CalculateDailySales();
            });

            txtGrossTotal.Text = todaysSalesTotals.Gross.ToString("C");
            txtLegTotal.Text = todaysSalesTotals.LegTax.ToString("C");
            txtVatTotal.Text = todaysSalesTotals.VAT.ToString("C");
            txtNetTotal.Text = todaysSalesTotals.NetOfTax.ToString("C");
        }

    }
}
