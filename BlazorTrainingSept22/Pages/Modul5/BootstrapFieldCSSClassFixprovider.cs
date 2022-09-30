using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTrainingSept22.Pages.Modul5
{
    public class BootstrapFieldCSSClassFixprovider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isinvalid=editContext.GetValidationMessages(fieldIdentifier).Any();
            return isinvalid?"is-invalid":"is-valid";
        }
    }
}
