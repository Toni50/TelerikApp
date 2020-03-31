using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using TelerikApp.Portable.Models;
using TelerikApp.ViewModels;
using Xamarin.Forms;

namespace TelerikApp.Portable.ViewModels
{
    public class ExpensesByCategoriesBindingViewModel : BaseViewModel
    {

        private ObservableCollection<CategoricalData> _listData = new ObservableCollection<CategoricalData>();
        public ObservableCollection<CategoricalData> listData
        {
            get
            {
                return _listData;
            }
            set
            {
                SetProperty(ref _listData, value);
            }
        }

        private double _minimum;
        public double minimum
        {
            get
            {
                return _minimum;
            }
            set
            {
                SetProperty(ref _minimum, value);
            }
        }

        private double _maximum;
        public double maximum
        {
            get
            {
                return _maximum;
            }
            set
            {
                SetProperty(ref _maximum, value);
            }
        }


        private ObservableItemCollection<GaugeIndicatorBase> _indicators = new ObservableItemCollection<GaugeIndicatorBase>();
        public ObservableItemCollection<GaugeIndicatorBase> indicators
        {
            get
            {
                return _indicators;
            }
            set
            {
                SetProperty(ref _indicators, value);
            }
        }



        public ExpensesByCategoriesBindingViewModel()
        {
           
            Color MyViolet = Color.FromHex("#c75299");
            Color MyBlue = Color.FromHex("#439cd9");
            
            double CurrentOffset = 0;
            this.minimum = 0;
            this.maximum = 50;
            this.listData = new ObservableCollection<CategoricalData>()
            {
                new CategoricalData { Category = "Equipment and hardware", Value = 25 },
                new CategoricalData { Category = "Food and Drinks", Value = 45 },
                new CategoricalData { Category = "Shopping", Value = 15 },
                new CategoricalData { Category = "Travel", Value = 50 },
                new CategoricalData { Category = "Other", Value = 30 }
            };

             

            foreach (CategoricalData item in this.listData)
            {
                var indicatorBg = new GaugeBarIndicator()
                {
                    Value = this.maximum,
                    Fill = Color.LightGray,
                    StartCap = GaugeBarIndicatorCap.Oval,
                    EndCap = GaugeBarIndicatorCap.Oval,
                    Offset = CurrentOffset
                };
                
                this.indicators.Add(indicatorBg);


                var ind = new GaugeBarIndicator()
                {
                    Value = item.Value,
                    Fill = Color.Blue,
                    StartCap = GaugeBarIndicatorCap.Oval,
                    EndCap = GaugeBarIndicatorCap.Oval,
                    Offset = CurrentOffset
                };
             
                this.indicators.Add(ind);
                ind.GradientStops.Add(new RadGradientStop()
                {
                    Offset = 0,
                    Color = MyBlue
                });
                ind.GradientStops.Add(new RadGradientStop()
                {
                    Offset = item.Value,
                    Color = MyViolet
                });
                this.indicators.Add(
                    new GaugeTextIndicator()
                    {
                        Value = 0,
                        Text = item.Category.ToString(),
                        TextColor = Color.Black,
                        FontSize = 18,
                        HorizontalTextPlacement = HorizontalPlacement.Left,
                        VerticalTextPlacement = VerticalPlacement.Center,
                        Position = GaugeElementPosition.Start,
                        Offset = CurrentOffset
                    });

                CurrentOffset += 30;
            };



        }






    }


}

