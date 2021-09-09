using System;
using System.Collections.Generic;
using System.Text;
using DISampleService.DIL;

namespace DISampleService.DIL
{
    public class GuiService : IScopedService, ISingletonService, ITransientService
    {
        Guid guid;
        public GuiService()
        {
            guid = Guid.NewGuid();
        }
        public Guid GetGuid()
        {
            return guid;
        }
    }
}
