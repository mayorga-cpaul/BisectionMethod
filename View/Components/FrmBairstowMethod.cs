using NumericMethod.Services.Interfaces;
using System.Windows.Forms;
using View.Utils;
using static NumericMethod.Services.Util.Bairstow;

namespace View.Components
{
    public partial class FrmBairstowMethod : Form
    {
        private readonly IAproximateMethods aproximateMethods;
        public FrmBairstowMethod(IAproximateMethods aproximateMethods)
        {
            InitializeComponent();
            this.aproximateMethods = aproximateMethods;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            dtgData.DataSource = null;

            var data = aproximateMethods.BairstowMethod(BairstowCache.Coeficients.ToArray(), double.Parse(txtError.Text)
                , int.Parse(txtIteration.Text), double.Parse(txtSa.Text), double.Parse(txtSb.Text));


            List<IterationResult> iterationResults= new();

            foreach (var item in data)
            {
                iterationResults.AddRange(item);
            }

            // Definimos las columnas del DataGridView manualmente.
            dtgData.Columns.Add("iterR", "Iter R");
            dtgData.Columns.Add("iterS", "Iter S");
            dtgData.Columns.Add("iterRError", "Iter R Error");
            dtgData.Columns.Add("iterSError", "Iter S Error");
            dtgData.Columns.Add("deltaR", "Delta R");
            dtgData.Columns.Add("deltaS", "Delta S");
            dtgData.Columns.Add("dataRelevant", "Datos Relevantes");
            dtgData.Columns.Add("rootFound", "Raíz Encontrada");
            dtgData.Columns.Add("allRootsFound", "Todas las Raíces Encontradas");
            dtgData.Columns.Add("maxIterationsExceeded", "Máx. Iteraciones Excedidas");

            // Agregamos los datos al DataGridView.
            foreach (var item in iterationResults)
            {
                dtgData.Rows.Add(
                    item.iterR,
                    item.iterS,
                    item.iterRError,
                    item.iterSError,
                    item.deltaR,
                    item.deltaS,
                    item.dataRelevant,
                    item.rootFound,
                    item.allRootsFound,
                    item.maxIterationsExceeded
                );
            }
        }
    }
}
