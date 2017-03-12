using System;
using System.Windows.Forms;

namespace OO_Plus_Events
{
	public partial class MainForm : Form
	{
		private CountManager _countManager;
		
		public MainForm()
		{
			InitializeComponent();
			_countManager = new CountManager();
			_countManager.SeventyPercentEvent += OnReach70Percent;
			_countManager.OneHundredPercentEvent += OnReach100Percent;
		}

		private void btnCount_Click(object sender, EventArgs e)
		{
			pbCounter.Value = _countManager.Count();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			pbCounter.Value = 0;
		}

		private void OnReach70Percent(object sender, EventArgs e)
		{
			MessageBox.Show("70% reached.", "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void OnReach100Percent(object sender, EventArgs e)
		{
			MessageBox.Show("100% reached.", "Maximum limit reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
