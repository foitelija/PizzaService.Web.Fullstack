﻿namespace BlazorMiamiPizza.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlaceOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
    }
}