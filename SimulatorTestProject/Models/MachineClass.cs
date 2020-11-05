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
                    foreach (PumpClass pu in allItemViewModel.AllItemPump)
                    {
                        if (pu.Id == id)
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

                        else
                        {
                            pu.Activatable = false;
                            pu.Status = 2;
                        }
                    }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/PumpJSON.json", output);
        }

        public void ToggleVentil1(int id)
        {
            foreach (TankClass t in allItemViewModel.AllItemTank.Where(t => t.Id == 1))
            {
                foreach (VentilClass v in allItemViewModel.AllItemVentil)
                {
                    foreach (VentilClass vc in allItemViewModel.AllItemVentil.Where(vc => vc.Id == 4))
                    {
                        if (v.Id == id && t.ReadyForEmpty == true)
                        {
                            v.Activatable = true;

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

                        else if (v.Id == id)
                        {
                            v.Activatable = true;

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
                        }
                    }
                    break;
                }
            }

            FillTankSeeting();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ToggleVentil4(int id)
        {
            foreach (VentilClass v in allItemViewModel.AllItemVentil)
            {
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
            }
            FillTankSeeting();
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

                    EnablePump();
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
                foreach (TankClass t in allItemViewModel.AllItemTank.Where(t => t.Id == 1))
                {
                    if (v.Id == id)
                    {
                        if (v.Id == id && t.ReadyForFill == true)
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
                }
            }
            FillTankSeeting();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void ReadyForEmptyMethod(int id)
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                foreach (VentilClass v in allItemViewModel.AllItemVentil.Where(v => v.Id == 1 || v.Id == 2 || v.Id == 3 || v.Id == 5))
                {
                    foreach (PipeClass p in v.VentilPipeList)
                    {
                        if (t.Id == id)
                        {
                            switch (v.Activatable)
                            {
                                case false:
                                    v.Activatable = true;
                                    EnableReadyToEmpty();
                                    break;
                                case true:
                                    v.Activatable = false;
                                    DisableReadyToEmpty();
                                    DisablelePump();
                                    v.Status = 2;
                                    p.Status = 2;
                                    break;
                            }
                        }
                    }
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void EnableReadyToEmpty()
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                t.ReadyForEmpty = true;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }

        public void DisableReadyToEmpty()
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                t.ReadyForEmpty = false;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }

        public void ReadyForFillMethod(int id)
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                foreach (VentilClass v in allItemViewModel.AllItemVentil.Where(v => v.Id == 1 || v.Id == 4 || v.Id == 5))
                {
                    foreach (PipeClass p in v.VentilPipeList)
                    {
                        if (t.Id == id)
                        {
                            switch (v.Activatable)
                            {
                                case false:
                                    v.Activatable = true;
                                    EnableReadyToFill();
                                    break;
                                case true:
                                    v.Activatable = false;
                                    DisableReadyToFill();
                                    v.Status = 2;
                                    p.Status = 2;
                                    break;
                            }
                        }
                    }
                }
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
        }

        public void EnableReadyToFill()
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                t.ReadyForFill = true;
            }
            FillTankSeeting();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }

        public void DisableReadyToFill()
        {
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                t.ReadyForFill = false;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }

        public void EnablePump()
        {
            foreach (PumpClass pu in allItemViewModel.AllItemPump.Where(pu => pu.Id == 1))
            {
                pu.Activatable = true;
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/PumpJSON.json", output);
        }

        public void DisablelePump()
        {
            foreach (PumpClass pu in allItemViewModel.AllItemPump.Where(pu => pu.Id == 1))
            {
                pu.Activatable = false;
                pu.Status = 2;

                foreach (PipeClass p in pu.PumpPipeList)
                {
                    p.Status = 2;
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/PumpJSON.json", output);
        }

        public void FillTankSeeting()
        {
            var a = allItemViewModel.AllItemVentil.Where(v => v.Id == 1 && v.Id == 4);
            foreach (TankClass t in allItemViewModel.AllItemTank)
            {
                foreach (VentilClass v in a)
                {
                    if (t.ReadyForFill == true && v.Status == 1)
                    {
                        t.FillTank = true;
                    }

                    else
                    {
                        t.FillTank = false;
                    }
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/TankJSON.json", output);
        }

        public void EmptyTankSetting()
        {

        }
    }

}

