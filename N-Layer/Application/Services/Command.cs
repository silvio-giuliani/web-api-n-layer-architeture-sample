using System;

namespace Application.Services
{
    public abstract class Command
    {
        private readonly CommandHandler _commandHandler;

        public void Execute()
        {
            _commandHandler.NotifyExecution += CommandHandler_NotifyExecution;
        }

        private void CommandHandler_NotifyExecution(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
