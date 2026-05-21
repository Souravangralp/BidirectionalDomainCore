//using System.Diagnostics;
//using Castle.DynamicProxy;
//using Bidirectional.Application.Logging;
//using Bidirectional.DomainCore.BidOnboard.Infrastructure.Bid.Logging;
//using Microsoft.ApplicationInsights;
//using Microsoft.ApplicationInsights.DataContracts;
//using Microsoft.Extensions.DependencyInjection;
//using LogLevel = Microsoft.Extensions.Logging.LogLevel;

//namespace Bidirectional.DomainCore.BidOnboard.Persistence.Interceptors;

//public class AsyncLoggingInterceptor : IAsyncInterceptor
//{
//    private readonly TelemetryClient _telemetryClient;

//    private readonly IServiceProvider _provider;
//    private IAppInsightsLogger logger => _provider.GetRequiredService<IAppInsightsLogger>();

//    private IHttpContextAccessor httpContextAccessor => _provider.GetRequiredService<IHttpContextAccessor>();

//    private ICurrentUserService currentUserService => _provider.GetRequiredService<ICurrentUserService>();

//    public AsyncLoggingInterceptor(TelemetryClient telemetryClient, IServiceProvider provider)
//    {
//        _telemetryClient = telemetryClient;
//        _provider = provider;
//    }

//    public void InterceptSynchronous(IInvocation invocation)
//    {
//        var interceptor = new LoggingInterceptor(_telemetryClient, _provider);
//        interceptor.Intercept(invocation);
//    }

//    public void InterceptAsynchronous(IInvocation invocation)
//    {
//        //invocation.ReturnValue = InternalInterceptAsynchronous(invocation);
//    }

//    public void InterceptAsynchronous<TResult>(IInvocation invocation)
//    {
//        //invocation.ReturnValue = InternalInterceptAsynchronous<TResult>(invocation);
//    }

//    #region Private Methods

//    private async Task InternalInterceptAsynchronous(IInvocation invocation)
//    {
//        if (LoggingInterceptionSkipRules.ShouldSkip(invocation))
//        {
//            invocation.Proceed();
//            return;
//        }

//        var ctx = LoggingContextManager.GetUserContext(currentUserService, httpContextAccessor);

//        var methodName = $"{invocation.TargetType?.Name}.{invocation.Method.Name}";
//        var stopwatch = Stopwatch.StartNew();

//        using var operation = _telemetryClient.StartOperation<DependencyTelemetry>(methodName);
//        operation.Telemetry.Type = "Service Method";

//        var parameters = LoggingMetadataExtractor.ExtractMethodParameters(invocation);

//        //await logger.LogTrace(
//        //       $"{methodName} start",
//        //       ctx,
//        //       LogLevel.Information,
//        //       new
//        //       {
//        //           Request = methodName,
//        //           Parameters = parameters,
//        //           Duration = $"{stopwatch.ElapsedMilliseconds}ms"
//        //       }
//        //   );

//        try
//        {
//            invocation.Proceed();
//            var task = (Task)invocation.ReturnValue;
//            await task;

//            stopwatch.Stop();
//            operation.Telemetry.Success = true;
//            operation.Telemetry.Duration = stopwatch.Elapsed;

//           // await logger.LogTrace(
//           //    $"{methodName}",
//           //    ctx,
//           //    LogLevel.Information,
//           //    new
//           //    {
//           //        Request = methodName,
//           //        Parameters = parameters,
//           //        Response = invocation.ReturnValue,
//           //        Duration = $"{stopwatch.ElapsedMilliseconds}ms",
//           //    }
//           //);
//        }
//        catch (Exception ex)
//        {
//            stopwatch.Stop();
//            operation.Telemetry.Success = false;
//            operation.Telemetry.Duration = stopwatch.Elapsed;
//            await logger.LogException(
//              ex,
//              ctx,
//              LogLevel.Error,
//              new
//              {
//                  //Request = methodName,
//                  Parameters = parameters,
//                  //Duration = $"{stopwatch.ElapsedMilliseconds}ms",
//              }
//            );

//            ex.MarkLogged();
//            throw;
//        }
//    }

//    private async Task<TResult> InternalInterceptAsynchronous<TResult>(IInvocation invocation)
//    {
//        if (LoggingInterceptionSkipRules.ShouldSkip(invocation))
//        {
//            invocation.Proceed();
//            if (invocation.ReturnValue is not Task<TResult> skipTask)
//                throw new InvalidOperationException(
//                    $"Method {invocation.Method.Name} did not return Task<{typeof(TResult).Name}>");

//            return await skipTask;
//        }

//        var ctx = LoggingContextManager.GetUserContext(currentUserService, httpContextAccessor);

//        var methodName = $"{invocation.TargetType?.Name}.{invocation.Method.Name}";
//        var stopwatch = Stopwatch.StartNew();

//        using var operation = _telemetryClient.StartOperation<DependencyTelemetry>(methodName);
//        operation.Telemetry.Type = "Service Method";

//        var parameters = LoggingMetadataExtractor.ExtractMethodParameters(invocation);

//        // await logger.LogTrace(
//        //    $"{methodName} start",
//        //    ctx,
//        //    LogLevel.Information,
//        //    new
//        //    {
//        //        Request = methodName,
//        //        Parameters = parameters,
//        //        Duration = $"{stopwatch.ElapsedMilliseconds}ms",
//        //    }
//        //);

//        try
//        {
//            invocation.Proceed();

//            if (invocation.ReturnValue is not Task<TResult> task)
//                throw new InvalidOperationException(
//                    $"Method {invocation.Method.Name} must return Task<{typeof(TResult).Name}>");

//            var result = await task;

//            stopwatch.Stop();
//            operation.Telemetry.Success = true;
//            operation.Telemetry.Duration = stopwatch.Elapsed;

//            await logger.LogTrace(
//               $"{methodName}",
//               ctx,
//               LogLevel.Information,
//               new
//               {
//                   Request = methodName,
//                   Parameters = parameters,
//                   Response = result,
//                   Duration = $"{stopwatch.ElapsedMilliseconds}ms",
//               }
//           );

//            return result;
//        }
//        catch (Exception ex)
//        {
//            stopwatch.Stop();
//            operation.Telemetry.Success = false;
//            operation.Telemetry.Duration = stopwatch.Elapsed;

//            //await logger.LogException(
//            //  ex,
//            //  ctx,
//            //  LogLevel.Error,
//            //  new
//            //  {
//            //      //Request = methodName,
//            //      Parameters = parameters,
//            //      //Duration = $"{stopwatch.ElapsedMilliseconds}ms",
//            //  }
//            //);

//            //ex.MarkLogged();
//            throw;
//        }
//    }

//    #endregion
//}
