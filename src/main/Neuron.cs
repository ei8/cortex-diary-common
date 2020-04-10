using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace works.ei8.Cortex.Diary.Common
{
    public class Neuron : IEquatable<Neuron>
    {
        public Neuron()
        {
        }

        public Neuron(Neuron original)
        {
            this.Id = original.Id;
            this.Tag = original.Tag;

            if (original.Terminal != null)
                this.Terminal = new Terminal(original.Terminal);

            this.Version = original.Version;
            this.AuthorId = original.AuthorId;
            this.AuthorTag = original.AuthorTag;
            this.RegionId = original.RegionId;
            this.RegionTag = original.RegionTag;
            this.Timestamp = original.Timestamp;
            this.Errors = original.Errors;
        }

        [JsonIgnore]
        public int UIId { get; set; }

        [JsonIgnore]
        public int CentralUIId { get; set; }

        public override int GetHashCode()
        {
            return this.UIId.GetHashCode();
        }

        public bool Equals(Neuron other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return UIId == other.UIId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Neuron)obj);
        }

        public static bool operator ==(Neuron left, Neuron right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Neuron left, Neuron right)
        {
            return !Equals(left, right);
        }

        public string Id { get; set; }

        public string Tag { get; set; }

        public Terminal Terminal { get; set; }

        [JsonIgnore]
        public RelativeType Type => this.Terminal != null && this.Terminal.PresynapticNeuronId != null ?
            this.Terminal.PresynapticNeuronId.EndsWith(this.Id) ?
                RelativeType.Presynaptic :
                RelativeType.Postsynaptic :
            RelativeType.NotSet;

        public int Version { get; set; }

        public string AuthorId { get; set; }

        public string AuthorTag { get; set; }

        public string RegionId { get; set; }

        public string RegionTag { get; set; }

        public string Timestamp { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
