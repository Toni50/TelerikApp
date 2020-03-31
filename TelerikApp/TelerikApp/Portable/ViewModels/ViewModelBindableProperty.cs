using System;
using System.Globalization;
using System.Reflection;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.DataVisualization.Gauges;
using Xamarin.Forms;

namespace TelerikApp.Portable.ViewModels
{
    public class ViewModelBindableProperty
    {
        public static readonly BindableProperty AutoWireViewModelProperty =
            BindableProperty.CreateAttached("AutoWireViewModel", 
                typeof(ObservableItemCollection<GaugeIndicatorBase>),
                typeof(ViewModelBindableProperty), 
                default(ObservableItemCollection<GaugeIndicatorBase>),
                propertyChanged: OnAutoWireViewModelChanged);

        public static bool GetAutoWireViewModel(BindableObject bindable)
        {
            return (bool)bindable.GetValue(AutoWireViewModelProperty);
        }

        public static void SetAutoWireViewModel(BindableObject bindable, bool value)
        {
            bindable.SetValue(AutoWireViewModelProperty, value);
        }

        private static void OnAutoWireViewModelChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is RadRadialGauge view))
            {
                return;
            }

            view.Indicators.Clear();

            if (newValue != null)
            {
                ObservableItemCollection<GaugeIndicatorBase> indicators =
          (ObservableItemCollection<GaugeIndicatorBase>)newValue;

                foreach (GaugeIndicatorBase ind in indicators)
                {
                    view.Indicators.Add(ind);
                }
            }

          


            


            }
        }
    }

