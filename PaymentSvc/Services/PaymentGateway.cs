﻿using HildenCo.Core.Contracts.Payment;
using PaymentSvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSvc.Services
{
    public class PaymentGateway : IPaymentGateway
    {
        public async Task<PaymentGatewayResponse> Process(PaymentGatewayRequest pgr)
        {
            // fake pmt delay
            await Task.Delay(pgr.FakeDelay);

            return BuildFakeResponse(pgr);
        }

        private PaymentGatewayResponse BuildFakeResponse(PaymentGatewayRequest pgr)
        {
            return new PaymentGatewayResponse
            {
                PaymentGatewayId = pgr.PaymentGatewayId,
                Currency = pgr.Currency,
                Amount = pgr.Amount,
                AuthCode = pgr.FakeResult ? 
                    Guid.NewGuid().ToString().ToUpper().Substring(0, 8) : 
                    null,
                Status = pgr.FakeResult ?
                    PaymentGatewayResponseStatus.Authorized : 
                    PaymentGatewayResponseStatus.Declined
            };
        }
    }
}
