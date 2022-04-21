using Haskap.DddBase.Infrastructure.Providers;
using Microsoft.Extensions.DependencyInjection;
//using Tesmer.PaymentSystem.Infrastructure.Data.Interceptors;

namespace Haskap.Resume.Ui.MvcUi;

public static class ServiceCollectionExtensions
{
    public static void AddDomainServices(this IServiceCollection services)
    {
        //services.AddTransient<OrderIdDomainService>();
        //services.AddTransient<PaymentCredentialsDomainService>();
    }

    public static void AddUseCaseServices(this IServiceCollection services)
    {
        //services.AddTransient<IBasketService, BasketService>();
        //services.AddTransient<IPaymentService, PaymentService>();
        //services.AddTransient<ICreditCardTypeService, CreditCardTypeService>();
        //services.AddTransient<IAccountService, AccountService>();
        //services.AddTransient<IReportService, ReportService>();
    }

    public static void AddProviders(this IServiceCollection services)
    {
        //services.AddSingleton<LoggedInUserProvider<Guid?>>();
        //services.AddSingleton<VisitIdProvider>();
    }

    public static void AddEfInterceptors(this IServiceCollection services)
    {
        //services.AddScoped<AuditSaveChangesInterceptor<Guid?>>();
        //services.AddScoped<AuditHistoryLogSaveChangesInterceptor<Guid?>>();
    }
}
