﻿using System;
using timeSheetService.dataContracts;

namespace timeSheetService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class timeSheetService : ItimeSheetService
    {
        public contractGetDate getDate()
        {
            contractGetDate SD = new contractGetDate();
            SD.DateValue = DateTime.Now.ToString();
            return SD;
        } 

        
    }
}