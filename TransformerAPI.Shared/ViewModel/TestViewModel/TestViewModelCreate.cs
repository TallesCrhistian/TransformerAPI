﻿using System;

namespace TransformerAPI.Shared.ViewModel.TestViewModel
{
    public class TestViewModelCreate : BaseViewModel
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime Duration_in_Seconds { get; set; }
    }
}
