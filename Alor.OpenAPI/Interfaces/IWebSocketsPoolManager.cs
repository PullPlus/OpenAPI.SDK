﻿using Alor.OpenAPI.Models;
using Alor.OpenAPI.Websocket;

namespace Alor.OpenAPI.Interfaces
{
    public interface IWebSocketsPoolManager : IDisposable
    {
        ISubscriptionManager Subscriptions { get; }
        ICwsManager CommandWs { get; }
    }

    internal interface IInternalWebSocketsPoolManagerActions : IDisposable
    {
        void JwtUpdate(string? newToken);
        IEnumerable<WebSocketInfoDetails> GetWebSocketsInfoDetail();
        void CalculateWebSocketsInfoSentRecieveRates();
        void SetWsResponseMessageHandler(Action<WsResponseMessage>? handler);
        void SetWsResponseCommandMessageHandler(Action<WsResponseCommandMessage>? handler);
    }
}
