using Newtonsoft.Json;
using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class MachineClass
    {
        AllItemViewModel allItemViewModel = new AllItemViewModel();

        public void TogglePump1(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
                foreach (PipeClass pi in v.VentilPipeList.Where(p => p.Id == 5))
                {
                    foreach (PumpClass pu in allItemViewModel.AllItemPump)
                    {
                        if (pu.Id == id && pi.Status == 1)
                        {
                            pu.Activatable = true;

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

                        else
                        {
                            pu.Activatable = false;
                            pu.Status = 2;
                        }
                    }
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/PumpJSON.json", output);
        }

        public void ToggleVentil1(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
                if (v.Id == id)
                {
                    switch (v.Status)
                    {
                        case 1:
                            v.Status = 2;
                            break;
                        case 2:
                            v.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in v.VentilPipeList)
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

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ToggleVentil4(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
                if (v.Id == id)
                {
                    switch (v.Status)
                    {
                        case 1:
                            v.Status = 2;
                            break;
                        case 2:
                            v.Status = 1;
                            break;
                    }
                    foreach (VentilClass vc in allItemViewModel.AllItemVentil.Where(v => v.Id == 5))
                    {
                        switch (vc.Activatable)
                        {
                            case false:
                                vc.Activatable = true;
                                break;
                            case true:
                                vc.Activatable = false;
                                break;
                        }
                        if(v.Status == 2)
                        {
                            vc.Status = 2;
                        }
                    }
                    foreach (PipeClass p in v.VentilPipeList)
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

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ToggleVentil2(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
                if (v.Id == id)
                {
                    switch (v.Status)
                    {
                        case 1:
                            v.Status = 2;
                            break;
                        case 2:
                            v.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in v.VentilPipeList)
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

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ToggleVentil3(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
                if (v.Id == id)
                {
                    switch (v.Status)
                    {
                        case 1:
                            v.Status = 2;
                            break;
                        case 2:
                            v.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in v.VentilPipeList)
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

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ToggleVentil5(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {                
                    if (v.Id == id)
                    {
                    foreach (VentilClass vc in allItemViewModel.AllItemVentil.Where(v => v.Id == 4))
                    {
                        if (vc.Status == 1)
                        {
                            switch (v.Status)
                            {
                                case 1:
                                    v.Status = 2;
                                    break;
                                case 2:
                                    v.Status = 1;
                                    break;
                            }
                        }
                        else
                        {
                            switch (v.Status)
                            {
                                case 1:
                                    v.Status = 2;
                                    break;
                                case 2:
                                    v.Status = 1;
                                    break;
                            }

                            foreach(VentilClass vc2 in allItemViewModel.AllItemVentil.Where(v => v.Id == 3))
                            {
                                vc2.Activatable = true;
                            }
                            foreach(PipeClass p in v.VentilPipeList)
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
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }
        public void EmptyTank(int id)
        {
            foreach(TankClass t in allItemViewModel.AllItemTank)
            {
                if (t.Id == id)
                {
                    switch (t.Fill)
                    {
                        case true:
                            t.Fill = false;
                            break;
                        case false:
                            t.Fill = true;
                            break;
                    }

                    EmptyFunctionON();

                }

            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }
        public void FillTank()
        {
            foreach(VentilClass vc in allItemViewModel.AllItemVentil.Where(vc => vc.Id == 1))
            {
                vc.Activatable = true;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }
        private string GetConditions(AllItemViewModel allItemViewModel)
        {
            string conditionsFromJson = null;
            foreach (PumpClass pu in allItemViewModel.AllItemPump)
            {
                if (pu.Conditions != null)
                {
                    conditionsFromJson = pu.Conditions;
                }
            }
            return conditionsFromJson;
        }

        public void EmptyFunctionON()
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil.Where(vc => vc.Id == 4))
            {
                v.Activatable = false;
            }
            foreach (VentilClass v in allItemViewModel.AllItemVentil.Where(v => v.Id == 5))
            {
                v.Activatable = true;
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }
    }
}
