﻿using System;
using Microsoft.CodeAnalysis.Text;

namespace MLS.Project.Execution
{
    public class SourceFile
    {
        public SourceText Text { get; }

        public string Name { get; }

        private SourceFile(SourceText text, string name)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Name = name;
        }

        public static SourceFile Create(string text, string name)
            => new SourceFile(
                SourceText.From(text), 
                name: name);
    }
}