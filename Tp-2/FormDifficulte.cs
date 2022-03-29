using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_2
{
    public partial class FormDifficulte : Form
    {
        public delegate void TransfertInfos(int difficulte_, int nbBateaux_);
        public event TransfertInfos TransfertInfosEvent;

        int difficulte;
        int nbBateaux;

        public FormDifficulte()
        {
            InitializeComponent();
        }

        Dictionary<string, int> difficulteDict = new Dictionary<string, int>();
        BindingSource bindingSource = new BindingSource();

        public int Difficulte { get => difficulte; set => difficulte = value; }
        public int NbBateaux { get => nbBateaux; set => nbBateaux = value; }

        private void FormDifficulte_Load(object sender, EventArgs e)
        {
            difficulteDict.Add("facile", 4);
            difficulteDict.Add("intermédiare", 8);
            difficulteDict.Add("difficile", 16);
            difficulteDict.Add("extrême", 32);
            bindingSource.DataSource = difficulteDict;
            comboxDifficulte.DataSource = bindingSource;
            comboxDifficulte.DisplayMember = "key";
            comboxDifficulte.ValueMember = "value";
            comboxDifficulte.SelectedValue = difficulte;
            NUDBateaux.Value = nbBateaux;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TransfertInfosEvent(int.Parse(comboxDifficulte.SelectedValue.ToString()), (int)NUDBateaux.Value);
            Close();
        }
    }
}
