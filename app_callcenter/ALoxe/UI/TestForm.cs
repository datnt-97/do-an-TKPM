using MaterialDesignExtensions.Controls;
using MaterialDesignExtensions.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using MaterialDesignThemes.Wpf;
using System.Windows.Documents;
using System.Windows.Media;
using ALoxe.Components;

namespace ALoxe.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        public class TaskData
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new CircleImageButton
            {
                Text = "adfdfdsfd",
                BackColor = System.Drawing.Color.Red,
            });
            //pnMain.Controls.Add(new CircleImageButton());
            //    ElementHost element = new ElementHost();
            //    Stepper stepper = new Stepper();
            //    stepper.Layout = StepperLayout.Horizontal;
            //    stepper.Style = new System.Windows.Style()
            //    {
            //        TargetType = typeof(ButtonAssist),

            ////          < Setter Property = "Template" >
            ////    < Setter.Value >
            ////        < ControlTemplate TargetType = "{x:Type Button}" >
            ////            < Grid >
            ////                < AdornerDecorator >
            ////                    < AdornerDecorator.CacheMode >
            ////                        < BitmapCache EnableClearType = "True" SnapsToDevicePixels = "True" />
            ////                    </ AdornerDecorator.CacheMode >
            ////                    < Border Background = "Transparent"
            ////                            BorderThickness = "0"
            ////                            x:Name = "border"
            ////                            Effect = "{Binding RelativeSource={RelativeSource TemplatedParent}, Path=(md:ShadowAssist.ShadowDepth), Converter={x:Static md:ShadowConverter.Instance}}" >
            ////                    </ Border >
            ////                </ AdornerDecorator >
            ////                < md:Ripple Content = "{TemplateBinding Content}" ContentTemplate = "{TemplateBinding ContentTemplate}" Focusable = "False"
            ////                           HorizontalContentAlignment = "{TemplateBinding HorizontalContentAlignment}"
            ////                           VerticalContentAlignment = "{TemplateBinding VerticalContentAlignment}"
            ////                           SnapsToDevicePixels = "{TemplateBinding SnapsToDevicePixels}"
            ////                           Margin = "0" Padding = "0" />
            ////            </ Grid >
            ////            < ControlTemplate.Triggers >
            ////                < Trigger Property = "IsMouseOver" Value = "true" >
            ////                    < Setter Property = "BorderBrush" TargetName = "border" Value = "{DynamicResource MaterialDesignFlatButtonClick}" />
            ////                    < Setter Property = "Background" TargetName = "border" Value = "{DynamicResource MaterialDesignFlatButtonClick}" />
            ////                </ Trigger >
            ////            </ ControlTemplate.Triggers >
            ////        </ ControlTemplate >
            ////    </ Setter.Value >
            ////</ Setter >
            //        Setters =
            //        {
            //            new  Setter()
            //            {
            //              // của lớp nào :  
            //                Property = Templat,
            //                Value = new ControlTemplate()
            //                {
            //                    TargetType = typeof(Button),
            //                    VisualTree = new FrameworkElementFactory(typeof(Grid)),
            //                    Triggers =
            //                    {
            //                        new Trigger()
            //                        {
            //                            Property = Button.IsMouseOverProperty,
            //                            Value = true,
            //                            Setters =
            //                            {
            //                                new Setter()
            //                                {
            //                                    Property = Button.BorderBrushProperty,
            //                                    Value = new SolidColorBrush(Colors.Red)
            //                                },
            //                                new Setter()
            //                                {
            //                                    Property = Button.BackgroundProperty,
            //                                    Value = new SolidColorBrush(Colors.Red)
            //                                },
            //                            }
            //                        }
            //                    }
            //                }
            //            },
            //        }
            //    };
            //    stepper.IsLinear = false;
            //    stepper.Steps = new List<Step>();
            //    var a = new FrameworkElementFactory(typeof(StackPanel));
            //    a.AppendChild(new FrameworkElementFactory(typeof(PictureBox)));
            //    stepper.Steps.Add(new Step()
            //    {
            //        Header = new StepTitleHeaderControl()
            //        {
            //            FirstLevelTitle = "Step 1",
            //            ToolTip = "Step 1",
            //            SecondLevelTitle = "Step 1",

            //        },

            //        //set icon for step by IconTemplate
            //        IconTemplate = new DataTemplate()
            //        {
            //            DataType = typeof(TaskData),
            //            VisualTree = a,
            //            Template = new ControlTemplate()
            //        },



            //    });
            //    stepper.Steps.Add(new Step()
            //    {
            //        Header = "Step 1",
            //        IconTemplate = new System.Windows.DataTemplate
            //        {
            //            DataType = typeof(TaskData),
            //            VisualTree = new FrameworkElementFactory(typeof(StackPanel)),
            //        },

            //    });
            //    stepper.Steps.Add(new Step()
            //    {
            //        Header = "Step 1",
            //        IconTemplate = new System.Windows.DataTemplate
            //        {
            //            DataType = typeof(TaskData),
            //            VisualTree = new FrameworkElementFactory(typeof(StackPanel)),
            //        },

            //    });
            //    element.Child = stepper;
            //    pnMain.Controls.Add(element);
            //    element.Dock = DockStyle.Fill;
        }
    }
}
