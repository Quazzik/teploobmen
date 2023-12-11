using Microsoft.AspNetCore.Mvc;
using teploobmen.Data;
using TeploobmenLibrary;
using TeploobmenLibrary.Models;

namespace teploobmen.Models
{
    public class TestPageModel
    {
        public TeploobmenOutputModel? OutputModel { get; set; }
        public InputData? InputData { get; set; }
        [BindProperty]
        public bool save {  get; set; }
        }
}
