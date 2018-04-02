﻿using Autofac.Benchmarks.Decorators.Scenario;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autofac.Benchmarks.Decorators
{
    /// <summary>
    /// Benchmarks the simple/common use case for decorators using the new fluent syntax.
    /// </summary>
    public class FluentSimpleBenchmark : DecoratorBenchmarkBase<ICommandHandler>
    {
        [Setup]
        public void Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<CommandHandlerOne>()
                .As<ICommandHandler>();
            builder.RegisterType<CommandHandlerTwo>()
                .As<ICommandHandler>();
            builder.RegisterDecorator<CommandHandlerDecoratorOne, ICommandHandler>();
            this.Container = builder.Build();
        }
    }
}
