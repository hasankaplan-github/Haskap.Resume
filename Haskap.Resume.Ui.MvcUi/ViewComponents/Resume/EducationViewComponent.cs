using Microsoft.AspNetCore.Mvc;

namespace Haskap.Resume.Ui.MvcUi.ViewComponents.Resume;

public class EducationViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
