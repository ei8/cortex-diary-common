using System;
using System.Collections.Generic;
using System.Text;

namespace ei8.Cortex.Diary.Common
{
    public class Terminal
    {
        public Terminal()
        {
        }

        public Terminal(Terminal original)
        {
            this.Id = original.Id;
            this.PostsynapticNeuronId = original.PostsynapticNeuronId;
            this.PresynapticNeuronId = original.PresynapticNeuronId;
            this.Effect = original.Effect;
            this.Strength = original.Strength;
            this.Version = original.Version; 
            this.AuthorId = original.AuthorId;
            this.AuthorTag = original.AuthorTag;            
            this.Timestamp = original.Timestamp;
        }

        public string Id { get; set; }
        public string PresynapticNeuronId { get; set; }
        public string PostsynapticNeuronId { get; set; }
        public string Effect { get; set; }
        public string Strength { get; set; }
        public int Version { get; set; }
        public string AuthorId { get; set; }
        public string AuthorTag { get; set; }
        public string Timestamp { get; set; }
    }
}
