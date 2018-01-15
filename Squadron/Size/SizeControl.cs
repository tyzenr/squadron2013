using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SquadronAddIns.Default.Utility;
using Squadron;
using Microsoft.SharePoint;
using SquadronAddIns.Default.Utility.Entity;
using Squadron.Common;
using SquadronAddIns.Default.Size.Dialogs;

namespace SquadronAddIns.Default.SizeInfo
{
    public partial class SizeControl : UserControl
    {
        public SizeControl()
        {
            InitializeComponent();

            SizeList.SelectedIndex = 0;
            grid.SelectionChanged += new EventHandler(grid_SelectionChanged);
            IndentCheck.CheckedChanged += new EventHandler(IndentCheck_CheckedChanged);
            SizeList.SelectedIndexChanged += new EventHandler(SizeList_SelectedIndexChanged);

            FilterText.Text = SquadronContext.Url;
        }

        private void InitializeChart(SPSite site)
        {
            // Color
            IList<Color> colors = new List<Color>();
            colors.Add(Color.FromArgb(122, Color.Blue));
            colors.Add(Color.FromArgb(122, Color.LightGreen));
            colors.Add(Color.FromArgb(122, Color.Orange));
            colors.Add(Color.FromArgb(122, Color.Brown));
            colors.Add(Color.FromArgb(122, Color.Coral));
            colors.Add(Color.FromArgb(122, Color.Lime));
            chart.Colors = colors.ToArray<Color>();

            // Value, Text
            IList<decimal> values = new List<decimal>();
            IList<string> texts = new List<string>();
            IList<string> tooltips = new List<string>();
            foreach (SPWeb web in site.AllWebs)
            {
                values.Add(_sizeUtility.GetSizeOf(web));
                texts.Add(string.Empty);
                tooltips.Add(web.Title);
            }
            chart.Values = values.ToArray<decimal>();
            chart.Texts = texts.ToArray<string>();
            chart.ToolTips = tooltips.ToArray<string>();

            // Displacement
            IList<float> displacements = new List<float>();
            foreach (SPWeb web in site.AllWebs)
                displacements.Add(0.05f);
            chart.SliceRelativeDisplacements = displacements.ToArray<float>();

            chart.SliceRelativeHeight = 0.15f;
            chart.EdgeColorType = System.Drawing.PieChart.EdgeColorType.EnhancedContrast;
            chart.ShadowStyle = System.Drawing.PieChart.ShadowStyle.UniformShadow;
            chart.ForeColor = Color.Black;
        }

        void grid_SelectionChanged(object sender, EventArgs e)
        {
            InfoPanel.Hide();

            if (grid.SelectedRows.Count > 0)
                if (grid.SelectedRows[0].DataBoundItem is SizeEntity)
                    if ((grid.SelectedRows[0].DataBoundItem as SizeEntity).InternalObject is SPSite)
                    {
                        SPSite site = (grid.SelectedRows[0].DataBoundItem as SizeEntity).InternalObject as SPSite;
                        chart.Hide();

                        InfoPanel.Show();

                        RefreshChart();
                    }
        }

        private SharePointUtility _utility = new SharePointUtility();
        private SizeUtility _sizeUtility = new SizeUtility();

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                var list = _utility.GetSharePointObjects(SquadronContext.Url, false, SiteCollectionCheck.Checked, SiteCheck.Checked, ListCheck.Checked, false, string.Empty);

                if (FilterCheck.Checked)
                    list = list.Where(o => _utility.GetUrl(o).ToLower().StartsWith(FilterText.Text.ToLower())).ToList();

                _result = _sizeUtility.GetSize(list);

                SetBoldNItalic();
                SetFormatting();
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private string GetFilterUrl()
        {
            if (FilterCheck.Checked)
                return FilterText.Text;

            return string.Empty;
        }

        private void SetBoldNItalic()
        {
            grid.BoldRows.Clear();

            int ix = 0;
            foreach (SizeEntity entity in _result)
            {
                if (entity.InternalObject is SPSite)
                    grid.BoldRows.Add(ix);

                ix++;
            }

            grid.ItalicRows.Clear();

            ix = 0;
            foreach (SizeEntity entity in _result)
            {
                if (entity.InternalObject is SPList)
                    grid.ItalicRows.Add(ix);

                ix++;
            }
        }

        private IList<SizeEntity> _result;

        private void SetFormatting()
        {
            SetSize();
            SetIndent();
            SetHighlight();

            grid.DataSource = null;
            grid.DataSource = _result;
        }

        private void SetHighlight()
        {
            if (_result == null)
                return;

            int ix = 0;
            foreach (SizeEntity sizeentity in _result)
            {
                if (sizeentity.InternalObject is SPSite)
                    if (sizeentity.SizeLong.ToGB() > 100)
                        grid.RedRows.Add(ix);

                TimeSpan span = DateTime.Today - sizeentity.ModifiedDate;
                if (span.TotalDays > 365)
                    grid.RedRows.Add(ix);

                ix++;
            }
        }

        private void SetIndent()
        {
            if (_result == null)
                return;

            if (IndentCheck.Checked)
                foreach (SizeEntity entity in _result)
                    entity.Title = Helper.Instance.GetIndented(entity.Title, entity.InternalObject);
            else
                foreach (SizeEntity entity in _result)
                    entity.Title = _utility.GetDisplayNameOnly(entity.InternalObject);
        }

        private void SetSize()
        {
            if (_result == null)
                return;

            foreach (SizeEntity entity in _result)
                entity.IsSizeInGB = (SizeList.SelectedIndex == 1);
        }

        private void RefreshSubsitesButton_Click(object sender, EventArgs e)
        {
            RefreshChart();
        }

        private void RefreshChart()
        {
            SquadronHelper.Instance.StartAnimation();

            try
            {
                SPSite site = (grid.SelectedRows[0].DataBoundItem as SizeEntity).InternalObject as SPSite;
                InitializeChart(site);
                chart.Show();
            }
            finally
            {
                SquadronHelper.Instance.StopAnimation();
            }
        }

        private void IndentCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetFormatting();
        }

        private void SizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormatting();
        }

        private void FilterCheck_CheckedChanged(object sender, EventArgs e)
        {
            FilterText.Visible = FilterCheck.Checked;
        }

        private void HighlightCheck_CheckedChanged(object sender, EventArgs e)
        {
            SetFormatting();
        }

        private void DbSizeButton_Click(object sender, EventArgs e)
        {
            new ContentDatabaseSizeForm().ExecuteDialog();
        }
    }
}
