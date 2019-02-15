using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OpenCover.Framework.Model
{
    /// <summary>
    /// A summary of results
    /// </summary>
    public class Summary
    {
        /// <summary>
        /// The number of sequence points
        /// </summary>
        [XmlIgnore]
        public int NumSequencePoints { get; set; }

        /// <summary>
        /// The number of sequence points visited
        /// </summary>
        [XmlIgnore]
        public int VisitedSequencePoints { get; set; }

        /// <summary>
        /// The number of branch points
        /// </summary>
        [XmlIgnore]
        public int NumBranchPoints { get; set; }

        /// <summary>
        /// The number of branch points visited
        /// </summary>
        [XmlIgnore]
        public int VisitedBranchPoints { get; set; }

        /// <summary>
        /// What is the sequence coverage?
        /// </summary>
        /// <remarks>Rounded for ease</remarks>
        [XmlIgnore]
        public decimal SequenceCoverage { get; set; }

        /// <summary>
        /// What is the branch coverage?
        /// </summary>
        /// <remarks>Rounded for ease</remarks>
        [XmlIgnore]
        public decimal BranchCoverage { get; set; }

        /// <summary>
        /// What is the maximum cyclomatic complexity.
        /// </summary>
        /// <remarks>Calculated using the Gendarme rules library</remarks>
        [XmlIgnore]
        public int MaxCyclomaticComplexity { get; set; }

        /// <summary>
        /// What is the minimum cyclomatic complexity.
        /// </summary>
        /// <remarks>Calculated using the Gendarme rules library</remarks>
        [XmlIgnore]
        public int MinCyclomaticComplexity { get; set; }

        /// <summary>
        /// What is the maximum crap score
        /// </summary>
        [XmlIgnore]
        public decimal MaxCrapScore { get; set; }

        /// <summary>
        /// What is the minimum crap score.
        /// </summary>
        [XmlIgnore]
        public decimal MinCrapScore { get; set; }

        /// <summary>
        /// What is the number of visited classes
        /// </summary>
        [XmlIgnore]
        public int VisitedClasses { get; set; }

        /// <summary>
        /// What is the total number of classes
        /// </summary>
        [XmlIgnore]
        public int NumClasses { get; set; }

        /// <summary>
        /// What is the number of visited methods
        /// </summary>
        [XmlIgnore]
        public int VisitedMethods { get; set; }

        /// <summary>
        /// What is the total number of methods
        /// </summary>
        [XmlIgnore]
        public int NumMethods { get; set; }

    }
}
