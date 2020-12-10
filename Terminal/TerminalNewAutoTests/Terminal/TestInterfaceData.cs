﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Terminal
{
    public class TestInterfaceData
    {
        public ListBox testCommandsView;
        public List<TestCase> Tests;
        public ComboBox testsComboBox;
        public ProgressBar progressBar1;
        public TextBox timeForWaitBox3;
        public Label TestEnd;
        public ConnectionWoker iMWorker;
        public ConnectionWoker DcuWorker;

        public xmlWorking XmlWorking;


        public ListBox TestCaseForAutoTests;
        public ListBox TestForAutoTests;
        public ListBox CommandForAutoTests;
        public ListBox ValidParam;
    }
}