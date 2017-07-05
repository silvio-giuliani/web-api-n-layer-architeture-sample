using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CommandHandler
    {
        public event EventHandler NotifyExecution;

        public void Execute()
        {
            NotifyExecution?.Invoke(this, null);

        }
    }
}
