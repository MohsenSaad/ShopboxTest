using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShopBox.Behaviors
{
  public class EmailValidatorBehavior: Behavior<Entry>
    {

        const string emailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        public static readonly BindableProperty IsValidProperty = BindableProperty.Create("IsValid", typeof(bool), typeof(EmailValidatorBehavior), false);

        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            set { SetValue(IsValidProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
          IsValid=(Regex.IsMatch(e.NewTextValue,emailRegex,RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)));
            ((Entry)sender).TextColor = IsValid ? Color.Default : Color.Red;
        }

       
    }
}
