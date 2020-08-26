 

using System.Windows.Controls;
using System.Windows.Input;

 namespace WpfRichText.ColorPicker
{
  public class ColorPickerTabItem : TabItem
  {
    protected override void OnMouseLeftButtonDown( MouseButtonEventArgs e )
    {
      if( e.Source == this || !this.IsSelected )
      {
        e.Handled = true;
        return;
      }

      base.OnMouseLeftButtonDown( e );
    }

    protected override void OnMouseLeftButtonUp( MouseButtonEventArgs e )
    {
      //Selection on Mouse Up
      if( e.Source == this || !this.IsSelected )
      {
        base.OnMouseLeftButtonDown( e );
      }

      base.OnMouseLeftButtonUp( e );
    }
  }
}
