﻿using Caliburn.Micro;

namespace ex06_caloburn_basic.ViewModels
{
    public class MainViewModel : Conductor<object>
    {
        public string Greeting { get { return "헬로, 칼리번!"; } }
    }
}