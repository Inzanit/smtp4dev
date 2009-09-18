﻿namespace Rnwood.SmtpServer.Extensions
{
    public abstract class Extension
    {
        public abstract ExtensionProcessor CreateExtensionProcessor(IConnectionProcessor processor);
    }

    public abstract class ExtensionProcessor
    {
        public abstract string[] GetEHLOKeywords();
    }
}