using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;

namespace SquadronAddins.Default.CopyItems
{
    public partial class CopyItemControl : UserControl
    {
        public CopyItemControl()
        {
            InitializeComponent();
        }

        public string SourceListName
        {
            get { return SourceLabel.Text; }
            set { SourceLabel.Text = value; }
        }

        public string DestinationListName
        {
            get { return DestinationText.Text; }
            set
            {
                DestinationText.Text = value;
                DestinationText.TextChanged += DestTextChanged;
            }
        }

        public bool IsValid
        {
            get;
            set;
        }

        public SPWeb SourceWeb;
        public SPWeb DestinationWeb;

        public void Calculate()
        {
            IsValid = false;
            InfoLabel.ForeColor = Color.Green;

            if (string.IsNullOrEmpty(DestinationListName.Trim()))
            {
                IsValid = false;
                InfoLabel.Text = "Invalid Destination List Name!";
                InfoLabel.ForeColor = Color.Red;
            }
            else
            {
                if (SourceWeb.Url == DestinationWeb.Url)
                {
                    if (SourceListName == DestinationListName)
                    {
                        IsValid = true;
                        InfoLabel.Text = "Copy Items (Duplication)";
                    }
                    else
                    {
                        IsValid = true;
                        InfoLabel.Text = "Create List, Copy Items";
                    }
                }
                else
                {
                    if (DestinationWeb.Lists.Cast<SPList>().Any<SPList>(l => l.Title == DestinationListName))
                    {
                        if (IsStructureValid())
                        {
                            IsValid = true;
                            InfoLabel.Text = "Copy Items";
                        }
                        else
                        {
                            IsValid = false;
                            InfoLabel.Text = "Incompatible Destination List structure, Please change Destination List Name.";
                            InfoLabel.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        IsValid = true;
                        InfoLabel.Text = "Create List, Copy Items";
                    }
                }
            }
        }

        private bool IsStructureValid()
        {
            SPList sourceList = SourceWeb.Lists[SourceListName];
            SPList destList = DestinationWeb.Lists[DestinationListName];

            for (int i = 0; i < sourceList.Fields.Count; i++)
            {
                string fieldName = sourceList.Fields[i].Title;

                if (!destList.Fields.Cast<SPField>().Any(f => f.Title == fieldName))
                    return false;

                if (destList.Fields[fieldName].Type != sourceList.Fields[i].Type)
                    return false;
            }

            return true;
        }

        private void DestTextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
