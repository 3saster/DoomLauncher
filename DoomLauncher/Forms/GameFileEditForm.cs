﻿using DoomLauncher.DataSources;
using DoomLauncher.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomLauncher
{
    public partial class GameFileEditForm : Form
    {
        private IDataSourceAdapter m_adapter;
        private ITabView m_view;

        public GameFileEditForm()
        {
            InitializeComponent();
            btnCopyFrom.Visible = false;
        }

        public void SetCopyFromFileAllowed(IDataSourceAdapter adapter, ITabView view)
        {
            m_adapter = adapter;
            m_view = view;
            btnCopyFrom.Visible = true;
        }

        public void SetSelectDataMode()
        {
            EditControl.SetShowCheckBoxes(true);
            EditControl.SetShowTagCheckBox(true);
            btnSaveSelect.Text = "Select";
        }

        public bool TagsChanged
        {
            get;
            private set;
        }

        public GameFileEdit EditControl
        {
            get { return gameFileEdit1;  }
        }

        private void btnCopyFrom_Click(object sender, EventArgs e)
        {
            using (FileSelectForm fileSelect = CreateFileSelectForm()) //select the file you want to copy data from
            {
                if (fileSelect.ShowDialog(this) == DialogResult.OK)
                {
                    using (GameFileEditForm dataSelect = CreateDataSelectForm(fileSelect)) //show another GameFileEdit with checkboxes to select what fields
                    {
                        if (dataSelect.ShowDialog(this) == DialogResult.OK)
                        {
                            GameFile updateFile = ((GameFile)EditControl.DataSource).Clone() as GameFile; //clone GameFile otherwise we are modifying the datasource the gridview is using
                            List<GameFileFieldType> fields = dataSelect.EditControl.UpdateDataSource(EditControl.DataSource);

                            foreach (var field in fields)
                            {
                                var property = typeof(IGameFile).GetProperty(field.ToString("g"));
                                var fieldData = property.GetValue(dataSelect.EditControl.DataSource);
                                property.SetValue(updateFile, fieldData);                      
                            }

                            TagsChanged = dataSelect.EditControl.TagsChecked;

                            if (TagsChanged)
                                EditControl.SetDataSource(updateFile, dataSelect.EditControl.TagData);
                            else
                                EditControl.SetDataSource(updateFile, EditControl.TagData);
                        }
                    }
                }
            }
        }

        private FileSelectForm CreateFileSelectForm()
        {
            FileSelectForm fileSelect = new FileSelectForm();
            fileSelect.Initialize(m_adapter, new ITabView[] { m_view });
            fileSelect.StartPosition = FormStartPosition.CenterParent;
            fileSelect.MultiSelect = false;
            return fileSelect;
        }

        private GameFileEditForm CreateDataSelectForm(FileSelectForm fileSelect)
        {
            GameFileEditForm dataSelect = new GameFileEditForm();
            dataSelect.Text = "Select Fields to Copy";
            dataSelect.StartPosition = FormStartPosition.CenterParent;
            var selectedFile = fileSelect.SelectedFiles[0];
            IEnumerable<ITagMapping> tagMapping = m_adapter.GetTagMappings(selectedFile.GameFileID.Value);
            var tags = from tag in m_adapter.GetTags() join map in tagMapping on tag.TagID equals map.TagID select tag;
            dataSelect.EditControl.SetDataSource(selectedFile, tags);
            dataSelect.SetSelectDataMode();
            return dataSelect;
        }
    }
}
