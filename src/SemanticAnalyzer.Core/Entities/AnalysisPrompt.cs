using SemanticAnalyzer.Core.Common.Entities;

namespace SemanticAnalyzer.Core.Entities;

/// <summary>
/// Represents an analysis prompt entity.
/// </summary>
public class AnalysisPrompt : IEntity, ICloneable<AnalysisPrompt>
{
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the prompt text.
    /// </summary>
    public string Prompt { get; set; } = default!;

    /// <summary>
    /// Gets or sets the version of the analysis prompt.
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the revision number of the analysis prompt.
    /// </summary>
    public int Revision { get; set; }

    /// <summary>
    /// Gets or sets the ID of the category to which the analysis prompt belongs.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the category of the analysis prompt.
    /// </summary>
    public AnalysisPromptCategory Category { get; set; } = default!;

    /// <summary>
    /// Gets or sets the collection of PromptExecutionHistory objects representing the execution histories.
    /// </summary>
    public IEnumerable<PromptExecutionHistory> ExecutionHistories { get; set; } = default!;
    
    /// <summary>
    /// Creates a deep clone of the analysis prompt.
    /// </summary>
    public AnalysisPrompt Clone()
    {
        return new AnalysisPrompt
        {
            Prompt = Prompt,
            Version = Version,
            Revision = Revision,
            CategoryId = CategoryId,
        };
    }
}
