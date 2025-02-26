﻿namespace SurveyManager
{
    /// <summary>
    /// Opção de uma enquete
    /// </summary>
    class Option : IStorable, IEquatable<Option>
    {
        /// <summary>
        /// ID da opção (o que deve ser digitado para escolher a opção).
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Texto associado à opção.
        /// </summary>
        public string Text { get; set; }

        public void Save(BinaryWriter writer)
        {
            writer.Write(Id);
            writer.Write(Text);
        }

        public void Load(BinaryReader reader)
        {
            Id = reader.ReadString();
            Text = reader.ReadString();
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Option);
        }

        public bool Equals(Option? other)
        {
            if (other == null)
            {
                return false;
            }

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
