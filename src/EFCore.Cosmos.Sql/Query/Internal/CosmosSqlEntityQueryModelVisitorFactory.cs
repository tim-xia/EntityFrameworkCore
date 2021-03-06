﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Query;

namespace Microsoft.EntityFrameworkCore.Cosmos.Sql.Query.Internal
{
    public class CosmosSqlEntityQueryModelVisitorFactory : EntityQueryModelVisitorFactory
    {
        public CosmosSqlEntityQueryModelVisitorFactory([NotNull] EntityQueryModelVisitorDependencies dependencies)
            : base(dependencies)
        {
        }

        public override EntityQueryModelVisitor Create(
            QueryCompilationContext queryCompilationContext, EntityQueryModelVisitor parentEntityQueryModelVisitor)
        {
            return new CosmosSqlQueryModelVisitor(Dependencies, queryCompilationContext);
        }
    }
}
