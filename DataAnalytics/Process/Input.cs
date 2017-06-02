using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalytics.Process
{
    class Input
    {
        private IInput _InputService;
        public Input(IInput InputService)
        {
            this._InputService = InputService;
        }

        public string ReturnBoardStream()
        {
            return _InputService.GetSourceStream();
        }
    }
}
