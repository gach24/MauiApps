﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnitsNet;

namespace MauiVerter.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {
        #region CONSTRUCTOR
        public ConverterViewModel(string quantityName)
        {
            QuantityName = quantityName;
            FromMeasures = LoadMeasures();
            ToMeasures = LoadMeasures();
            CurrentFromMeasure = FromMeasures.FirstOrDefault();
            CurrentToMeasure = ToMeasures.Skip(1).FirstOrDefault();
            Convert();
        }

        #endregion

        #region PROPERTIES

        public string QuantityName { get; set; }
        public ObservableCollection<string> FromMeasures { get; set; }
        public ObservableCollection<string> ToMeasures { get; set; }
        public string CurrentFromMeasure { get; set; }
        public string CurrentToMeasure { get; set; }


        public double FromValue { get; set; } = 1;
        public double ToValue { get; set; }

        public ICommand ReturnCommand => new Command(() =>
        {
            Convert();
        });

        #endregion

        #region PRIVATE METHODS
        private ObservableCollection<string> LoadMeasures()
        {
            var types = Quantity
                .Infos
                .FirstOrDefault(x => x.Name == QuantityName)
                .UnitInfos
                .Select(u => u.Name)
                .ToList();
            return new ObservableCollection<string>(types);
        }
        #endregion

        #region PUBLIC METHODS
        public void Convert()
        {
            var result = UnitConverter.ConvertByName(
                FromValue,
                QuantityName,
                CurrentFromMeasure,
                CurrentToMeasure);
            ToValue = result;
        }

        #endregion
    }
}