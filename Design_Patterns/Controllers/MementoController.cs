using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Design_Patterns.MementoPattern;
using Design_Patterns.MementoExample;

namespace Design_Patterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MementoController : ControllerBase
    {

        [HttpGet]
        public IActionResult MementoPattern()
        {
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();

            originator.setState("state 1");
            originator.setState("state 2");
            //Add checkpoint
            careTaker.add(originator.saveStateMemento());
            originator.setState("state 8");
            //Add second Checkpoint
            careTaker.add(originator.saveStateMemento());
            string text = $"{originator.getState()}";
            return Ok(text);

        }

        [HttpPost("/MementoExample")]
        public IActionResult MementoExample(int marker)
        {
            //Originator
            Book book= new Book();
            //CareTaker
            ManagementMarker managementMarker= new ManagementMarker();


            book.goPage(20);
            book.goPage(30);
            managementMarker.addPositionMarker(book.saveMarker());
            book.goPage(40);
            managementMarker.addPositionMarker(book.saveMarker());
            book.goPage(80);
            managementMarker.addPositionMarker(book.saveMarker());

            book.recoveryPage(managementMarker.getPositionMarker(marker));
            
            string text = $"The saved page is {book.getPage()}";
            return Ok(text);

        }

    }
}
