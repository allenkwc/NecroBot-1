using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace PoGo.NecroBot.Logic.Model.Settings
{
    [JsonObject(Title = "Player Config", Description = "Set your player settings.", ItemRequired = Required.DisallowNull)]
    public class PlayerConfig
    {
        internal enum Gender
        {
            Male,
            Female
        }

        internal enum Starter
        {
            Bulbasaur,
            Charmander,
            Squirtle
        }

        [ExcelConfig (Description ="Set delay time between any user action - overwrite by other specific action", Position = 1)]
        [DefaultValue(10000)]
        [Range(0, 999999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 1)]
        public int DelayBetweenPlayerActions = 10000;

        [ExcelConfig(Description = "Set delay time for evolve action", Position = 2)]
        [DefaultValue(30000)]
        [Range(0, 999999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 2)]
        public int EvolveActionDelay = 30000;

        [ExcelConfig(Description = "Set delay time for transfer action", Position = 3)]
        [DefaultValue(20000)]
        [Range(0, 999999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 3)]
        public int TransferActionDelay = 20000;

        [ExcelConfig(Description = "Set delay time for recycle item ", Position = 4)]
        [DefaultValue(25000)]
        [Range(0, 999999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 4)]
        public int RecycleActionDelay = 25000;

        [ExcelConfig(Description = "Set delay time for rename pokemon action", Position = 5)]
        [DefaultValue(60000)]
        [Range(0, 999999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 5)]
        public int RenamePokemonActionDelay = 60000;

        [ExcelConfig(Description = "Set delay time for random  action", Position = 6)]
        [DefaultValue(true)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 6)]
        public bool UseNearActionRandom = true;

        [ExcelConfig(Description = "Allow bot auto complete tutorial", Position = 7)]
        [DefaultValue(false)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 7)]
        public bool AutoCompleteTutorial;

        [ExcelConfig(Description = "Set nickname for bot account", Position = 8)]
        [DefaultValue("Nickname")]
        [MinLength(0)]
        [MaxLength(15)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 8)]
        public string DesiredNickname = "Nickname";

        [ExcelConfig(Description = "Set gender for bot acc", Position = 9)]
        [DefaultValue("Male")]
        [EnumDataType(typeof(Gender))]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 9)]
        public string DesiredGender = "Male";

        [ExcelConfig(Description = "Set default pokemon to catch when do first time tutorial", Position = 10)]
        [DefaultValue("Squirtle")]
        [EnumDataType(typeof(Starter))]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate, Order = 10)]
        public string DesiredStarter = "Squirtle";
    }
}