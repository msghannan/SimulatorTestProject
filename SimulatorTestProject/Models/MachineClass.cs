using Newtonsoft.Json;
using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class MachineClass
    {
        AllItemViewModel allItemViewModel = new AllItemViewModel();

        public void TogglePump(int Id)
        {
            foreach (PumpClass pu in allItemViewModel.AllItemPump)
            {
                if (pu.Id == Id)
                {
                    switch (pu.Status)
                    {
                        case 1:
                            pu.Status = 2;
                            break;
                        case 2:
                            pu.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in pu.PumpPipeList)
                    {
                        switch (p.Status)
                        {
                            case 1:
                                p.Status = 2;
                                break;
                            case 2:
                                p.Status = 1;
                                break;
                        }
                        break;
                    }
                    break;

                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/PumpJSON.json", output);
        }
    }
}
