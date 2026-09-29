using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Input.TextInput
{
    internal interface IPlatformTextProcessorImpl
    {
        Task<IEnumerable<TextProcessingAction>> GetActions();

        Task<string?> ProcessText(object id, string text);
    }

    public record TextProcessingAction
    {
        public required object Id { get; init; }
        public required string Label { get; init; }
    }
}
