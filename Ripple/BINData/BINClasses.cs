using System.Collections.Generic;
using Fantome.Libraries.League.Helpers.Structures;

namespace Ripple.BIN.Classes
{
    public class MaxMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("mDrivers")] public List<IDynamicMaterialDriver> Drivers { get; set; }

        public MaxMaterialDriver()
        {

        }
    }
    public class Class_2355674 : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("mBuffName")] public string BuffName { get; set; }
        [BINValue("mCharacters")] public List<string> Characters { get; set; }
        [BINValue("mVFXResourceResolver")] public ResourceResolver VFXResourceResolver { get; set; }

        public Class_2355674()
        {

        }
    }
    public class ValueProcessorData
    {

        public ValueProcessorData()
        {

        }
    }
    public class SpellDataValue
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mValues")] public List<float> Values { get; set; }

        public SpellDataValue()
        {

        }
    }
    public class VfxTrailDefinitionData
    {
        [BINValue("mMode")] public uint Mode { get; set; }
        [BINValue("mCutoff")] public float Cutoff { get; set; }
        [BINValue("mBirthTilingSize")] public ValueVector3 BirthTilingSize { get; set; }
        [BINValue("mSmoothingMode")] public byte SmoothingMode { get; set; }
        [BINValue("mMaxAddedPerFrame")] public int MaxAddedPerFrame { get; set; }

        public VfxTrailDefinitionData()
        {

        }
    }
    public class Class_15175742 : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue(37483237)] public List<Class_3719146242> m37483237 { get; set; }

        public Class_15175742()
        {

        }
    }
    public class Class_19256412
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("type")] public uint Type { get; set; }
        [BINValue(967958004)] public uint m967958004 { get; set; }
        [BINValue(761819584)] public int m761819584 { get; set; }
        [BINValue(1757672278)] public bool m1757672278 { get; set; }
        [BINValue(3548357530)] public uint m3548357530 { get; set; }

        public Class_19256412()
        {

        }
    }
    public class Class_30889102
    {
        [BINValue(3509153429)] public float m3509153429 { get; set; }
        [BINValue(1838159659)] public float m1838159659 { get; set; }
        [BINValue(1494391998)] public float m1494391998 { get; set; }
        [BINValue(3797316178)] public float m3797316178 { get; set; }
        [BINValue(3110014664)] public float m3110014664 { get; set; }
        [BINValue(1018083252)] public float m1018083252 { get; set; }

        public Class_30889102()
        {

        }
    }
    public class ForEachInCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("SortedByKeys")] public bool SortedByKeys { get; set; }
        [BINValue("OutKey")] public ScriptTableSet OutKey { get; set; }
        [BINValue("OutValue")] public ScriptTableSet OutValue { get; set; }
        [BINValue("Sequence")] public ScriptSequence Sequence { get; set; }

        public ForEachInCustomTableBlock()
        {

        }
    }
    public class MapPointLight : MapPlaceable
    {
        [BINValue("type")] public Link<MapPointLightType> Type { get; set; }
        [BINValue("radiusScale")] public float RadiusScale { get; set; }
        [BINValue("intensityScale")] public float IntensityScale { get; set; }
        [BINValue("overrideCastStaticShadows")] public Optional<bool> OverrideCastStaticShadows { get; set; }
        [BINValue("overrideUseSpecular")] public Optional<bool> OverrideUseSpecular { get; set; }

        public MapPointLight()
        {

        }
    }
    public interface IVfxMaterialDriver
    {
    }
    public class HasAtleastNSubRequirementsCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mSuccessesRequired")] public uint SuccessesRequired { get; set; }
        [BINValue("mSubRequirements")] public List<ICastRequirement> SubRequirements { get; set; }

        public HasAtleastNSubRequirementsCastRequirement()
        {

        }
    }
    public class FloatingTextTypeList
    {
        [BINValue("Invulnerable")] public Link<FloatTextFormattingData> Invulnerable { get; set; }
        [BINValue("Special")] public Link<FloatTextFormattingData> Special { get; set; }
        [BINValue("Heal")] public Link<FloatTextFormattingData> Heal { get; set; }
        [BINValue("ManaHeal")] public Link<FloatTextFormattingData> ManaHeal { get; set; }
        [BINValue("ManaDamage")] public Link<FloatTextFormattingData> ManaDamage { get; set; }
        [BINValue("Dodge")] public Link<FloatTextFormattingData> Dodge { get; set; }
        [BINValue("PhysicalDamageCritical")] public Link<FloatTextFormattingData> PhysicalDamageCritical { get; set; }
        [BINValue("MagicalDamageCritical")] public Link<FloatTextFormattingData> MagicalDamageCritical { get; set; }
        [BINValue("TrueDamageCritical")] public Link<FloatTextFormattingData> TrueDamageCritical { get; set; }
        [BINValue("Experience")] public Link<FloatTextFormattingData> Experience { get; set; }
        [BINValue("Gold")] public Link<FloatTextFormattingData> Gold { get; set; }
        [BINValue("level")] public Link<FloatTextFormattingData> Level { get; set; }
        [BINValue("Disable")] public Link<FloatTextFormattingData> Disable { get; set; }
        [BINValue("QuestReceived")] public Link<FloatTextFormattingData> QuestReceived { get; set; }
        [BINValue("QuestComplete")] public Link<FloatTextFormattingData> QuestComplete { get; set; }
        [BINValue("Score")] public Link<FloatTextFormattingData> Score { get; set; }
        [BINValue("PhysicalDamage")] public Link<FloatTextFormattingData> PhysicalDamage { get; set; }
        [BINValue("MagicalDamage")] public Link<FloatTextFormattingData> MagicalDamage { get; set; }
        [BINValue("TrueDamage")] public Link<FloatTextFormattingData> TrueDamage { get; set; }
        [BINValue("EnemyPhysicalDamage")] public Link<FloatTextFormattingData> EnemyPhysicalDamage { get; set; }
        [BINValue("EnemyMagicalDamage")] public Link<FloatTextFormattingData> EnemyMagicalDamage { get; set; }
        [BINValue("EnemyTrueDamage")] public Link<FloatTextFormattingData> EnemyTrueDamage { get; set; }
        [BINValue("EnemyPhysicalDamageCritical")] public Link<FloatTextFormattingData> EnemyPhysicalDamageCritical { get; set; }
        [BINValue("EnemyMagicalDamageCritical")] public Link<FloatTextFormattingData> EnemyMagicalDamageCritical { get; set; }
        [BINValue("EnemyTrueDamageCritical")] public Link<FloatTextFormattingData> EnemyTrueDamageCritical { get; set; }
        [BINValue("Countdown")] public Link<FloatTextFormattingData> Countdown { get; set; }
        [BINValue("OMW")] public Link<FloatTextFormattingData> OMW { get; set; }
        [BINValue("Absorbed")] public Link<FloatTextFormattingData> Absorbed { get; set; }
        [BINValue("Debug")] public Link<FloatTextFormattingData> Debug { get; set; }
        [BINValue("PracticeToolTotal")] public Link<FloatTextFormattingData> PracticeToolTotal { get; set; }
        [BINValue("PracticeToolLastHit")] public Link<FloatTextFormattingData> PracticeToolLastHit { get; set; }
        [BINValue("PracticeToolDPS")] public Link<FloatTextFormattingData> PracticeToolDPS { get; set; }
        [BINValue("ScoreDarkStar")] public Link<FloatTextFormattingData> ScoreDarkStar { get; set; }
        [BINValue("ScoreProject0")] public Link<FloatTextFormattingData> ScoreProject0 { get; set; }
        [BINValue("ScoreProject1")] public Link<FloatTextFormattingData> ScoreProject1 { get; set; }
        [BINValue("ShieldBonusDamage")] public Link<FloatTextFormattingData> ShieldBonusDamage { get; set; }

        public FloatingTextTypeList()
        {

        }
    }
    public class ContextualConditionCharacterPlayingEmote : ICharacterSubcondition
    {
        [BINValue("mEmoteID")] public byte EmoteID { get; set; }

        public ContextualConditionCharacterPlayingEmote()
        {

        }
    }
    public class MinimapIconColorData
    {
        [BINValue("mBase")] public ColorRGBAVector4Byte Base { get; set; }
        [BINValue("mColorblind")] public Optional<ColorRGBAVector4Byte> Colorblind { get; set; }

        public MinimapIconColorData()
        {

        }
    }
    public class CircleMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mRadialVelocity")] public float RadialVelocity { get; set; }
        [BINValue("mAngularVelocity")] public float AngularVelocity { get; set; }
        [BINValue("mLinearVelocity")] public float LinearVelocity { get; set; }
        [BINValue("mLifetime")] public float Lifetime { get; set; }

        public CircleMovement()
        {

        }
    }
    public class Class_60771964
    {
        [BINValue("mSceneTransition")] public HudMenuTransitionData SceneTransition { get; set; }
        [BINValue("mProgressBarEaseRate")] public float ProgressBarEaseRate { get; set; }
        [BINValue(822033641)] public string m822033641 { get; set; }
        [BINValue(3286494379)] public string m3286494379 { get; set; }
        [BINValue("mUnitBarFadeSpeed")] public float UnitBarFadeSpeed { get; set; }
        [BINValue(1070132460)] public bool m1070132460 { get; set; }
        [BINValue(3428022377)] public string m3428022377 { get; set; }
        [BINValue(1663411567)] public string m1663411567 { get; set; }
        [BINValue("mPipsHoverText")] public string PipsHoverText { get; set; }

        public Class_60771964()
        {

        }
    }
    public class Class_62039180 : IDynamicMaterialBoolDriver
    {
        [BINValue(2046475623)] public float m2046475623 { get; set; }
        [BINValue("mBoolDriver")] public IDynamicMaterialBoolDriver BoolDriver { get; set; }

        public Class_62039180()
        {

        }
    }
    public interface Class_66354938 : MapComponent
    {
    }
    public class ValueFloat
    {
        [BINValue("constantValue")] public float ConstantValue { get; set; }
        [BINValue("dynamics")] public VfxAnimatedFloatVariableData Dynamics { get; set; }

        public ValueFloat()
        {

        }
    }
    public interface MapComponent
    {
    }
    public class TargeterDefinitionRange : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("centerLocator")] public DrawablePositionLocator CenterLocator { get; set; }
        [BINValue("textureOrientation")] public uint TextureOrientation { get; set; }
        [BINValue("hideWithLineIndicator")] public bool HideWithLineIndicator { get; set; }
        [BINValue("hasMaxGrowRange")] public bool HasMaxGrowRange { get; set; }
        [BINValue("useCasterBoundingBox")] public Optional<bool> UseCasterBoundingBox { get; set; }
        [BINValue("overrideBaseRange")] public FloatPerSpellLevel OverrideBaseRange { get; set; }
        [BINValue("rangeGrowthStartTime")] public FloatPerSpellLevel RangeGrowthStartTime { get; set; }
        [BINValue("rangeGrowthDuration")] public FloatPerSpellLevel RangeGrowthDuration { get; set; }
        [BINValue("rangeGrowthMax")] public FloatPerSpellLevel RangeGrowthMax { get; set; }
        [BINValue("textureOverrideName")] public string TextureOverrideName { get; set; }
        [BINValue("textureMaxGrowName")] public string TextureMaxGrowName { get; set; }

        public TargeterDefinitionRange()
        {

        }
    }
    public class HudHealthBarData
    {
        [BINValue("burstData")] public HudHealthBarBurstData BurstData { get; set; }
        [BINValue("towerBurstData")] public HudHealthBarBurstData TowerBurstData { get; set; }
        [BINValue("burstHealData")] public HudHealthBarBurstHealData BurstHealData { get; set; }
        [BINValue("championProgressiveTickData")] public HudHealthBarProgressiveTickData ChampionProgressiveTickData { get; set; }
        [BINValue("fadeData")] public HudHealthBarFadeData FadeData { get; set; }
        [BINValue("defenseModifierData")] public HudHealthBarDefenseModifierData DefenseModifierData { get; set; }
        [BINValue("defenseIconData")] public HudHealthBarDefenseIconData DefenseIconData { get; set; }
        [BINValue("untargetableAlpha")] public float UntargetableAlpha { get; set; }
        [BINValue("resurrectingAlpha")] public float ResurrectingAlpha { get; set; }

        public HudHealthBarData()
        {

        }
    }
    public class ParticleEventData : BaseEventData
    {
        [BINValue("mEffectKey")] public Hash EffectKey { get; set; }
        [BINValue("mEnemyEffectKey")] public Hash EnemyEffectKey { get; set; }
        [BINValue("mEffectName")] public string EffectName { get; set; }
        [BINValue("mParticleEventDataPairList")] public List<ParticleEventDataPair> ParticleEventDataPairList { get; set; }
        [BINValue("mIsLoop")] public bool IsLoop { get; set; }
        [BINValue("mIsKillEvent")] public bool IsKillEvent { get; set; }
        [BINValue("mIsDetachable")] public bool IsDetachable { get; set; }
        [BINValue("mScalePlaySpeedWithAnimation")] public bool ScalePlaySpeedWithAnimation { get; set; }

        public ParticleEventData()
        {

        }
    }
    public class ContextualConditionNeutralMinionMapSide : IContextualCondition
    {
        [BINValue("mTeamCompareOp")] public byte TeamCompareOp { get; set; }

        public ContextualConditionNeutralMinionMapSide()
        {

        }
    }
    public class StaticMaterialTechniqueDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("passes")] public List<StaticMaterialPassDef> Passes { get; set; }

        public StaticMaterialTechniqueDef()
        {

        }
    }
    public class FixedSpeedMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mInferDirectionFromFacingIfNeeded")] public bool InferDirectionFromFacingIfNeeded { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mUseGroundHeightAtTarget")] public bool UseGroundHeightAtTarget { get; set; }
        [BINValue("mSpeed")] public float Speed { get; set; }

        public FixedSpeedMovement()
        {

        }
    }
    public class MicroTicksPerTickData
    {
        [BINValue("minHealth")] public float MinHealth { get; set; }
        [BINValue("microTicksBetween")] public uint MicroTicksBetween { get; set; }

        public MicroTicksPerTickData()
        {

        }
    }
    public class DestroyOnHit : MissileBehaviorSpec
    {

        public DestroyOnHit()
        {

        }
    }
    public class AttackSlotData
    {
        [BINValue("mAttackTotalTime")] public Optional<float> AttackTotalTime { get; set; }
        [BINValue("mAttackCastTime")] public Optional<float> AttackCastTime { get; set; }
        [BINValue("mAttackDelayCastOffsetPercent")] public Optional<float> AttackDelayCastOffsetPercent { get; set; }
        [BINValue("mAttackDelayCastOffsetPercentAttackSpeedRatio")] public Optional<float> AttackDelayCastOffsetPercentAttackSpeedRatio { get; set; }
        [BINValue("mAttackProbability")] public Optional<float> AttackProbability { get; set; }
        [BINValue("mAttackName")] public Optional<string> AttackName { get; set; }

        public AttackSlotData()
        {

        }
    }
    public class Class_118371731 : Class_389493299
    {
        [BINValue("mMultiplier")] public Class_3053458126 Multiplier { get; set; }
        [BINValue(3419063832)] public byte m3419063832 { get; set; }
        [BINValue(923208333)] public byte m923208333 { get; set; }
        [BINValue("mOverrideSpellLevel")] public Optional<int> OverrideSpellLevel { get; set; }
        [BINValue(2140393294)] public Hash m2140393294 { get; set; }

        public Class_118371731()
        {

        }
    }
    public class TargeterDefinitionMultiAOE : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("centerLocator")] public DrawablePositionLocator CenterLocator { get; set; }
        [BINValue("overrideAOERadius")] public FloatPerSpellLevel OverrideAOERadius { get; set; }
        [BINValue("overrideMinCastRange")] public FloatPerSpellLevel OverrideMinCastRange { get; set; }
        [BINValue("overrideMaxCastRange")] public FloatPerSpellLevel OverrideMaxCastRange { get; set; }
        [BINValue("angelOffsetRadian")] public float AngelOffsetRadian { get; set; }
        [BINValue("numOfInnerAOE")] public uint NumOfInnerAOE { get; set; }
        [BINValue("leftTextureName")] public string LeftTextureName { get; set; }
        [BINValue("rightTextureName")] public string RightTextureName { get; set; }
        [BINValue("innerTextureName")] public string InnerTextureName { get; set; }

        public TargeterDefinitionMultiAOE()
        {

        }
    }
    public class DynamicMaterialParameterDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("enabled")] public bool Enabled { get; set; }
        [BINValue("driver")] public IDynamicMaterialDriver Driver { get; set; }

        public DynamicMaterialParameterDef()
        {

        }
    }
    public class ValueColor
    {
        [BINValue("constantValue")] public Vector4 ConstantValue { get; set; }
        [BINValue("dynamics")] public VfxAnimatedColorVariableData Dynamics { get; set; }

        public ValueColor()
        {

        }
    }
    public class EnableLookAtEventData : BaseEventData
    {
        [BINValue("mEnableLookAt")] public bool EnableLookAt { get; set; }
        [BINValue("mLockCurrentValues")] public bool LockCurrentValues { get; set; }

        public EnableLookAtEventData()
        {

        }
    }
    public class CharacterLevelRequirement : ISpellRankUpRequirement
    {
        [BINValue("mLevel")] public uint Level { get; set; }

        public CharacterLevelRequirement()
        {

        }
    }
    public class IsAnimationPlayingDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mAnimationNames")] public List<Hash> AnimationNames { get; set; }

        public IsAnimationPlayingDynamicMaterialBoolDriver()
        {

        }
    }
    public class StaticMaterialShaderSamplerDef
    {
        [BINValue("samplerName")] public string SamplerName { get; set; }
        [BINValue("textureName")] public string TextureName { get; set; }
        [BINValue("uncensoredTextures")] public Dictionary<Hash, string> UncensoredTextures { get; set; }
        [BINValue("addressU")] public uint AddressU { get; set; }
        [BINValue("addressV")] public uint AddressV { get; set; }
        [BINValue("addressW")] public uint AddressW { get; set; }
        [BINValue("filterMin")] public uint FilterMin { get; set; }
        [BINValue("filterMip")] public uint FilterMip { get; set; }
        [BINValue("filterMag")] public uint FilterMag { get; set; }

        public StaticMaterialShaderSamplerDef()
        {

        }
    }
    public class ContextualConditionMapID : IContextualCondition
    {
        [BINValue("mMapIDs")] public uint MapIDs { get; set; }

        public ContextualConditionMapID()
        {

        }
    }
    public class VfxEmitterDefinitionData
    {
        [BINValue("soundOnCreateName")] public string SoundOnCreateName { get; set; }
        [BINValue("soundPersistentName")] public string SoundPersistentName { get; set; }
        [BINValue("voiceOverOnCreateName")] public string VoiceOverOnCreateName { get; set; }
        [BINValue("voiceOverPersistentName")] public string VoiceOverPersistentName { get; set; }
        [BINValue("timeBeforeFirstEmission")] public float TimeBeforeFirstEmission { get; set; }
        [BINValue(3472013936)] public float m3472013936 { get; set; }
        [BINValue("rate")] public ValueFloat Rate { get; set; }
        [BINValue(1401880484)] public bool m1401880484 { get; set; }
        [BINValue("particleLifetime")] public ValueFloat ParticleLifetime { get; set; }
        [BINValue("particleLingerType")] public uint ParticleLingerType { get; set; }
        [BINValue("particleLinger")] public Optional<float> ParticleLinger { get; set; }
        [BINValue("lifetime")] public Optional<float> Lifetime { get; set; }
        [BINValue("isSingleParticle")] public bool IsSingleParticle { get; set; }
        [BINValue("emitterLinger")] public Optional<float> EmitterLinger { get; set; }
        [BINValue("excludedAttachmentTypes")] public List<string> ExcludedAttachmentTypes { get; set; }
        [BINValue("period")] public Optional<float> Period { get; set; }
        [BINValue("timeActiveDuringPeriod")] public Optional<float> TimeActiveDuringPeriod { get; set; }
        [BINValue("rateByVelocityFunction")] public ValueVector2 RateByVelocityFunction { get; set; }
        [BINValue(3338279773)] public Optional<float> m3338279773 { get; set; }
        [BINValue("offsetLifetimeScaling")] public Vector3 OffsetLifetimeScaling { get; set; }
        [BINValue("offsetLifeScalingSymmetryMode")] public uint OffsetLifeScalingSymmetryMode { get; set; }
        [BINValue("doesLifetimeScale")] public bool DoesLifetimeScale { get; set; }
        [BINValue("flexRate")] public FlexValueFloat FlexRate { get; set; }
        [BINValue("flexParticleLifetime")] public FlexValueFloat FlexParticleLifetime { get; set; }
        [BINValue("doesParticleLifetimeScale")] public bool DoesParticleLifetimeScale { get; set; }
        [BINValue("emissionSurfaceDefinition")] public VfxEmissionSurfaceData EmissionSurfaceDefinition { get; set; }
        [BINValue("childParticleSetDefinition")] public VfxChildParticleSetDefinitionData ChildParticleSetDefinition { get; set; }
        [BINValue("fieldCollectionDefinition")] public VfxFieldCollectionDefinitionData FieldCollectionDefinition { get; set; }
        [BINValue("emitterName")] public string EmitterName { get; set; }
        [BINValue("disabled")] public bool Disabled { get; set; }
        [BINValue("importance")] public uint Importance { get; set; }
        [BINValue("keywordsRequired")] public List<string> KeywordsRequired { get; set; }
        [BINValue("keywordsExcluded")] public List<string> KeywordsExcluded { get; set; }
        [BINValue("keywordsIncluded")] public List<string> KeywordsIncluded { get; set; }
        [BINValue("spectatorPolicy")] public uint SpectatorPolicy { get; set; }
        [BINValue("censorPolicy")] public uint CensorPolicy { get; set; }
        [BINValue("translationOverride")] public Vector3 TranslationOverride { get; set; }
        [BINValue("rotationOverride")] public Vector3 RotationOverride { get; set; }
        [BINValue("birthOrbitalVelocity")] public ValueVector3 BirthOrbitalVelocity { get; set; }
        [BINValue("birthVelocity")] public ValueVector3 BirthVelocity { get; set; }
        [BINValue("birthDrag")] public ValueVector3 BirthDrag { get; set; }
        [BINValue("birthAcceleration")] public ValueVector3 BirthAcceleration { get; set; }
        [BINValue("velocity")] public ValueVector3 Velocity { get; set; }
        [BINValue("drag")] public ValueVector3 Drag { get; set; }
        [BINValue("acceleration")] public ValueVector3 Acceleration { get; set; }
        [BINValue(848541616)] public bool m848541616 { get; set; }
        [BINValue(160052109)] public ValueVector3 m160052109 { get; set; }
        [BINValue(3007716357)] public bool m3007716357 { get; set; }
        [BINValue(4207272600)] public ValueVector3 m4207272600 { get; set; }
        [BINValue(4071846627)] public bool m4071846627 { get; set; }
        [BINValue(3751201134)] public ValueVector3 m3751201134 { get; set; }
        [BINValue("flexBirthVelocity")] public FlexValueVector3 FlexBirthVelocity { get; set; }
        [BINValue("worldAcceleration")] public IntegratedValueVector3 WorldAcceleration { get; set; }
        [BINValue("shape")] public VfxShape Shape { get; set; }
        [BINValue("bindWeight")] public ValueFloat BindWeight { get; set; }
        [BINValue("scaleEmitOffsetByBoundObjectSize")] public float ScaleEmitOffsetByBoundObjectSize { get; set; }
        [BINValue("emissionMeshScale")] public float EmissionMeshScale { get; set; }
        [BINValue("emissionMeshName")] public string EmissionMeshName { get; set; }
        [BINValue("scaleEmitOffsetByBoundObjectHeight")] public float ScaleEmitOffsetByBoundObjectHeight { get; set; }
        [BINValue("scaleEmitOffsetByBoundObjectRadius")] public float ScaleEmitOffsetByBoundObjectRadius { get; set; }
        [BINValue("flexOffset")] public FlexValueVector3 FlexOffset { get; set; }
        [BINValue("flexBirthTranslation")] public FlexValueVector3 FlexBirthTranslation { get; set; }
        [BINValue("material")] public Link<StaticMaterialDef> Material { get; set; }
        [BINValue("materialDrivers")] public Dictionary<string, IVfxMaterialDriver> MaterialDrivers { get; set; }
        [BINValue("renderPhaseOverride")] public uint RenderPhaseOverride { get; set; }
        [BINValue("primitive")] public VfxPrimitiveBase Primitive { get; set; }
        [BINValue("falloffTexture")] public string FalloffTexture { get; set; }
        [BINValue("particleColorTexture")] public string ParticleColorTexture { get; set; }
        [BINValue("blendMode")] public uint BlendMode { get; set; }
        [BINValue("birthColor")] public ValueColor BirthColor { get; set; }
        [BINValue("color")] public ValueColor Color { get; set; }
        [BINValue(452491014)] public bool m452491014 { get; set; }
        [BINValue("lingerColor")] public ValueColor LingerColor { get; set; }
        [BINValue("pass")] public int Pass { get; set; }
        [BINValue("meshRenderFlags")] public ushort MeshRenderFlags { get; set; }
        [BINValue("colorLookUpTypeX")] public uint ColorLookUpTypeX { get; set; }
        [BINValue("colorLookUpTypeY")] public uint ColorLookUpTypeY { get; set; }
        [BINValue("colorLookUpScales")] public Vector2 ColorLookUpScales { get; set; }
        [BINValue("alphaRef")] public int AlphaRef { get; set; }
        [BINValue("colorLookUpOffsets")] public Vector2 ColorLookUpOffsets { get; set; }
        [BINValue("softParticleParams")] public VfxSoftParticleDefinitionData SoftParticleParams { get; set; }
        [BINValue("colorRenderFlags")] public ushort ColorRenderFlags { get; set; }
        [BINValue("censorModulateValue")] public Vector4 CensorModulateValue { get; set; }
        [BINValue("sliceTechniqueRange")] public float SliceTechniqueRange { get; set; }
        [BINValue("modulationFactor")] public Vector4 ModulationFactor { get; set; }
        [BINValue("alphaErosionDefinition")] public VfxAlphaErosionDefinitionData AlphaErosionDefinition { get; set; }
        [BINValue("reflectionDefinition")] public VfxReflectionDefinitionData ReflectionDefinition { get; set; }
        [BINValue("distortionDefinition")] public VfxDistortionDefinitionData DistortionDefinition { get; set; }
        [BINValue("isTexturePixelated")] public bool IsTexturePixelated { get; set; }
        [BINValue("uvParallaxScale")] public float UvParallaxScale { get; set; }
        [BINValue("depthBiasFactors")] public Vector2 DepthBiasFactors { get; set; }
        [BINValue("disableBackfaceCull")] public bool DisableBackfaceCull { get; set; }
        [BINValue("bState")] public uint BState { get; set; }
        [BINValue("miscRenderFlags")] public ushort MiscRenderFlags { get; set; }
        [BINValue("stencilMode")] public uint StencilMode { get; set; }
        [BINValue("stencilRef")] public uint StencilRef { get; set; }
        [BINValue("uvScrollAlphaMult")] public bool UvScrollAlphaMult { get; set; }
        [BINValue("particleIsLocalOrientation")] public bool ParticleIsLocalOrientation { get; set; }
        [BINValue("isDirectionOriented")] public bool IsDirectionOriented { get; set; }
        [BINValue("isUniformScale")] public bool IsUniformScale { get; set; }
        [BINValue("hasPostRotateOrientation")] public bool HasPostRotateOrientation { get; set; }
        [BINValue("isRandomStartFrame")] public bool IsRandomStartFrame { get; set; }
        [BINValue("isRandomStartFrameMult")] public bool IsRandomStartFrameMult { get; set; }
        [BINValue("doesCastShadow")] public bool DoesCastShadow { get; set; }
        [BINValue("isRotationEnabled")] public bool IsRotationEnabled { get; set; }
        [BINValue("uvScrollClamp")] public bool UvScrollClamp { get; set; }
        [BINValue("uvScrollClampMult")] public bool UvScrollClampMult { get; set; }
        [BINValue("isFollowingTerrain")] public bool IsFollowingTerrain { get; set; }
        [BINValue("isGroundLayer")] public bool IsGroundLayer { get; set; }
        [BINValue("useEmissionMeshNormalForBirth")] public bool UseEmissionMeshNormalForBirth { get; set; }
        [BINValue("useNavmeshMask")] public bool UseNavmeshMask { get; set; }
        [BINValue(1734953377)] public bool m1734953377 { get; set; }
        [BINValue(3181085639)] public bool m3181085639 { get; set; }
        [BINValue("birthRotation0")] public ValueVector3 BirthRotation0 { get; set; }
        [BINValue("birthRotationalVelocity0")] public ValueVector3 BirthRotationalVelocity0 { get; set; }
        [BINValue(3730513113)] public bool m3730513113 { get; set; }
        [BINValue(1751193500)] public ValueVector3 m1751193500 { get; set; }
        [BINValue("isLocalOrientation")] public bool IsLocalOrientation { get; set; }
        [BINValue("directionVelocityScale")] public float DirectionVelocityScale { get; set; }
        [BINValue("directionVelocityMinScale")] public float DirectionVelocityMinScale { get; set; }
        [BINValue("postRotateOrientationAxis")] public Vector3 PostRotateOrientationAxis { get; set; }
        [BINValue("birthRotationalAcceleration")] public ValueVector3 BirthRotationalAcceleration { get; set; }
        [BINValue("flexBirthRotationalVelocity0")] public FlexValueVector3 FlexBirthRotationalVelocity0 { get; set; }
        [BINValue("rotation0")] public IntegratedValueVector3 Rotation0 { get; set; }
        [BINValue("birthScale0")] public ValueVector3 BirthScale0 { get; set; }
        [BINValue("scale0")] public ValueVector3 Scale0 { get; set; }
        [BINValue(1582117303)] public bool m1582117303 { get; set; }
        [BINValue(2106505348)] public ValueVector3 m2106505348 { get; set; }
        [BINValue("scaleBirthScaleByBoundObjectSize")] public float ScaleBirthScaleByBoundObjectSize { get; set; }
        [BINValue("scaleBirthScaleByBoundObjectRadius")] public float ScaleBirthScaleByBoundObjectRadius { get; set; }
        [BINValue("flexScaleBirthScale")] public FlexTypeFloat FlexScaleBirthScale { get; set; }
        [BINValue("flexScaleEmitOffset")] public FlexTypeFloat FlexScaleEmitOffset { get; set; }
        [BINValue(2172495129)] public FlexTypeFloat m2172495129 { get; set; }
        [BINValue("scaleBirthScaleByBoundObjectHeight")] public float ScaleBirthScaleByBoundObjectHeight { get; set; }
        [BINValue("texture")] public string Texture { get; set; }
        [BINValue("meshTextureName")] public string MeshTextureName { get; set; }
        [BINValue("frameRate")] public float FrameRate { get; set; }
        [BINValue("birthFrameRate")] public ValueFloat BirthFrameRate { get; set; }
        [BINValue("numFrames")] public int NumFrames { get; set; }
        [BINValue("startFrame")] public int StartFrame { get; set; }
        [BINValue("uvMode")] public uint UvMode { get; set; }
        [BINValue("paletteDefinition")] public VfxPaletteDefinitionData PaletteDefinition { get; set; }
        [BINValue("materialOverrideDefinitions")] public List<VfxMaterialOverrideDefinitionData> MaterialOverrideDefinitions { get; set; }
        [BINValue("birthUvScrollRate")] public ValueVector2 BirthUvScrollRate { get; set; }
        [BINValue("flexBirthUVScrollRate")] public FlexValueVector2 FlexBirthUVScrollRate { get; set; }
        [BINValue("birthUVOffset")] public ValueVector2 BirthUVOffset { get; set; }
        [BINValue("texAddressModeBase")] public uint TexAddressModeBase { get; set; }
        [BINValue("texDiv")] public Vector2 TexDiv { get; set; }
        [BINValue("particleUVScrollRate")] public IntegratedValueVector2 ParticleUVScrollRate { get; set; }
        [BINValue("emitterUvScrollRate")] public Vector2 EmitterUvScrollRate { get; set; }
        [BINValue("flexBirthUVOffset")] public FlexValueVector2 FlexBirthUVOffset { get; set; }
        [BINValue("uvScale")] public ValueVector2 UvScale { get; set; }
        [BINValue("uvRotation")] public ValueFloat UvRotation { get; set; }
        [BINValue("birthUvRotateRate")] public ValueFloat BirthUvRotateRate { get; set; }
        [BINValue("particleUVRotateRate")] public IntegratedValueFloat ParticleUVRotateRate { get; set; }
        [BINValue("uvTransformCenter")] public Vector2 UvTransformCenter { get; set; }
        [BINValue("textureMult")] public string TextureMult { get; set; }
        [BINValue("frameRateMult")] public float FrameRateMult { get; set; }
        [BINValue("numFramesMult")] public int NumFramesMult { get; set; }
        [BINValue("startFrameMult")] public int StartFrameMult { get; set; }
        [BINValue("birthUvScrollRateMult")] public ValueVector2 BirthUvScrollRateMult { get; set; }
        [BINValue("birthUVOffsetMult")] public ValueVector2 BirthUVOffsetMult { get; set; }
        [BINValue("texAddressModeMult")] public uint TexAddressModeMult { get; set; }
        [BINValue("texDivMult")] public Vector2 TexDivMult { get; set; }
        [BINValue("uvScaleMult")] public ValueVector2 UvScaleMult { get; set; }
        [BINValue("birthUvRotateRateMult")] public ValueFloat BirthUvRotateRateMult { get; set; }
        [BINValue("particleUVRotateRateMult")] public IntegratedValueFloat ParticleUVRotateRateMult { get; set; }
        [BINValue("uvTransformCenterMult")] public Vector2 UvTransformCenterMult { get; set; }
        [BINValue("particleUVScrollRateMult")] public IntegratedValueVector2 ParticleUVScrollRateMult { get; set; }
        [BINValue("emitterUvScrollRateMult")] public Vector2 EmitterUvScrollRateMult { get; set; }
        [BINValue("flexBirthUVScrollRateMult")] public FlexValueVector2 FlexBirthUVScrollRateMult { get; set; }
        [BINValue("scaleOverride")] public Vector3 ScaleOverride { get; set; }
        [BINValue("birthScale1")] public ValueFloat BirthScale1 { get; set; }
        [BINValue("scale1")] public ValueFloat Scale1 { get; set; }
        [BINValue("birthRotation1")] public ValueFloat BirthRotation1 { get; set; }
        [BINValue("particleBind")] public Vector2 ParticleBind { get; set; }
        [BINValue("birthRotationalVelocity1")] public ValueFloat BirthRotationalVelocity1 { get; set; }
        [BINValue("orientation")] public uint Orientation { get; set; }
        [BINValue("rotation1")] public ValueFloat Rotation1 { get; set; }
        [BINValue("scaleBias")] public Vector2 ScaleBias { get; set; }
        [BINValue("uvScrollRate1")] public Vector2 UvScrollRate1 { get; set; }
        [BINValue("hasFixedOrbit")] public bool HasFixedOrbit { get; set; }
        [BINValue("textureAddressModeBase")] public uint TextureAddressModeBase { get; set; }
        [BINValue("fixedOrbitType")] public uint FixedOrbitType { get; set; }
        [BINValue("scaleUpFromOrigin")] public bool ScaleUpFromOrigin { get; set; }
        [BINValue("lockedToEmitter")] public bool LockedToEmitter { get; set; }
        [BINValue("scaleAlongMovementVector")] public float ScaleAlongMovementVector { get; set; }
        [BINValue("flexBirthRotationalVelocity1")] public FlexValueFloat FlexBirthRotationalVelocity1 { get; set; }

        public VfxEmitterDefinitionData()
        {

        }
    }
    public class VfxFieldAccelerationDefinitionData
    {
        [BINValue("isLocalSpace")] public bool IsLocalSpace { get; set; }
        [BINValue("acceleration")] public ValueVector3 Acceleration { get; set; }

        public VfxFieldAccelerationDefinitionData()
        {

        }
    }
    public class EffectGlowingRotatingIconElementData : EffectRotatingIconElementData
    {
        [BINValue("CycleTime")] public float CycleTime { get; set; }
        [BINValue(88872846)] public float m88872846 { get; set; }

        public EffectGlowingRotatingIconElementData()
        {

        }
    }
    public class Class_183658092 : Class_2144288560
    {

        public Class_183658092()
        {

        }
    }
    public class CursorData
    {
        [BINValue("mHotSpot")] public Vector2 HotSpot { get; set; }
        [BINValue("mTextureName")] public string TextureName { get; set; }
        [BINValue(3527462479)] public string m3527462479 { get; set; }

        public CursorData()
        {

        }
    }
    public class ContextualConditionCharacterHealth : ICharacterSubcondition
    {
        [BINValue("mTargetHealth")] public float TargetHealth { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionCharacterHealth()
        {

        }
    }
    public interface IShaderDef
    {
        [BINValue("parameters")] List<ShaderPhysicalParameter> Parameters { get; set; }
        [BINValue("staticSwitches")] List<ShaderStaticSwitch> StaticSwitches { get; set; }
        [BINValue("textures")] List<ShaderTexture> Textures { get; set; }
        [BINValue("featureDefines")] Dictionary<string, string> FeatureDefines { get; set; }
        [BINValue("featureMask")] uint FeatureMask { get; set; }
    }
    public class MapCharacterList
    {
        [BINValue("characters")] public List<Character> Characters { get; set; }

        public MapCharacterList()
        {

        }
    }
    public class GlobalResourceResolver : BaseResourceResolver
    {

        public GlobalResourceResolver()
        {

        }
    }
    public class Class_200649126 : Class_2144288560
    {

        public Class_200649126()
        {

        }
    }
    public class GameModeConstants
    {
        [BINValue("mGroups")] public Dictionary<Hash, GameModeConstantsGroup> Groups { get; set; }

        public GameModeConstants()
        {

        }
    }
    public class EffectFillPercentageElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }

        public EffectFillPercentageElementData()
        {

        }
    }
    public class HudReplaySliderData
    {
        [BINValue("mIconDataPriorityList")] public List<HudReplaySliderIconData> IconDataPriorityList { get; set; }
        [BINValue("mTooltipEventWindow")] public float TooltipEventWindow { get; set; }

        public HudReplaySliderData()
        {

        }
    }
    public class NeutralTimerSourceIconData
    {
        [BINValue("mTooltipName")] public string TooltipName { get; set; }
        [BINValue("mIconName")] public string IconName { get; set; }

        public NeutralTimerSourceIconData()
        {

        }
    }
    public class FontResolutionData
    {
        [BINValue("autoScale")] public bool AutoScale { get; set; }
        [BINValue("localeResolutions")] public List<FontLocaleResolutions> LocaleResolutions { get; set; }

        public FontResolutionData()
        {

        }
    }
    public class PerkSlot
    {
        [BINValue("mSlotLabelKey")] public string SlotLabelKey { get; set; }
        [BINValue("mType")] public uint Type { get; set; }
        [BINValue("mPerks")] public List<Perk> Perks { get; set; }

        public PerkSlot()
        {

        }
    }
    public class HudHealthBarBurstData
    {
        [BINValue("burstTimeWindow")] public float BurstTimeWindow { get; set; }
        [BINValue("burstTriggerPercent")] public float BurstTriggerPercent { get; set; }
        [BINValue("flashTriggerPercent")] public float FlashTriggerPercent { get; set; }
        [BINValue("flashDuration")] public float FlashDuration { get; set; }
        [BINValue("shakeDuration")] public float ShakeDuration { get; set; }
        [BINValue("shakeBox")] public Vector2 ShakeBox { get; set; }
        [BINValue("shakeReferenceResolution")] public Vector2 ShakeReferenceResolution { get; set; }
        [BINValue("shakeTriggerPercent")] public float ShakeTriggerPercent { get; set; }
        [BINValue("shakeFrequency")] public float ShakeFrequency { get; set; }
        [BINValue("fadeSpeed")] public float FadeSpeed { get; set; }
        [BINValue("fadeAcceleration")] public float FadeAcceleration { get; set; }
        [BINValue("fadeHoldTime")] public float FadeHoldTime { get; set; }

        public HudHealthBarBurstData()
        {

        }
    }
    public class ColorGraphMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("driver")] public IDynamicMaterialFloatDriver Driver { get; set; }
        [BINValue("colors")] public VfxAnimatedColorVariableData Colors { get; set; }

        public ColorGraphMaterialDriver()
        {

        }
    }
    public class StaticMaterialSwitchDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("on")] public bool On { get; set; }

        public StaticMaterialSwitchDef()
        {

        }
    }
    public class PerkStyle
    {
        [BINValue("mPerkStyleId")] public uint PerkStyleId { get; set; }
        [BINValue("mPerkStyleName")] public string PerkStyleName { get; set; }
        [BINValue("mDisplayNameLocalizationKey")] public string DisplayNameLocalizationKey { get; set; }
        [BINValue("mTooltipNameLocalizationKey")] public string TooltipNameLocalizationKey { get; set; }
        [BINValue("mDefaultPageLocalizationKey")] public string DefaultPageLocalizationKey { get; set; }
        [BINValue("mPingTextLocalizationKey")] public string PingTextLocalizationKey { get; set; }
        [BINValue("mIconTextureName")] public string IconTextureName { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mIsAdvancedStyle")] public bool IsAdvancedStyle { get; set; }
        [BINValue("mAllowedSubStyles")] public List<uint> AllowedSubStyles { get; set; }
        [BINValue("mSubStyleBonus")] public List<PerkSubStyleBonus> SubStyleBonus { get; set; }
        [BINValue("mLCUAssetFileMap")] public Dictionary<string, string> LCUAssetFileMap { get; set; }
        [BINValue("mDefaultSplash")] public DefaultSplashedPerkStyle DefaultSplash { get; set; }
        [BINValue("mDefaultPerksWhenSplashed")] public List<Perk> DefaultPerksWhenSplashed { get; set; }
        [BINValue(262465954)] public List<Class_3234822452> m262465954 { get; set; }
        [BINValue("mSlots")] public List<PerkSlot> Slots { get; set; }
        [BINValue("mSlotlinks")] public List<PerkSlot> Slotlinks { get; set; }
        [BINValue("mScript")] public PerkScript Script { get; set; }
        [BINValue("mScriptAsSubStyle")] public PerkScript ScriptAsSubStyle { get; set; }
        [BINValue("mBuffs")] public List<PerkBuff> Buffs { get; set; }
        [BINValue("mStyleVFXResourceResolver")] public ResourceResolver StyleVFXResourceResolver { get; set; }

        public PerkStyle()
        {

        }
    }
    public class Class_243000503
    {
        [BINValue(14980125)] public List<string> m14980125 { get; set; }
        [BINValue(3967407862)] public List<string> m3967407862 { get; set; }

        public Class_243000503()
        {

        }
    }
    public class EsportsData
    {
        [BINValue("leagues")] public List<string> Leagues { get; set; }

        public EsportsData()
        {

        }
    }
    public class VfxProjectionDefinitionData
    {
        [BINValue("mYRange")] public float YRange { get; set; }
        [BINValue("mFading")] public float Fading { get; set; }

        public VfxProjectionDefinitionData()
        {

        }
    }
    public class FloatTextDisplayOverrides
    {
        [BINValue("priority")] public Optional<int> Priority { get; set; }
        [BINValue("maxInstances")] public Optional<int> MaxInstances { get; set; }
        [BINValue("isAnimated")] public Optional<bool> IsAnimated { get; set; }
        [BINValue("disableHorizontalReverse")] public Optional<bool> DisableHorizontalReverse { get; set; }
        [BINValue("disableVerticalReverse")] public Optional<bool> DisableVerticalReverse { get; set; }
        [BINValue("momentumFromHit")] public Optional<bool> MomentumFromHit { get; set; }
        [BINValue("followSource")] public Optional<bool> FollowSource { get; set; }
        [BINValue("ignoreCombineRules")] public Optional<bool> IgnoreCombineRules { get; set; }
        [BINValue("ignoreQueue")] public Optional<bool> IgnoreQueue { get; set; }
        [BINValue("alternateRightLeft")] public Optional<bool> AlternateRightLeft { get; set; }
        [BINValue("combinableCounterDisplay")] public Optional<bool> CombinableCounterDisplay { get; set; }
        [BINValue("combinableCounterCategory")] public Optional<int> CombinableCounterCategory { get; set; }
        [BINValue("overwritePreviousNumber")] public Optional<bool> OverwritePreviousNumber { get; set; }
        [BINValue("extendTimeOnNewDamage")] public Optional<float> ExtendTimeOnNewDamage { get; set; }
        [BINValue("maxLifeTime")] public Optional<float> MaxLifeTime { get; set; }
        [BINValue("colorOffsetR")] public Optional<int> ColorOffsetR { get; set; }
        [BINValue("colorOffsetG")] public Optional<int> ColorOffsetG { get; set; }
        [BINValue("colorOffsetB")] public Optional<int> ColorOffsetB { get; set; }
        [BINValue("scale")] public Optional<float> Scale { get; set; }
        [BINValue("decay")] public Optional<float> Decay { get; set; }
        [BINValue("decayDelay")] public Optional<float> DecayDelay { get; set; }
        [BINValue("shrinkTime")] public Optional<float> ShrinkTime { get; set; }
        [BINValue("shrinkScale")] public Optional<float> ShrinkScale { get; set; }
        [BINValue("hangTime")] public Optional<float> HangTime { get; set; }
        [BINValue("randomOffsetMinX")] public Optional<float> RandomOffsetMinX { get; set; }
        [BINValue("randomOffsetMaxX")] public Optional<float> RandomOffsetMaxX { get; set; }
        [BINValue("randomOffsetMinY")] public Optional<float> RandomOffsetMinY { get; set; }
        [BINValue("randomOffsetMaxY")] public Optional<float> RandomOffsetMaxY { get; set; }
        [BINValue("startOffsetX")] public Optional<float> StartOffsetX { get; set; }
        [BINValue("startOffsetY")] public Optional<float> StartOffsetY { get; set; }
        [BINValue("relativeOffsetMin")] public Optional<float> RelativeOffsetMin { get; set; }
        [BINValue("relativeOffsetMax")] public Optional<float> RelativeOffsetMax { get; set; }
        [BINValue("minXVelocity")] public Optional<float> MinXVelocity { get; set; }
        [BINValue("maxXVelocity")] public Optional<float> MaxXVelocity { get; set; }
        [BINValue("minYVelocity")] public Optional<float> MinYVelocity { get; set; }
        [BINValue("maxYVelocity")] public Optional<float> MaxYVelocity { get; set; }
        [BINValue("continualForceX")] public Optional<float> ContinualForceX { get; set; }
        [BINValue("continualForceY")] public Optional<float> ContinualForceY { get; set; }
        [BINValue("growthXScalar")] public Optional<float> GrowthXScalar { get; set; }
        [BINValue("growthYScalar")] public Optional<float> GrowthYScalar { get; set; }

        public FloatTextDisplayOverrides()
        {

        }
    }
    public class TempTable2Table : ScriptTable
    {

        public TempTable2Table()
        {

        }
    }
    public class CharacterHealthBarDataRecord
    {
        [BINValue("hpPerTick")] public float HpPerTick { get; set; }
        [BINValue("attachToBone")] public string AttachToBone { get; set; }
        [BINValue("unitHealthBarStyle")] public byte UnitHealthBarStyle { get; set; }
        [BINValue("showWhileUntargetable")] public bool ShowWhileUntargetable { get; set; }
        [BINValue(2622563520)] public bool m2622563520 { get; set; }

        public CharacterHealthBarDataRecord()
        {

        }
    }
    public interface Class_308440063 : Class_3053458126
    {
    }
    public class TimeMultiplierCheat : Cheat
    {
        [BINValue("mSpeedUp")] public bool SpeedUp { get; set; }
        [BINValue("mSpeedDown")] public bool SpeedDown { get; set; }

        public TimeMultiplierCheat()
        {

        }
    }
    public class StatUIData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue(1924480492)] public string m1924480492 { get; set; }
        [BINValue(4293193334)] public byte m4293193334 { get; set; }
        [BINValue(9297440)] public string m9297440 { get; set; }
        [BINValue(3047920162)] public string m3047920162 { get; set; }

        public StatUIData()
        {

        }
    }
    public class FloatOffsetTableGet : IFloatGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("offset")] public float Offset { get; set; }

        public FloatOffsetTableGet()
        {

        }
    }
    public class DeathTimes
    {
        [BINValue("mTimeDeadPerLevel")] public List<float> TimeDeadPerLevel { get; set; }
        [BINValue("mScalingStartTime")] public uint ScalingStartTime { get; set; }
        [BINValue("mScalingIncrementTime")] public uint ScalingIncrementTime { get; set; }
        [BINValue("mScalingPercentIncrease")] public float ScalingPercentIncrease { get; set; }
        [BINValue("mScalingPercentCap")] public float ScalingPercentCap { get; set; }
        [BINValue("mScalingPoints")] public List<DeathTimesScalingPoint> ScalingPoints { get; set; }
        [BINValue("mAllowRespawnMods")] public bool AllowRespawnMods { get; set; }
        [BINValue("mStartDeathTimerForZombies")] public bool StartDeathTimerForZombies { get; set; }

        public DeathTimes()
        {

        }
    }
    public class ChatThrottlerData
    {
        [BINValue("throttleLimit")] public uint ThrottleLimit { get; set; }
        [BINValue("checkDurationSeconds")] public float CheckDurationSeconds { get; set; }
        [BINValue("cooldownTimeSeconds")] public float CooldownTimeSeconds { get; set; }

        public ChatThrottlerData()
        {

        }
    }
    public class AboveHealthPercentCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mCurrentPercentHealth")] public float CurrentPercentHealth { get; set; }

        public AboveHealthPercentCastRequirement()
        {

        }
    }
    public class ESportTeamEntry
    {
        [BINValue("teamName")] public string TeamName { get; set; }
        [BINValue("leagueName")] public string LeagueName { get; set; }
        [BINValue("textureName")] public string TextureName { get; set; }

        public ESportTeamEntry()
        {

        }
    }
    public class CheatMenuUIData
    {
        [BINValue("mDisplayName")] public string DisplayName { get; set; }
        [BINValue("mFloatingTextDisplayName")] public string FloatingTextDisplayName { get; set; }
        [BINValue("mTooltipText")] public string TooltipText { get; set; }
        [BINValue("mDynamicTooltipText")] public string DynamicTooltipText { get; set; }
        [BINValue("mHotkey")] public string Hotkey { get; set; }
        [BINValue("mHotkeys")] public List<string> Hotkeys { get; set; }
        [BINValue("mIsToggleCheat")] public bool IsToggleCheat { get; set; }

        public CheatMenuUIData()
        {

        }
    }
    public class ContextualConditionCharacterHasTimeRemainingForAnimation : ICharacterSubcondition
    {
        [BINValue("mAnimationName")] public Hash AnimationName { get; set; }
        [BINValue("mMinRemainingTime")] public float MinRemainingTime { get; set; }

        public ContextualConditionCharacterHasTimeRemainingForAnimation()
        {

        }
    }
    public class ShaderLogicalParameter
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("fields")] public uint Fields { get; set; }

        public ShaderLogicalParameter()
        {

        }
    }
    public class Class_347152410 : IDynamicMaterialBoolDriver
    {
        [BINValue("mBoolDriver")] public IDynamicMaterialBoolDriver BoolDriver { get; set; }
        [BINValue(3737718546)] public float m3737718546 { get; set; }
        [BINValue(446087716)] public float m446087716 { get; set; }

        public Class_347152410()
        {

        }
    }
    public class ConditionBoolClipData : ClipBaseData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mUpdaterType")] public uint UpdaterType { get; set; }
        [BINValue("mChangeAnimationMidPlay")] public bool ChangeAnimationMidPlay { get; set; }
        [BINValue("mTrueConditionClipName")] public Hash TrueConditionClipName { get; set; }
        [BINValue("mFalseConditionClipName")] public Hash FalseConditionClipName { get; set; }
        [BINValue("mChildAnimDelaySwitchTime")] public float ChildAnimDelaySwitchTime { get; set; }

        public ConditionBoolClipData()
        {

        }
    }
    public class ByCharLevelInterpolationCalculationPart : Class_308440063
    {
        [BINValue("mStartValue")] public float StartValue { get; set; }
        [BINValue("mEndValue")] public float EndValue { get; set; }
        [BINValue(2145969075)] public bool m2145969075 { get; set; }
        [BINValue(2737960639)] public bool m2737960639 { get; set; }

        public ByCharLevelInterpolationCalculationPart()
        {

        }
    }
    public interface MissileBehaviorSpec
    {
    }
    public class TransitionClipBlendData : BaseBlendData
    {
        [BINValue("mClipName")] public Hash ClipName { get; set; }

        public TransitionClipBlendData()
        {

        }
    }
    public class MapSunProperties : MapComponent
    {
        [BINValue("sunColor")] public Vector4 SunColor { get; set; }
        [BINValue("sunDirection")] public Vector3 SunDirection { get; set; }
        [BINValue(3632599555)] public float m3632599555 { get; set; }
        [BINValue("skyLightColor")] public Vector4 SkyLightColor { get; set; }
        [BINValue("horizonColor")] public Vector4 HorizonColor { get; set; }
        [BINValue("groundColor")] public Vector4 GroundColor { get; set; }
        [BINValue("skyLightScale")] public float SkyLightScale { get; set; }
        [BINValue("lightMapColorScale")] public float LightMapColorScale { get; set; }
        [BINValue("fogEnabled")] public bool FogEnabled { get; set; }
        [BINValue("fogColor")] public Vector4 FogColor { get; set; }
        [BINValue("fogAlternateColor")] public Vector4 FogAlternateColor { get; set; }
        [BINValue("fogStartAndEnd")] public Vector2 FogStartAndEnd { get; set; }
        [BINValue("fogEmissiveRemap")] public float FogEmissiveRemap { get; set; }
        [BINValue("fogLowQualityModeEmissiveRemap")] public float FogLowQualityModeEmissiveRemap { get; set; }
        [BINValue("useBloom")] public bool UseBloom { get; set; }
        [BINValue("surfaceAreaToShadowMapScale")] public float SurfaceAreaToShadowMapScale { get; set; }
        [BINValue("aoRadius")] public float AoRadius { get; set; }
        [BINValue("aoStrength")] public float AoStrength { get; set; }

        public MapSunProperties()
        {

        }
    }
    public class EmblemSettings
    {
        [BINValue("mBottomFraction")] public float BottomFraction { get; set; }
        [BINValue("mDebugDrawEmblems")] public bool DebugDrawEmblems { get; set; }

        public EmblemSettings()
        {

        }
    }
    public class FloatTextIconData
    {
        [BINValue("mIconFileName")] public string IconFileName { get; set; }
        [BINValue("mColor")] public ColorRGBAVector4Byte Color { get; set; }
        [BINValue("mDisplaySize")] public Vector2 DisplaySize { get; set; }
        [BINValue("mOffset")] public Vector2 Offset { get; set; }
        [BINValue("mAlignment")] public uint Alignment { get; set; }

        public FloatTextIconData()
        {

        }
    }
    public class Class_384088054 : MissileBehaviorSpec
    {

        public Class_384088054()
        {

        }
    }
    public interface Class_389493299
    {
        [BINValue("mMultiplier")] Class_3053458126 Multiplier { get; set; }
        [BINValue(3419063832)] byte m3419063832 { get; set; }
        [BINValue(923208333)] byte m923208333 { get; set; }
    }
    public class FloatingTextTunables
    {
        [BINValue("mMaxFloatingTextItems")] public uint MaxFloatingTextItems { get; set; }
        [BINValue("mIntervalInPix")] public float IntervalInPix { get; set; }
        [BINValue("mScrollSpeed")] public float ScrollSpeed { get; set; }
        [BINValue("mAnimatedTextQueueDelay")] public float AnimatedTextQueueDelay { get; set; }
        [BINValue("mYResolutionBaseline")] public float YResolutionBaseline { get; set; }
        [BINValue("mMinimumDynamicScale")] public float MinimumDynamicScale { get; set; }
        [BINValue("mMaximumDynamicScale")] public float MaximumDynamicScale { get; set; }
        [BINValue(3438744487)] public float m3438744487 { get; set; }
        [BINValue(4117694812)] public float m4117694812 { get; set; }
        [BINValue("mMinionComparisonMultiplier")] public float MinionComparisonMultiplier { get; set; }
        [BINValue("mLocalPlayerHealthComparison")] public float LocalPlayerHealthComparison { get; set; }
        [BINValue("mComparisonByLevel")] public List<float> ComparisonByLevel { get; set; }

        public FloatingTextTunables()
        {

        }
    }
    public class GameModeItemList
    {
        [BINValue("mItems")] public List<Hash> Items { get; set; }

        public GameModeItemList()
        {

        }
    }
    public class NumberFormattingBehavior
    {
        [BINValue(1778472996)] public uint m1778472996 { get; set; }
        [BINValue(2559746888)] public bool m2559746888 { get; set; }
        [BINValue(905883269)] public bool m905883269 { get; set; }

        public NumberFormattingBehavior()
        {

        }
    }
    public class TargeterDefinitionMinimap : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("centerLocator")] public DrawablePositionLocator CenterLocator { get; set; }
        [BINValue("useCasterBoundingBox")] public Optional<bool> UseCasterBoundingBox { get; set; }
        [BINValue("overrideBaseRange")] public FloatPerSpellLevel OverrideBaseRange { get; set; }

        public TargeterDefinitionMinimap()
        {

        }
    }
    public class OrScriptCondition : IScriptCondition
    {
        [BINValue("Conditions")] public List<IScriptCondition> Conditions { get; set; }

        public OrScriptCondition()
        {

        }
    }
    public class Class_428271402 : Class_1936278667
    {
        [BINValue("mSceneName")] public string SceneName { get; set; }

        public Class_428271402()
        {

        }
    }
    public class HudEmotePopupData
    {
        [BINValue("mEmotePopupTransitionIntro")] public HudMenuTransitionData EmotePopupTransitionIntro { get; set; }
        [BINValue("mEmotePopupTransitionOutro")] public HudMenuTransitionData EmotePopupTransitionOutro { get; set; }
        [BINValue(1567183921)] public string m1567183921 { get; set; }
        [BINValue(2147385345)] public float m2147385345 { get; set; }
        [BINValue(1921880927)] public float m1921880927 { get; set; }
        [BINValue(130878851)] public float m130878851 { get; set; }
        [BINValue(1976912936)] public float m1976912936 { get; set; }
        [BINValue(4135630809)] public float m4135630809 { get; set; }
        [BINValue(1809279107)] public float m1809279107 { get; set; }
        [BINValue("mEmoteFloatEnabled")] public bool EmoteFloatEnabled { get; set; }

        public HudEmotePopupData()
        {

        }
    }
    public class VfxFieldAttractionDefinitionData
    {
        [BINValue("position")] public ValueVector3 Position { get; set; }
        [BINValue("radius")] public ValueFloat Radius { get; set; }
        [BINValue("acceleration")] public ValueFloat Acceleration { get; set; }

        public VfxFieldAttractionDefinitionData()
        {

        }
    }
    public class TriggerOnHit : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }

        public TriggerOnHit()
        {

        }
    }
    public class Class_464608054
    {
        [BINValue(3836273065)] public float m3836273065 { get; set; }
        [BINValue(3600106471)] public float m3600106471 { get; set; }
        [BINValue(2671588403)] public float m2671588403 { get; set; }
        [BINValue(3041975949)] public float m3041975949 { get; set; }
        [BINValue(933710889)] public bool m933710889 { get; set; }

        public Class_464608054()
        {

        }
    }
    public class PhysicsMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mLifetime")] public float Lifetime { get; set; }
        [BINValue("mInitialSpeed")] public float InitialSpeed { get; set; }
        [BINValue(856519594)] public float m856519594 { get; set; }
        [BINValue(2468250002)] public bool m2468250002 { get; set; }
        [BINValue(3396802375)] public float m3396802375 { get; set; }

        public PhysicsMovement()
        {

        }
    }
    public class Class_470840304
    {
        [BINValue("image")] public string Image { get; set; }
        [BINValue(1888172557)] public byte m1888172557 { get; set; }

        public Class_470840304()
        {

        }
    }
    public class Class_471801710
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("maxStacks")] public int MaxStacks { get; set; }
        [BINValue(3010375308)] public int m3010375308 { get; set; }
        [BINValue(3995831980)] public bool m3995831980 { get; set; }
        [BINValue(1057836047)] public uint m1057836047 { get; set; }

        public Class_471801710()
        {

        }
    }
    public class CustomTableContainsValueBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("value")] public IScriptValueGet Value { get; set; }
        [BINValue("OutKey")] public ScriptTableSet OutKey { get; set; }
        [BINValue("OutWasFound")] public BoolTableSet OutWasFound { get; set; }

        public CustomTableContainsValueBlock()
        {

        }
    }
    public class SyncCircleMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mAngularVelocity")] public float AngularVelocity { get; set; }
        [BINValue("mLifetime")] public float Lifetime { get; set; }

        public SyncCircleMovement()
        {

        }
    }
    public class TargetLaserComponentEffects
    {
        [BINValue("beamEffectDefinition")] public SkinCharacterDataProperties_CharacterIdleEffect BeamEffectDefinition { get; set; }
        [BINValue("towerTargetingEffectDefinition")] public SkinCharacterDataProperties_CharacterIdleEffect TowerTargetingEffectDefinition { get; set; }
        [BINValue("champTargetingEffectDefinition")] public SkinCharacterDataProperties_CharacterIdleEffect ChampTargetingEffectDefinition { get; set; }

        public TargetLaserComponentEffects()
        {

        }
    }
    public class Class_495553135
    {
        [BINValue(1461360547)] public int m1461360547 { get; set; }
        [BINValue(2292470017)] public int m2292470017 { get; set; }
        [BINValue(445332680)] public int m445332680 { get; set; }
        [BINValue(3146852779)] public int m3146852779 { get; set; }
        [BINValue(3806656962)] public int m3806656962 { get; set; }
        [BINValue(1203616745)] public int m1203616745 { get; set; }

        public Class_495553135()
        {

        }
    }
    public class VfxSoftParticleDefinitionData
    {
        [BINValue("beginIn")] public float BeginIn { get; set; }
        [BINValue("beginOut")] public float BeginOut { get; set; }
        [BINValue("deltaIn")] public float DeltaIn { get; set; }
        [BINValue("deltaOut")] public float DeltaOut { get; set; }

        public VfxSoftParticleDefinitionData()
        {

        }
    }
    public class ContextualActionTriggerEvent : IContextualAction
    {
        [BINValue("mHashedSituationTrigger")] public Hash HashedSituationTrigger { get; set; }
        [BINValue("mMaxOccurences")] public uint MaxOccurences { get; set; }

        public ContextualActionTriggerEvent()
        {

        }
    }
    public class AvatarVarsTable : ScriptTable
    {

        public AvatarVarsTable()
        {

        }
    }
    public class PerkScript
    {
        [BINValue("mSpellScriptName")] public string SpellScriptName { get; set; }
        [BINValue("mSpellScript")] public LolSpellScript SpellScript { get; set; }
        [BINValue("mSpellScriptData")] public PerkScriptData SpellScriptData { get; set; }

        public PerkScript()
        {

        }
    }
    public class HudHealthBarProgressiveTickData
    {
        [BINValue("microTickPerTickData")] public List<MicroTicksPerTickData> MicroTickPerTickData { get; set; }
        [BINValue("healthPerTick")] public float HealthPerTick { get; set; }

        public HudHealthBarProgressiveTickData()
        {

        }
    }
    public class MasteryData
    {
        [BINValue("texture")] public string Texture { get; set; }
        [BINValue(3077895061)] public string m3077895061 { get; set; }
        [BINValue(3729097533)] public string m3729097533 { get; set; }

        public MasteryData()
        {

        }
    }
    public class SummonerEmoteSettings
    {
        [BINValue("mFirstBlood")] public Link<SummonerEmote> FirstBlood { get; set; }
        [BINValue("mAce")] public Link<SummonerEmote> Ace { get; set; }

        public SummonerEmoteSettings()
        {

        }
    }
    public class FloatPerSpellLevel
    {
        [BINValue("mPerLevelValues")] public List<float> PerLevelValues { get; set; }
        [BINValue("mValueType")] public uint ValueType { get; set; }

        public FloatPerSpellLevel()
        {

        }
    }
    public class Class_515850313 : Class_3053458126
    {

        public Class_515850313()
        {

        }
    }
    public class MinimapData
    {
        [BINValue("mIcons")] public Dictionary<byte, MinimapIcon> Icons { get; set; }
        [BINValue("mCustomIcons")] public Dictionary<Hash, MinimapIcon> CustomIcons { get; set; }

        public MinimapData()
        {

        }
    }
    public class MinimapIcon
    {
        [BINValue("mRelativeTeams")] public bool RelativeTeams { get; set; }
        [BINValue("mSize")] public Vector2 Size { get; set; }
        [BINValue("mMinScale")] public float MinScale { get; set; }
        [BINValue("mMaxScale")] public float MaxScale { get; set; }
        [BINValue("mBaseTexture")] public MinimapIconTextureData BaseTexture { get; set; }
        [BINValue("mTeamTextures")] public Dictionary<byte, MinimapIconTextureData> TeamTextures { get; set; }
        [BINValue("mBaseColor")] public MinimapIconColorData BaseColor { get; set; }
        [BINValue("mTeamColors")] public Dictionary<byte, MinimapIconColorData> TeamColors { get; set; }

        public MinimapIcon()
        {

        }
    }
    public class Class_530745462 : Class_2144288560
    {

        public Class_530745462()
        {

        }
    }
    public class VfxBeamDefinitionData
    {
        [BINValue("mSegments")] public int Segments { get; set; }
        [BINValue("mBirthTilingSize")] public ValueVector3 BirthTilingSize { get; set; }
        [BINValue("mIsColorBindedWithDistance")] public bool IsColorBindedWithDistance { get; set; }
        [BINValue("mAnimatedColorWithDistance")] public ValueColor AnimatedColorWithDistance { get; set; }
        [BINValue("mLocalSpaceSourceOffset")] public Vector3 LocalSpaceSourceOffset { get; set; }
        [BINValue("mLocalSpaceTargetOffset")] public Vector3 LocalSpaceTargetOffset { get; set; }
        [BINValue("mTrailMode")] public uint TrailMode { get; set; }
        [BINValue("mMode")] public uint Mode { get; set; }

        public VfxBeamDefinitionData()
        {

        }
    }
    public class CustomShaderDef : IShaderDef
    {
        [BINValue("parameters")] public List<ShaderPhysicalParameter> Parameters { get; set; }
        [BINValue("staticSwitches")] public List<ShaderStaticSwitch> StaticSwitches { get; set; }
        [BINValue("textures")] public List<ShaderTexture> Textures { get; set; }
        [BINValue("featureDefines")] public Dictionary<string, string> FeatureDefines { get; set; }
        [BINValue("featureMask")] public uint FeatureMask { get; set; }
        [BINValue("objectPath")] public string ObjectPath { get; set; }

        public CustomShaderDef()
        {

        }
    }
    public class ReturnToCasterOnMovementComplete : MissileBehaviorSpec
    {
        [BINValue("mPreserveSpeed")] public bool PreserveSpeed { get; set; }
        [BINValue("mOverrideSpec")] public MissileMovementSpec OverrideSpec { get; set; }

        public ReturnToCasterOnMovementComplete()
        {

        }
    }
    public interface IResource
    {
    }
    public class ParallelClipData : ClipBaseData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mClipNameList")] public List<Hash> ClipNameList { get; set; }

        public ParallelClipData()
        {

        }
    }
    public interface VfxPrimitiveTrailBase : VfxPrimitiveBase
    {
        [BINValue("mTrail")] VfxTrailDefinitionData Trail { get; set; }
    }
    public class DynamicMaterialTextureSwapOption
    {
        [BINValue("driver")] public IDynamicMaterialBoolDriver Driver { get; set; }
        [BINValue("textureName")] public string TextureName { get; set; }

        public DynamicMaterialTextureSwapOption()
        {

        }
    }
    public class MapPerInstanceInfo
    {
        [BINValue("environmentSHIrradiance")] public SHData EnvironmentSHIrradiance { get; set; }
        [BINValue("shadowMapPath")] public string ShadowMapPath { get; set; }
        [BINValue("shadowMapUVScaleAndBias")] public Vector4 ShadowMapUVScaleAndBias { get; set; }

        public MapPerInstanceInfo()
        {

        }
    }
    public class ScriptTableGet : IScriptValueGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }

        public ScriptTableGet()
        {

        }
    }
    public interface IContextualConditionSpell : IContextualCondition
    {
    }
    public class VerticalFacingFaceTarget : VerticalFacingType
    {

        public VerticalFacingFaceTarget()
        {

        }
    }
    public class ContextualRule
    {
        [BINValue("mConditionRelationship")] public uint ConditionRelationship { get; set; }
        [BINValue("mConditions")] public List<IContextualCondition> Conditions { get; set; }
        [BINValue("mAudioAction")] public ContextualActionPlayAudio AudioAction { get; set; }
        [BINValue("mAnimationAction")] public ContextualActionPlayAnimation AnimationAction { get; set; }
        [BINValue("mTriggerEventAction")] public ContextualActionTriggerEvent TriggerEventAction { get; set; }
        [BINValue("mPriority")] public Optional<uint> Priority { get; set; }
        [BINValue(1761534916)] public bool m1761534916 { get; set; }

        public ContextualRule()
        {

        }
    }
    public class RegionSettings
    {
        [BINValue("mContentTypeAllowedSettings")] public Dictionary<Hash, RegionsThatAllowContent> ContentTypeAllowedSettings { get; set; }

        public RegionSettings()
        {

        }
    }
    public class FloatTextFormattingData
    {
        [BINValue(3680924211)] public Hash m3680924211 { get; set; }
        [BINValue("colorOffsetR")] public int ColorOffsetR { get; set; }
        [BINValue("colorOffsetG")] public int ColorOffsetG { get; set; }
        [BINValue("colorOffsetB")] public int ColorOffsetB { get; set; }
        [BINValue("mFontDescription")] public Link<GameFontDescription> FontDescription { get; set; }
        [BINValue("ignoreCombineRules")] public bool IgnoreCombineRules { get; set; }
        [BINValue("combinableNumberFormat")] public string CombinableNumberFormat { get; set; }
        [BINValue("combinableNegativeNumberFormat")] public string CombinableNegativeNumberFormat { get; set; }
        [BINValue("priority")] public int Priority { get; set; }
        [BINValue("height")] public float Height { get; set; }
        [BINValue("decay")] public float Decay { get; set; }
        [BINValue("decayDelay")] public float DecayDelay { get; set; }
        [BINValue("disabled")] public bool Disabled { get; set; }
        [BINValue("isAnimated")] public bool IsAnimated { get; set; }
        [BINValue("momentumFromHit")] public bool MomentumFromHit { get; set; }
        [BINValue("followSource")] public bool FollowSource { get; set; }
        [BINValue("disableHorizontalReverse")] public bool DisableHorizontalReverse { get; set; }
        [BINValue("disableVerticalReverse")] public bool DisableVerticalReverse { get; set; }
        [BINValue("combinableCounterDisplay")] public bool CombinableCounterDisplay { get; set; }
        [BINValue("combinableCounterCategory")] public int CombinableCounterCategory { get; set; }
        [BINValue("overwritePreviousNumber")] public bool OverwritePreviousNumber { get; set; }
        [BINValue("minXVelocity")] public float MinXVelocity { get; set; }
        [BINValue("maxXVelocity")] public float MaxXVelocity { get; set; }
        [BINValue("minYVelocity")] public float MinYVelocity { get; set; }
        [BINValue("maxYVelocity")] public float MaxYVelocity { get; set; }
        [BINValue("startOffsetX")] public float StartOffsetX { get; set; }
        [BINValue("startOffsetY")] public float StartOffsetY { get; set; }
        [BINValue("hangTime")] public float HangTime { get; set; }
        [BINValue("randomStartOffsetMinX")] public float RandomStartOffsetMinX { get; set; }
        [BINValue("randomStartOffsetMaxX")] public float RandomStartOffsetMaxX { get; set; }
        [BINValue("randomStartOffsetMinY")] public float RandomStartOffsetMinY { get; set; }
        [BINValue("randomStartOffsetMaxY")] public float RandomStartOffsetMaxY { get; set; }
        [BINValue("growthYScalar")] public float GrowthYScalar { get; set; }
        [BINValue("growthXScalar")] public float GrowthXScalar { get; set; }
        [BINValue("relativeOffsetMin")] public float RelativeOffsetMin { get; set; }
        [BINValue("relativeOffsetMax")] public float RelativeOffsetMax { get; set; }
        [BINValue("continualForceX")] public float ContinualForceX { get; set; }
        [BINValue("continualForceY")] public float ContinualForceY { get; set; }
        [BINValue("continualForceXBase")] public float ContinualForceXBase { get; set; }
        [BINValue("continualForceYBase")] public float ContinualForceYBase { get; set; }
        [BINValue("shrinkTime")] public float ShrinkTime { get; set; }
        [BINValue("scale")] public float Scale { get; set; }
        [BINValue("extendTimeOnNewDamage")] public float ExtendTimeOnNewDamage { get; set; }
        [BINValue("maxLifeTime")] public float MaxLifeTime { get; set; }
        [BINValue("ignoreQueue")] public bool IgnoreQueue { get; set; }
        [BINValue("alternateRightLeft")] public bool AlternateRightLeft { get; set; }
        [BINValue("maxInstances")] public int MaxInstances { get; set; }
        [BINValue("shrinkScale")] public float ShrinkScale { get; set; }
        [BINValue("refreshExisting")] public bool RefreshExisting { get; set; }
        [BINValue("attachToHealthBar")] public bool AttachToHealthBar { get; set; }
        [BINValue("offsetByBoundingBox")] public bool OffsetByBoundingBox { get; set; }
        [BINValue("horizontalAlignment")] public byte HorizontalAlignment { get; set; }
        [BINValue("verticalAlignment")] public byte VerticalAlignment { get; set; }
        [BINValue("icons")] public List<FloatTextIconData> Icons { get; set; }

        public FloatTextFormattingData()
        {

        }
    }
    public class Class_593971085
    {
        [BINValue(1944635290)] public Class_495553135 m1944635290 { get; set; }
        [BINValue(4126940474)] public Dictionary<string, Class_495553135> m4126940474 { get; set; }
        [BINValue(3330164309)] public byte m3330164309 { get; set; }
        [BINValue("mTooltipTransitionIn")] public HudMenuTransitionData TooltipTransitionIn { get; set; }
        [BINValue("mTooltipTransitionOut")] public HudMenuTransitionData TooltipTransitionOut { get; set; }

        public Class_593971085()
        {

        }
    }
    public class CharacterRecord
    {
        [BINValue("mCharacterName")] public string CharacterName { get; set; }
        [BINValue("mFallbackCharacterName")] public string FallbackCharacterName { get; set; }
        [BINValue("targetLaserEffects")] public TargetLaserComponentEffects TargetLaserEffects { get; set; }
        [BINValue("evolutionData")] public EvolutionDescription EvolutionData { get; set; }
        [BINValue("useableData")] public UseableData UseableData { get; set; }
        [BINValue("baseHP")] public float BaseHP { get; set; }
        [BINValue("hpPerLevel")] public float HpPerLevel { get; set; }
        [BINValue("baseStaticHPRegen")] public float BaseStaticHPRegen { get; set; }
        [BINValue("baseFactorHPRegen")] public float BaseFactorHPRegen { get; set; }
        [BINValue("hpRegenPerLevel")] public float HpRegenPerLevel { get; set; }
        [BINValue("healthBarHeight")] public float HealthBarHeight { get; set; }
        [BINValue("healthBarFullParallax")] public bool HealthBarFullParallax { get; set; }
        [BINValue("selfChampSpecificHealthSuffix")] public string SelfChampSpecificHealthSuffix { get; set; }
        [BINValue("selfCBChampSpecificHealthSuffix")] public string SelfCBChampSpecificHealthSuffix { get; set; }
        [BINValue("allyChampSpecificHealthSuffix")] public string AllyChampSpecificHealthSuffix { get; set; }
        [BINValue("enemyChampSpecificHealthSuffix")] public string EnemyChampSpecificHealthSuffix { get; set; }
        [BINValue(2711535288)] public bool m2711535288 { get; set; }
        [BINValue("primaryAbilityResource")] public AbilityResourceSlotInfo PrimaryAbilityResource { get; set; }
        [BINValue("secondaryAbilityResource")] public AbilityResourceSlotInfo SecondaryAbilityResource { get; set; }
        [BINValue("baseDamage")] public float BaseDamage { get; set; }
        [BINValue("damagePerLevel")] public float DamagePerLevel { get; set; }
        [BINValue("baseArmor")] public float BaseArmor { get; set; }
        [BINValue("armorPerLevel")] public float ArmorPerLevel { get; set; }
        [BINValue("baseSpellBlock")] public float BaseSpellBlock { get; set; }
        [BINValue("spellBlockPerLevel")] public float SpellBlockPerLevel { get; set; }
        [BINValue("baseDodge")] public float BaseDodge { get; set; }
        [BINValue("DodgePerLevel")] public float DodgePerLevel { get; set; }
        [BINValue("baseMissChance")] public float BaseMissChance { get; set; }
        [BINValue("baseCritChance")] public float BaseCritChance { get; set; }
        [BINValue("critDamageMultiplier")] public float CritDamageMultiplier { get; set; }
        [BINValue("critPerLevel")] public float CritPerLevel { get; set; }
        [BINValue("baseMoveSpeed")] public float BaseMoveSpeed { get; set; }
        [BINValue("attackRange")] public float AttackRange { get; set; }
        [BINValue("attackSpeed")] public float AttackSpeed { get; set; }
        [BINValue("attackSpeedRatio")] public float AttackSpeedRatio { get; set; }
        [BINValue("attackSpeedPerLevel")] public float AttackSpeedPerLevel { get; set; }
        [BINValue("AbilityPowerIncPerLevel")] public float AbilityPowerIncPerLevel { get; set; }
        [BINValue("mAdaptiveForceToAbilityPowerWeight")] public float AdaptiveForceToAbilityPowerWeight { get; set; }
        [BINValue("attackAutoInterruptPercent")] public float AttackAutoInterruptPercent { get; set; }
        [BINValue("acquisitionRange")] public float AcquisitionRange { get; set; }
        [BINValue("wakeUpRange")] public Optional<float> WakeUpRange { get; set; }
        [BINValue("firstAcquisitionRange")] public Optional<float> FirstAcquisitionRange { get; set; }
        [BINValue("basicAttack")] public AttackSlotData BasicAttack { get; set; }
        [BINValue("extraAttacks")] public List<AttackSlotData> ExtraAttacks { get; set; }
        [BINValue("critAttacks")] public List<AttackSlotData> CritAttacks { get; set; }
        [BINValue("towerTargetingPriorityBoost")] public float TowerTargetingPriorityBoost { get; set; }
        [BINValue("expGivenOnDeath")] public float ExpGivenOnDeath { get; set; }
        [BINValue("goldGivenOnDeath")] public float GoldGivenOnDeath { get; set; }
        [BINValue("goldRadius")] public float GoldRadius { get; set; }
        [BINValue("experienceRadius")] public float ExperienceRadius { get; set; }
        [BINValue("deathEventListeningRadius")] public float DeathEventListeningRadius { get; set; }
        [BINValue("localGoldGivenOnDeath")] public float LocalGoldGivenOnDeath { get; set; }
        [BINValue("localExpGivenOnDeath")] public float LocalExpGivenOnDeath { get; set; }
        [BINValue("localGoldSplitWithLastHitter")] public bool LocalGoldSplitWithLastHitter { get; set; }
        [BINValue("globalGoldGivenOnDeath")] public float GlobalGoldGivenOnDeath { get; set; }
        [BINValue("globalExpGivenOnDeath")] public float GlobalExpGivenOnDeath { get; set; }
        [BINValue("perceptionBubbleRadius")] public Optional<float> PerceptionBubbleRadius { get; set; }
        [BINValue("perceptionBoundingBoxSize")] public Optional<Vector3> PerceptionBoundingBoxSize { get; set; }
        [BINValue("significance")] public float Significance { get; set; }
        [BINValue("untargetableSpawnTime")] public float UntargetableSpawnTime { get; set; }
        [BINValue("abilityPower")] public float AbilityPower { get; set; }
        [BINValue("spellNames")] public List<string> SpellNames { get; set; }
        [BINValue("extraSpells")] public List<string> ExtraSpells { get; set; }
        [BINValue(3799694934)] public List<AbilityObject> m3799694934 { get; set; }
        [BINValue(976335800)] public uint m976335800 { get; set; }
        [BINValue(2663075043)] public uint m2663075043 { get; set; }
        [BINValue(1451949008)] public uint m1451949008 { get; set; }
        [BINValue("criticalAttack")] public string CriticalAttack { get; set; }
        [BINValue("passiveName")] public string PassiveName { get; set; }
        [BINValue("passiveLuaName")] public string PassiveLuaName { get; set; }
        [BINValue("passiveToolTip")] public string PassiveToolTip { get; set; }
        [BINValue("passiveSpell")] public string PassiveSpell { get; set; }
        [BINValue("passiveRange")] public float PassiveRange { get; set; }
        [BINValue("passiveIsPingable")] public bool PassiveIsPingable { get; set; }
        [BINValue("passive1IconName")] public string Passive1IconName { get; set; }
        [BINValue("lore1")] public string Lore1 { get; set; }
        [BINValue("tips1")] public string Tips1 { get; set; }
        [BINValue("tips2")] public string Tips2 { get; set; }
        [BINValue("friendlyTooltip")] public string FriendlyTooltip { get; set; }
        [BINValue("enemyTooltip")] public string EnemyTooltip { get; set; }
        [BINValue("name")] public string Name { get; set; }
        [BINValue("parName")] public string ParName { get; set; }
        [BINValue("weaponMaterials")] public List<string> WeaponMaterials { get; set; }
        [BINValue("hoverIndicatorTextureName")] public string HoverIndicatorTextureName { get; set; }
        [BINValue("hoverIndicatorRadius")] public float HoverIndicatorRadius { get; set; }
        [BINValue("hoverLineIndicatorBaseTextureName")] public string HoverLineIndicatorBaseTextureName { get; set; }
        [BINValue("hoverLineIndicatorTargetTextureName")] public string HoverLineIndicatorTargetTextureName { get; set; }
        [BINValue("hoverLineIndicatorWidth")] public float HoverLineIndicatorWidth { get; set; }
        [BINValue("hoverIndicatorRotateToPlayer")] public bool HoverIndicatorRotateToPlayer { get; set; }
        [BINValue("hoverIndicatorMinimapOverride")] public string HoverIndicatorMinimapOverride { get; set; }
        [BINValue("minimapIconOverride")] public string MinimapIconOverride { get; set; }
        [BINValue("hoverIndicatorRadiusMinimap")] public float HoverIndicatorRadiusMinimap { get; set; }
        [BINValue("hoverLineIndicatorWidthMinimap")] public float HoverLineIndicatorWidthMinimap { get; set; }
        [BINValue("areaIndicatorRadius")] public float AreaIndicatorRadius { get; set; }
        [BINValue("areaIndicatorMinRadius")] public float AreaIndicatorMinRadius { get; set; }
        [BINValue("areaIndicatorMaxDistance")] public float AreaIndicatorMaxDistance { get; set; }
        [BINValue("areaIndicatorTargetDistance")] public float AreaIndicatorTargetDistance { get; set; }
        [BINValue("areaIndicatorMinDistance")] public float AreaIndicatorMinDistance { get; set; }
        [BINValue("areaIndicatorTextureName")] public string AreaIndicatorTextureName { get; set; }
        [BINValue("areaIndicatorTextureSize")] public float AreaIndicatorTextureSize { get; set; }
        [BINValue("charAudioNameOverride")] public string CharAudioNameOverride { get; set; }
        [BINValue("mUseCCAnimations")] public bool UseCCAnimations { get; set; }
        [BINValue("jointForAnimAdjustedSelection")] public string JointForAnimAdjustedSelection { get; set; }
        [BINValue("outlineBBoxExpansion")] public float OutlineBBoxExpansion { get; set; }
        [BINValue("silhouetteAttachmentAnim")] public string SilhouetteAttachmentAnim { get; set; }
        [BINValue("hitFxScale")] public float HitFxScale { get; set; }
        [BINValue("selectionHeight")] public float SelectionHeight { get; set; }
        [BINValue("selectionRadius")] public float SelectionRadius { get; set; }
        [BINValue("pathfindingCollisionRadius")] public float PathfindingCollisionRadius { get; set; }
        [BINValue("overrideGameplayCollisionRadius")] public Optional<float> OverrideGameplayCollisionRadius { get; set; }
        [BINValue("unitTagsString")] public string UnitTagsString { get; set; }
        [BINValue("friendlyUxOverrideTeam")] public uint FriendlyUxOverrideTeam { get; set; }
        [BINValue("friendlyUxOverrideIncludeTagsString")] public string FriendlyUxOverrideIncludeTagsString { get; set; }
        [BINValue("friendlyUxOverrideExcludeTagsString")] public string FriendlyUxOverrideExcludeTagsString { get; set; }
        [BINValue("mEducationToolData")] public ToolEducationData EducationToolData { get; set; }
        [BINValue("mAbilitySlotCC")] public List<int> AbilitySlotCC { get; set; }
        [BINValue("characterToolData")] public CharacterToolData CharacterToolData { get; set; }
        [BINValue("platformEnabled")] public bool PlatformEnabled { get; set; }
        [BINValue("spellLevelUpInfo")] public List<SpellLevelUpInfo> SpellLevelUpInfo { get; set; }
        [BINValue("recSpellRankUpInfo")] public List<RecSpellRankUpInfo> RecSpellRankUpInfo { get; set; }
        [BINValue("recordAsWard")] public bool RecordAsWard { get; set; }
        [BINValue("minionScoreValue")] public float MinionScoreValue { get; set; }
        [BINValue("useRiotRelationships")] public bool UseRiotRelationships { get; set; }
        [BINValue("flags")] public uint Flags { get; set; }
        [BINValue("minionFlags")] public uint MinionFlags { get; set; }
        [BINValue("assetCategory")] public string AssetCategory { get; set; }
        [BINValue("purchaseIdentities")] public List<Hash> PurchaseIdentities { get; set; }
        [BINValue("mClientSideItemInventory")] public List<Hash> ClientSideItemInventory { get; set; }
        [BINValue("mPreferredPerkStyle")] public Link<PerkStyle> PreferredPerkStyle { get; set; }
        [BINValue("mPerkReplacements")] public PerkReplacementList PerkReplacements { get; set; }
        [BINValue("deathTime")] public float DeathTime { get; set; }
        [BINValue("occludedUnitSelectableDistance")] public float OccludedUnitSelectableDistance { get; set; }
        [BINValue("MovingTowardEnemyActivationAngle")] public float MovingTowardEnemyActivationAngle { get; set; }

        public CharacterRecord()
        {

        }
    }
    public class Class_606188120 : Class_308440063
    {
        [BINValue("mValues")] public List<float> Values { get; set; }

        public Class_606188120()
        {

        }
    }
    public class Class_607049692
    {
        [BINValue("contentId")] public string ContentId { get; set; }

        public Class_607049692()
        {

        }
    }
    public interface IRunFunctionBlock : IScriptBlock
    {
        [BINValue("Function")] FunctionTableGet Function { get; set; }
        [BINValue("InputParameters")] List<IScriptValueGet> InputParameters { get; set; }
        [BINValue("OutputParameters")] List<ScriptTableSet> OutputParameters { get; set; }
    }
    public class ItemData
    {
        [BINValue("spellName")] public string SpellName { get; set; }
        [BINValue("mDisplayName")] public string DisplayName { get; set; }
        [BINValue("mRequiredChampion")] public string RequiredChampion { get; set; }
        [BINValue("mRequiredAlly")] public string RequiredAlly { get; set; }
        [BINValue("mRequiredLevel")] public int RequiredLevel { get; set; }
        [BINValue("mRequiredSpellName")] public string RequiredSpellName { get; set; }
        [BINValue("mRequiredPurchaseIdentities")] public List<Hash> RequiredPurchaseIdentities { get; set; }
        [BINValue("mDisabledDescriptionOverride")] public string DisabledDescriptionOverride { get; set; }
        [BINValue("mParentEnchantmentGroup")] public string ParentEnchantmentGroup { get; set; }
        [BINValue("mDeathRecapName")] public string DeathRecapName { get; set; }
        [BINValue("itemID")] public int ItemID { get; set; }
        [BINValue("maxStack")] public int MaxStack { get; set; }
        [BINValue("mItemGroups")] public List<ItemGroup> ItemGroups { get; set; }
        [BINValue("itemVOGroup")] public Hash ItemVOGroup { get; set; }
        [BINValue("price")] public int Price { get; set; }
        [BINValue("mRequiredBuffCurrencyName")] public string RequiredBuffCurrencyName { get; set; }
        [BINValue("mRequiredBuffCurrencyCost")] public int RequiredBuffCurrencyCost { get; set; }
        [BINValue("mSidegradeCredit")] public float SidegradeCredit { get; set; }
        [BINValue("consumed")] public bool Consumed { get; set; }
        [BINValue("usableInStore")] public bool UsableInStore { get; set; }
        [BINValue("consumeOnAcquire")] public bool ConsumeOnAcquire { get; set; }
        [BINValue("clickable")] public bool Clickable { get; set; }
        [BINValue("mMajorActiveItem")] public bool MajorActiveItem { get; set; }
        [BINValue("mItemCalloutPlayer")] public bool ItemCalloutPlayer { get; set; }
        [BINValue("mItemCalloutSpectator")] public bool ItemCalloutSpectator { get; set; }
        [BINValue("clearUndoHistory")] public byte ClearUndoHistory { get; set; }
        [BINValue("mCanBeSold")] public bool CanBeSold { get; set; }
        [BINValue("mHiddenFromOpponents")] public bool HiddenFromOpponents { get; set; }
        [BINValue("mIsEnchantment")] public bool IsEnchantment { get; set; }
        [BINValue("specialRecipe")] public int SpecialRecipe { get; set; }
        [BINValue("recipeItemLinks")] public List<ItemData> RecipeItemLinks { get; set; }
        [BINValue("requiredItemLinks")] public List<ItemData> RequiredItemLinks { get; set; }
        [BINValue("sidegradeItemLinks")] public List<ItemData> SidegradeItemLinks { get; set; }
        [BINValue("mItemModifiers")] public List<ItemModifier> ItemModifiers { get; set; }
        [BINValue("mMapStringIdInclusions")] public List<Hash> MapStringIdInclusions { get; set; }
        [BINValue("mModeNameInclusions")] public List<Hash> ModeNameInclusions { get; set; }
        [BINValue("customInclusions")] public List<string> CustomInclusions { get; set; }
        [BINValue("customExclusions")] public List<string> CustomExclusions { get; set; }
        [BINValue("mScripts")] public List<string> Scripts { get; set; }
        [BINValue("parentItemLink")] public Link<ItemData> ParentItemLink { get; set; }
        [BINValue("parentEnchantmentLink")] public Link<ItemData> ParentEnchantmentLink { get; set; }
        [BINValue("mEffectAmount")] public List<float> EffectAmount { get; set; }
        [BINValue("mEnchantmentEffectAmount")] public List<float> EnchantmentEffectAmount { get; set; }
        [BINValue("mEffectByLevelAmount")] public List<float> EffectByLevelAmount { get; set; }
        [BINValue("mFlatCooldownMod")] public float FlatCooldownMod { get; set; }
        [BINValue("mPercentCooldownMod")] public float PercentCooldownMod { get; set; }
        [BINValue("mFlatHPPoolMod")] public float FlatHPPoolMod { get; set; }
        [BINValue("mPercentHPPoolMod")] public float PercentHPPoolMod { get; set; }
        [BINValue("mFlatHPRegenMod")] public float FlatHPRegenMod { get; set; }
        [BINValue("mPercentHPRegenMod")] public float PercentHPRegenMod { get; set; }
        [BINValue("mPercentBaseHPRegenMod")] public float PercentBaseHPRegenMod { get; set; }
        [BINValue("mPercentTenacityItemMod")] public float PercentTenacityItemMod { get; set; }
        [BINValue("mPercentSlowResistMod")] public float PercentSlowResistMod { get; set; }
        [BINValue("mFlatMovementSpeedMod")] public float FlatMovementSpeedMod { get; set; }
        [BINValue("mPercentMovementSpeedMod")] public float PercentMovementSpeedMod { get; set; }
        [BINValue("mPercentMultiplicativeMovementSpeedMod")] public float PercentMultiplicativeMovementSpeedMod { get; set; }
        [BINValue("mFlatArmorMod")] public float FlatArmorMod { get; set; }
        [BINValue("mPercentArmorMod")] public float PercentArmorMod { get; set; }
        [BINValue("mFlatArmorPenetrationMod")] public float FlatArmorPenetrationMod { get; set; }
        [BINValue("mPercentArmorPenetrationMod")] public float PercentArmorPenetrationMod { get; set; }
        [BINValue("mPercentBonusArmorPenetrationMod")] public float PercentBonusArmorPenetrationMod { get; set; }
        [BINValue("mFlatMagicPenetrationMod")] public float FlatMagicPenetrationMod { get; set; }
        [BINValue("mPercentMagicPenetrationMod")] public float PercentMagicPenetrationMod { get; set; }
        [BINValue("mPercentBonusMagicPenetrationMod")] public float PercentBonusMagicPenetrationMod { get; set; }
        [BINValue("mFlatSpellBlockMod")] public float FlatSpellBlockMod { get; set; }
        [BINValue("mPercentSpellBlockMod")] public float PercentSpellBlockMod { get; set; }
        [BINValue("mFlatDodgeMod")] public float FlatDodgeMod { get; set; }
        [BINValue("mFlatCritChanceMod")] public float FlatCritChanceMod { get; set; }
        [BINValue("mFlatMissChanceMod")] public float FlatMissChanceMod { get; set; }
        [BINValue("mFlatCritDamageMod")] public float FlatCritDamageMod { get; set; }
        [BINValue("mPercentCritDamageMod")] public float PercentCritDamageMod { get; set; }
        [BINValue("mFlatPhysicalDamageMod")] public float FlatPhysicalDamageMod { get; set; }
        [BINValue("mPercentPhysicalDamageMod")] public float PercentPhysicalDamageMod { get; set; }
        [BINValue("mFlatMagicDamageMod")] public float FlatMagicDamageMod { get; set; }
        [BINValue("mPercentMagicDamageMod")] public float PercentMagicDamageMod { get; set; }
        [BINValue("mFlatPhysicalReduction")] public float FlatPhysicalReduction { get; set; }
        [BINValue("mPercentPhysicalReduction")] public float PercentPhysicalReduction { get; set; }
        [BINValue("mFlatMagicReduction")] public float FlatMagicReduction { get; set; }
        [BINValue("mPercentMagicReduction")] public float PercentMagicReduction { get; set; }
        [BINValue("mPercentEXPBonus")] public float PercentEXPBonus { get; set; }
        [BINValue("mFlatAttackRangeMod")] public float FlatAttackRangeMod { get; set; }
        [BINValue("mPercentAttackRangeMod")] public float PercentAttackRangeMod { get; set; }
        [BINValue("mFlatCastRangeMod")] public float FlatCastRangeMod { get; set; }
        [BINValue("mPercentCastRangeMod")] public float PercentCastRangeMod { get; set; }
        [BINValue("mPercentAttackSpeedMod")] public float PercentAttackSpeedMod { get; set; }
        [BINValue("mPercentMultiplicativeAttackSpeedMod")] public float PercentMultiplicativeAttackSpeedMod { get; set; }
        [BINValue("mPercentHealingAmountMod")] public float PercentHealingAmountMod { get; set; }
        [BINValue("mPercentLifeStealMod")] public float PercentLifeStealMod { get; set; }
        [BINValue("mPercentSpellVampMod")] public float PercentSpellVampMod { get; set; }
        [BINValue("mPercentSpellEffectivenessMod")] public float PercentSpellEffectivenessMod { get; set; }
        [BINValue("mFlatBubbleRadiusMod")] public float FlatBubbleRadiusMod { get; set; }
        [BINValue("mPercentBubbleRadiusMod")] public float PercentBubbleRadiusMod { get; set; }
        [BINValue("sellBackModifier")] public float SellBackModifier { get; set; }
        [BINValue("mCooldownShowDisabledDuration")] public float CooldownShowDisabledDuration { get; set; }
        [BINValue("flatMPPoolMod")] public float FlatMPPoolMod { get; set; }
        [BINValue("PercentMPPoolMod")] public float PercentMPPoolMod { get; set; }
        [BINValue("flatMPRegenMod")] public float FlatMPRegenMod { get; set; }
        [BINValue("PercentMPRegenMod")] public float PercentMPRegenMod { get; set; }
        [BINValue("percentBaseMPRegenMod")] public float PercentBaseMPRegenMod { get; set; }
        [BINValue(1472645072)] public Class_3225152729 m1472645072 { get; set; }
        [BINValue(1632533069)] public int m1632533069 { get; set; }
        [BINValue("mItemDataClient")] public ItemDataClient ItemDataClient { get; set; }
        [BINValue("mVFXResourceResolver")] public ResourceResolver VFXResourceResolver { get; set; }

        public ItemData()
        {

        }
    }
    public interface ScriptTable
    {
    }
    public class ObjectTags
    {
        [BINValue("mTagList")] public string TagList { get; set; }

        public ObjectTags()
        {

        }
    }
    public class Class_646351631
    {
        [BINValue(2940314578)] public Optional<uint> m2940314578 { get; set; }
        [BINValue(3076655600)] public Optional<uint> m3076655600 { get; set; }
        [BINValue(3278832061)] public uint m3278832061 { get; set; }

        public Class_646351631()
        {

        }
    }
    public class Class_651368964 : GDSMapObjectExtraInfo
    {
        [BINValue("colors")] public List<Vector4> Colors { get; set; }

        public Class_651368964()
        {

        }
    }
    public class IntTableSet : ScriptTableSet
    {

        public IntTableSet()
        {

        }
    }
    public class AddPARCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mAmount")] public float Amount { get; set; }

        public AddPARCheat()
        {

        }
    }
    public class VfxPrimitiveArbitrarySegmentBeam : VfxPrimitiveBeamBase
    {
        [BINValue("mBeam")] public VfxBeamDefinitionData Beam { get; set; }

        public VfxPrimitiveArbitrarySegmentBeam()
        {

        }
    }
    public class MapPointLightType
    {
        [BINValue("lightColor")] public Vector4 LightColor { get; set; }
        [BINValue("falloffColor")] public Vector4 FalloffColor { get; set; }
        [BINValue("radius")] public float Radius { get; set; }
        [BINValue("castStaticShadows")] public bool CastStaticShadows { get; set; }
        [BINValue("specular")] public bool Specular { get; set; }

        public MapPointLightType()
        {

        }
    }
    public class GearSkinUpgrade
    {
        [BINValue(1671102483)] public GearData m1671102483 { get; set; }
        [BINValue(898435083)] public string m898435083 { get; set; }

        public GearSkinUpgrade()
        {

        }
    }
    public class TargeterDefinitionSpline : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("startLocator")] public DrawablePositionLocator StartLocator { get; set; }
        [BINValue("endLocator")] public DrawablePositionLocator EndLocator { get; set; }
        [BINValue("baseTextureName")] public string BaseTextureName { get; set; }
        [BINValue("frontTextureName")] public string FrontTextureName { get; set; }
        [BINValue("splineWidth")] public FloatPerSpellLevel SplineWidth { get; set; }
        [BINValue("overrideSpline")] public ISplineInfo OverrideSpline { get; set; }
        [BINValue("minSegmentCount")] public uint MinSegmentCount { get; set; }
        [BINValue("maxSegmentLength")] public float MaxSegmentLength { get; set; }
        [BINValue("isConstrainedToRange")] public bool IsConstrainedToRange { get; set; }
        [BINValue("constraintRange")] public FloatPerSpellLevel ConstraintRange { get; set; }

        public TargeterDefinitionSpline()
        {

        }
    }
    public class VfxPrimitiveCameraTrail : VfxPrimitiveTrailBase
    {
        [BINValue("mTrail")] public VfxTrailDefinitionData Trail { get; set; }

        public VfxPrimitiveCameraTrail()
        {

        }
    }
    public class KillAllTurretsCheat : Cheat
    {

        public KillAllTurretsCheat()
        {

        }
    }
    public class BlendedLinearHeightSolver : HeightSolverType
    {

        public BlendedLinearHeightSolver()
        {

        }
    }
    public class RecallDecalData
    {
        [BINValue("effectFile")] public string EffectFile { get; set; }
        [BINValue("arrivalEffectFile")] public string ArrivalEffectFile { get; set; }
        [BINValue(3221725462)] public string m3221725462 { get; set; }
        [BINValue(2784775912)] public string m2784775912 { get; set; }
        [BINValue("recallDecalId")] public uint RecallDecalId { get; set; }

        public RecallDecalData()
        {

        }
    }
    public class ContextualActionPlayVO : ContextualActionPlayAudio
    {
        [BINValue("mHashedSituationTrigger")] public Hash HashedSituationTrigger { get; set; }
        [BINValue("mMaxOccurences")] public uint MaxOccurences { get; set; }
        [BINValue("mSelfEventName")] public string SelfEventName { get; set; }
        [BINValue("mAllyEventName")] public string AllyEventName { get; set; }
        [BINValue("mEnemyEventName")] public string EnemyEventName { get; set; }
        [BINValue("mSpectatorEventName")] public string SpectatorEventName { get; set; }
        [BINValue("mWaitForAnnouncerQueue")] public bool WaitForAnnouncerQueue { get; set; }
        [BINValue("mWaitTimeout")] public float WaitTimeout { get; set; }

        public ContextualActionPlayVO()
        {

        }
    }
    public class IntGet : IIntGet
    {
        [BINValue("value")] public int Value { get; set; }

        public IntGet()
        {

        }
    }
    public class MinimapBackgroundConfig
    {
        [BINValue("mDefaultTextureName")] public string DefaultTextureName { get; set; }
        [BINValue("mCustomMinimapBackgrounds")] public Dictionary<Hash, MinimapBackground> CustomMinimapBackgrounds { get; set; }

        public MinimapBackgroundConfig()
        {

        }
    }
    public class VfxSineMaterialDriver : IVfxMaterialDriver
    {
        [BINValue("mFrequency")] public float Frequency { get; set; }
        [BINValue("mScale")] public float Scale { get; set; }
        [BINValue("mBias")] public float Bias { get; set; }

        public VfxSineMaterialDriver()
        {

        }
    }
    public class ScriptCommentBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("Sequence")] public ScriptSequence Sequence { get; set; }

        public ScriptCommentBlock()
        {

        }
    }
    public class GameModeConstantsGroup
    {
        [BINValue("mConstants")] public Dictionary<Hash, GameModeConstant> Constants { get; set; }

        public GameModeConstantsGroup()
        {

        }
    }
    public class MaskData
    {
        [BINValue("mId")] public uint Id { get; set; }
        [BINValue("mWeightList")] public List<float> WeightList { get; set; }

        public MaskData()
        {

        }
    }
    public class Class_730516414
    {
        [BINValue("name")] public Hash Name { get; set; }
        [BINValue(153069804)] public byte m153069804 { get; set; }

        public Class_730516414()
        {

        }
    }
    public class VfxColorOverLifeMaterialDriver : IVfxMaterialDriver
    {
        [BINValue("frequency")] public byte Frequency { get; set; }
        [BINValue("colors")] public VfxAnimatedColorVariableData Colors { get; set; }

        public VfxColorOverLifeMaterialDriver()
        {

        }
    }
    public class SurrenderTypeData
    {
        [BINValue(1387564760)] public float m1387564760 { get; set; }
        [BINValue("windowLength")] public float WindowLength { get; set; }
        [BINValue("startTime")] public float StartTime { get; set; }
        [BINValue("percentageRequired")] public float PercentageRequired { get; set; }

        public SurrenderTypeData()
        {

        }
    }
    public class HudHealthBarDefenseModifierData
    {
        [BINValue("defenseUpPercent")] public float DefenseUpPercent { get; set; }
        [BINValue("defenseDownL1Percent")] public float DefenseDownL1Percent { get; set; }
        [BINValue("defenseDownL2Percent")] public float DefenseDownL2Percent { get; set; }
        [BINValue("defenseDownL3Percent")] public float DefenseDownL3Percent { get; set; }

        public HudHealthBarDefenseModifierData()
        {

        }
    }
    public class Class_752642599 : Class_2144288560
    {

        public Class_752642599()
        {

        }
    }
    public class Class_759657674 : Class_3813882857
    {
        [BINValue("mConditions")] public List<Class_3575093694> Conditions { get; set; }
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public Class_759657674()
        {

        }
    }
    public class Class_761319899
    {
        [BINValue(3317216616)] public Dictionary<string, Link<RegaliaData>> m3317216616 { get; set; }

        public Class_761319899()
        {

        }
    }
    public class DynamicMaterialDef
    {
        [BINValue(1590877069)] public bool m1590877069 { get; set; }
        [BINValue("parameters")] public List<DynamicMaterialParameterDef> Parameters { get; set; }
        [BINValue("textures")] public List<DynamicMaterialTextureSwapDef> Textures { get; set; }
        [BINValue("staticSwitch")] public DynamicMaterialStaticSwitch StaticSwitch { get; set; }

        public DynamicMaterialDef()
        {

        }
    }
    public class FontType
    {
        [BINValue("localeTypes")] public List<FontLocaleType> LocaleTypes { get; set; }

        public FontType()
        {

        }
    }
    public class ContextualConditionChanceToPlay : IContextualCondition
    {
        [BINValue("mPercentChanceToPlay")] public byte PercentChanceToPlay { get; set; }

        public ContextualConditionChanceToPlay()
        {

        }
    }
    public class Class_768590138 : MissileBehaviorSpec
    {
        [BINValue(984461507)] public float m984461507 { get; set; }

        public Class_768590138()
        {

        }
    }
    public class Class_769601740
    {
        [BINValue("scale")] public float Scale { get; set; }
        [BINValue(2072037248)] public float m2072037248 { get; set; }
        [BINValue("direction")] public Vector2 Direction { get; set; }

        public Class_769601740()
        {

        }
    }
    public interface ISplineInfo
    {
        [BINValue("mStartPositionOffset")] Vector3 StartPositionOffset { get; set; }
        [BINValue("mUseMissilePositionAsOrigin")] bool UseMissilePositionAsOrigin { get; set; }
    }
    public class VfxAnimatedVector2fVariableData
    {
        [BINValue("probabilityTables")] public List<VfxProbabilityTableData> ProbabilityTables { get; set; }
        [BINValue("times")] public List<float> Times { get; set; }
        [BINValue("values")] public List<Vector2> Values { get; set; }

        public VfxAnimatedVector2fVariableData()
        {

        }
    }
    public class Class_779837744
    {
        [BINValue(1666346813)] public List<Class_2727115092> m1666346813 { get; set; }

        public Class_779837744()
        {

        }
    }
    public class ContextualConditionAnyOtherHero : IContextualCondition
    {
        [BINValue("mChildConditions")] public List<ICharacterSubcondition> ChildConditions { get; set; }

        public ContextualConditionAnyOtherHero()
        {

        }
    }
    public class AbovePARPercentCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mPARType")] public byte PARType { get; set; }
        [BINValue("mCurrentPercentPAR")] public float CurrentPercentPAR { get; set; }

        public AbovePARPercentCastRequirement()
        {

        }
    }
    public class ScriptPreloadCharacter
    {
        [BINValue("PreloadResourceName")] public string PreloadResourceName { get; set; }

        public ScriptPreloadCharacter()
        {

        }
    }
    public class FlexTypeFloat
    {
        [BINValue("mFlexID")] public uint FlexID { get; set; }
        [BINValue("mValue")] public float Value { get; set; }

        public FlexTypeFloat()
        {

        }
    }
    public class FunctionTableGet : IFunctionGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }

        public FunctionTableGet()
        {

        }
    }
    public class Class_808547418 : Class_2144288560
    {

        public Class_808547418()
        {

        }
    }
    public class TFTCharacterRecord : CharacterRecord
    {
        [BINValue("mLinkedTraits")] public List<TftTraitData> LinkedTraits { get; set; }
        [BINValue("mMoveInterval")] public float MoveInterval { get; set; }
        [BINValue("mMoveProximity")] public float MoveProximity { get; set; }
        [BINValue("mMoveRange")] public float MoveRange { get; set; }
        [BINValue("mMoveHeight")] public float MoveHeight { get; set; }
        [BINValue("mInitialMana")] public float InitialMana { get; set; }
        [BINValue("mShopData")] public Link<TftShopData> ShopData { get; set; }
        [BINValue(1311286886)] public string m1311286886 { get; set; }
        [BINValue(3645083651)] public Vector3 m3645083651 { get; set; }

        public TFTCharacterRecord()
        {

        }
    }
    public class LearnedSpellDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mSlot")] public byte Slot { get; set; }

        public LearnedSpellDynamicMaterialBoolDriver()
        {

        }
    }
    public class SineMaterialDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mDriver")] public IDynamicMaterialFloatDriver Driver { get; set; }
        [BINValue("mFrequency")] public float Frequency { get; set; }
        [BINValue("mScale")] public float Scale { get; set; }
        [BINValue("mBias")] public float Bias { get; set; }

        public SineMaterialDriver()
        {

        }
    }
    public class ComparisonScriptCondition : IScriptCondition
    {
        [BINValue("Value1")] public IScriptValueGet Value1 { get; set; }
        [BINValue("Operation")] public uint Operation { get; set; }
        [BINValue("Value2")] public IScriptValueGet Value2 { get; set; }

        public ComparisonScriptCondition()
        {

        }
    }
    public class RecSpellRankUpInfo
    {
        [BINValue("mDefaultPriority")] public List<byte> DefaultPriority { get; set; }
        [BINValue("mEarlyLevelOverrides")] public List<byte> EarlyLevelOverrides { get; set; }

        public RecSpellRankUpInfo()
        {

        }
    }
    public class ShaderTexture
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("defaultTexturePath")] public string DefaultTexturePath { get; set; }

        public ShaderTexture()
        {

        }
    }
    public class NextBuffVarsTable : ScriptTable
    {

        public NextBuffVarsTable()
        {

        }
    }
    public class Class_845187144 : Class_2144288560
    {
        [BINValue(1871894195)] public bool m1871894195 { get; set; }

        public Class_845187144()
        {

        }
    }
    public class LockRootOrientationRigPoseModifierData : BaseRigPoseModifierData
    {

        public LockRootOrientationRigPoseModifierData()
        {

        }
    }
    public class SkinCharacterDataProperties_CharacterIdleEffect
    {
        [BINValue("effectKey")] public Hash EffectKey { get; set; }
        [BINValue("effectName")] public string EffectName { get; set; }
        [BINValue("position")] public Vector3 Position { get; set; }
        [BINValue("boneName")] public string BoneName { get; set; }
        [BINValue("targetBoneName")] public string TargetBoneName { get; set; }

        public SkinCharacterDataProperties_CharacterIdleEffect()
        {

        }
    }
    public class NamedDataValueCalculationPart : Class_3053458126
    {
        [BINValue("mDataValue")] public Hash DataValue { get; set; }

        public NamedDataValueCalculationPart()
        {

        }
    }
    public class Class_868276581
    {
        [BINValue(1559208202)] public Class_389493299 m1559208202 { get; set; }

        public Class_868276581()
        {

        }
    }
    public class TargeterDefinitionLine : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue(1086768030)] public Class_4153143643 m1086768030 { get; set; }
        [BINValue("startLocator")] public DrawablePositionLocator StartLocator { get; set; }
        [BINValue("endLocator")] public DrawablePositionLocator EndLocator { get; set; }
        [BINValue("fallbackDirection")] public uint FallbackDirection { get; set; }
        [BINValue("alwaysDraw")] public bool AlwaysDraw { get; set; }
        [BINValue("hasMaxGrowRange")] public bool HasMaxGrowRange { get; set; }
        [BINValue("useGlobalLineIndicator")] public bool UseGlobalLineIndicator { get; set; }
        [BINValue("lineStopsAtEndPosition")] public Optional<bool> LineStopsAtEndPosition { get; set; }
        [BINValue("minimumDisplayedRange")] public float MinimumDisplayedRange { get; set; }
        [BINValue("arrowSize")] public float ArrowSize { get; set; }
        [BINValue("lineWidth")] public FloatPerSpellLevel LineWidth { get; set; }
        [BINValue("overrideBaseRange")] public FloatPerSpellLevel OverrideBaseRange { get; set; }
        [BINValue("rangeGrowthStartTime")] public FloatPerSpellLevel RangeGrowthStartTime { get; set; }
        [BINValue("rangeGrowthDuration")] public FloatPerSpellLevel RangeGrowthDuration { get; set; }
        [BINValue("rangeGrowthMax")] public FloatPerSpellLevel RangeGrowthMax { get; set; }
        [BINValue("textureBaseOverrideName")] public string TextureBaseOverrideName { get; set; }
        [BINValue("textureTargetOverrideName")] public string TextureTargetOverrideName { get; set; }
        [BINValue("textureBaseMaxGrowName")] public string TextureBaseMaxGrowName { get; set; }
        [BINValue("textureTargetMaxGrowName")] public string TextureTargetMaxGrowName { get; set; }
        [BINValue("mAngleLineToEndpointHeight")] public bool AngleLineToEndpointHeight { get; set; }
        [BINValue("mCenterArrowToEndPoint")] public bool CenterArrowToEndPoint { get; set; }
        [BINValue("facingLine")] public bool FacingLine { get; set; }
        [BINValue("minAngle")] public float MinAngle { get; set; }
        [BINValue("maxAngle")] public float MaxAngle { get; set; }
        [BINValue("minAngleRangeFactor")] public float MinAngleRangeFactor { get; set; }
        [BINValue("maxAngleRangeFactor")] public float MaxAngleRangeFactor { get; set; }
        [BINValue("fade")] public bool Fade { get; set; }
        [BINValue("fadeAngle")] public float FadeAngle { get; set; }

        public TargeterDefinitionLine()
        {

        }
    }
    public class Class_877304437
    {
        [BINValue(3851804024)] public List<Class_2515485450> m3851804024 { get; set; }
        [BINValue("textures")] public List<Class_927275163> Textures { get; set; }

        public Class_877304437()
        {

        }
    }
    public class ContextualConditionSpellSlot : IContextualConditionSpell
    {
        [BINValue("mSpellSlot")] public byte SpellSlot { get; set; }

        public ContextualConditionSpellSlot()
        {

        }
    }
    public class ContextualConditionKillCount : IContextualCondition
    {
        [BINValue("mTotalKills")] public ushort TotalKills { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionKillCount()
        {

        }
    }
    public class TerrainType : Class_2144288560
    {
        [BINValue("mBrushCursor")] public CursorData BrushCursor { get; set; }
        [BINValue("mRiverCursor")] public CursorData RiverCursor { get; set; }
        [BINValue("mWallCursor")] public CursorData WallCursor { get; set; }

        public TerrainType()
        {

        }
    }
    public class OverridePerkSelectionSet
    {
        [BINValue("mStyle")] public Link<PerkStyle> Style { get; set; }
        [BINValue("mSubStyle")] public Link<PerkStyle> SubStyle { get; set; }
        [BINValue("mPerks")] public List<Perk> Perks { get; set; }

        public OverridePerkSelectionSet()
        {

        }
    }
    public class EnchantmentGroup
    {
        [BINValue("mEnchantments")] public List<int> Enchantments { get; set; }
        [BINValue("mBaseItems")] public List<int> BaseItems { get; set; }
        [BINValue("mCanSidegrade")] public bool CanSidegrade { get; set; }
        [BINValue("mItemIdRangeMinimum")] public int ItemIdRangeMinimum { get; set; }
        [BINValue("mItemIdRangeMaximum")] public int ItemIdRangeMaximum { get; set; }

        public EnchantmentGroup()
        {

        }
    }
    public class Class_905298284 : TooltipInstance
    {

        public Class_905298284()
        {

        }
    }
    public class MinMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("mDrivers")] public List<IDynamicMaterialDriver> Drivers { get; set; }

        public MinMaterialDriver()
        {

        }
    }
    public class AudioSystemDataProperties
    {
        [BINValue("systemTagEventList")] public List<AudioTagListProperties> SystemTagEventList { get; set; }

        public AudioSystemDataProperties()
        {

        }
    }
    public class Class_922712184 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }

        public Class_922712184()
        {

        }
    }
    public class Class_924071072 : IStatStoneLogicDriver
    {
        [BINValue(972553818)] public byte m972553818 { get; set; }

        public Class_924071072()
        {

        }
    }
    public class Class_927275163
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("type")] public uint Type { get; set; }
        [BINValue(761819584)] public int m761819584 { get; set; }
        [BINValue(3548357530)] public uint m3548357530 { get; set; }

        public Class_927275163()
        {

        }
    }
    public class HudVoiceChatData
    {
        [BINValue("highlightTimeoutSeconds")] public float HighlightTimeoutSeconds { get; set; }

        public HudVoiceChatData()
        {

        }
    }
    public class HudHealthBarDefenseIconData
    {
        [BINValue("enlargeTime")] public float EnlargeTime { get; set; }
        [BINValue("enlargeSize")] public float EnlargeSize { get; set; }
        [BINValue("settleTime")] public float SettleTime { get; set; }

        public HudHealthBarDefenseIconData()
        {

        }
    }
    public class GetSizeOfCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("OutSize")] public ScriptTableSet OutSize { get; set; }

        public GetSizeOfCustomTableBlock()
        {

        }
    }
    public class AddExperienceCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mGiveMaxLevel")] public bool GiveMaxLevel { get; set; }

        public AddExperienceCheat()
        {

        }
    }
    public class Class_953399041
    {
        [BINValue(1058081160)] public string m1058081160 { get; set; }

        public Class_953399041()
        {

        }
    }
    public class LiveFeatureToggles
    {
        [BINValue("mLoLToggles")] public LoLFeatureToggles LoLToggles { get; set; }
        [BINValue("mGameplayToggles")] public GameplayFeatureToggles GameplayToggles { get; set; }
        [BINValue("mEngineToggles")] public EngineFeatureToggles EngineToggles { get; set; }

        public LiveFeatureToggles()
        {

        }
    }
    public class MapSkinColorizationPostEffect
    {
        [BINValue("mMultipliersRGB")] public Vector3 MultipliersRGB { get; set; }
        [BINValue("mMultipliersSaturation")] public float MultipliersSaturation { get; set; }

        public MapSkinColorizationPostEffect()
        {

        }
    }
    public class NeutralTimerData
    {
        [BINValue("mTimerKeyName")] public string TimerKeyName { get; set; }
        [BINValue("mTooltip")] public string Tooltip { get; set; }
        [BINValue("mTooltipCampName")] public string TooltipCampName { get; set; }
        [BINValue("mTooltipRespawn")] public string TooltipRespawn { get; set; }
        [BINValue("mTooltipChatNameOrder")] public string TooltipChatNameOrder { get; set; }
        [BINValue("mTooltipChatNameChaos")] public string TooltipChatNameChaos { get; set; }
        [BINValue("mSourceIcons")] public Dictionary<Hash, NeutralTimerSourceIconData> SourceIcons { get; set; }

        public NeutralTimerData()
        {

        }
    }
    public interface HeightSolverType
    {
    }
    public class ItemGroup
    {
        [BINValue("mItemGroupID")] public Hash ItemGroupID { get; set; }
        [BINValue("mMaxGroupOwnable")] public int MaxGroupOwnable { get; set; }
        [BINValue("mInventorySlotMin")] public int InventorySlotMin { get; set; }
        [BINValue("mInventorySlotMax")] public int InventorySlotMax { get; set; }
        [BINValue("mPurchaseCooldown")] public float PurchaseCooldown { get; set; }
        [BINValue("mCooldownExtendedByAmbientGoldStart")] public bool CooldownExtendedByAmbientGoldStart { get; set; }
        [BINValue("mItemModifiers")] public List<ItemModifier> ItemModifiers { get; set; }

        public ItemGroup()
        {

        }
    }
    public class AbilityResourceTypeConfig
    {
        [BINValue("mana")] public AbilityResourceTypeData Mana { get; set; }
        [BINValue("Energy")] public AbilityResourceTypeData Energy { get; set; }
        [BINValue("None")] public AbilityResourceTypeData None { get; set; }
        [BINValue("Shield")] public AbilityResourceTypeData Shield { get; set; }
        [BINValue("BattleFury")] public AbilityResourceTypeData BattleFury { get; set; }
        [BINValue("DragonFury")] public AbilityResourceTypeData DragonFury { get; set; }
        [BINValue("Rage")] public AbilityResourceTypeData Rage { get; set; }
        [BINValue("Heat")] public AbilityResourceTypeData Heat { get; set; }
        [BINValue("PrimalFury")] public AbilityResourceTypeData PrimalFury { get; set; }
        [BINValue("Ferocity")] public AbilityResourceTypeData Ferocity { get; set; }
        [BINValue("Bloodwell")] public AbilityResourceTypeData Bloodwell { get; set; }
        [BINValue("Wind")] public AbilityResourceTypeData Wind { get; set; }
        [BINValue("Ammo")] public AbilityResourceTypeData Ammo { get; set; }
        [BINValue(3337955220)] public AbilityResourceTypeData m3337955220 { get; set; }
        [BINValue("Other")] public AbilityResourceTypeData Other { get; set; }

        public AbilityResourceTypeConfig()
        {

        }
    }
    public class TftSurrenderCheat : Cheat
    {

        public TftSurrenderCheat()
        {

        }
    }
    public class IconElementData : BaseElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mColor")] public ColorRGBAVector4Byte Color { get; set; }
        [BINValue("mUseAlpha")] public bool UseAlpha { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }

        public IconElementData()
        {

        }
    }
    public interface IDynamicMaterialDriver
    {
    }
    public interface IScriptBlock
    {
        [BINValue("IsDisabled")] bool IsDisabled { get; set; }
    }
    public class ContextualConditionGameTimer : IContextualCondition
    {
        [BINValue("mGameTimeInMinutes")] public float GameTimeInMinutes { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionGameTimer()
        {

        }
    }
    public class Class_1023490542 : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }

        public Class_1023490542()
        {

        }
    }
    public class PerkBuff
    {
        [BINValue("mBuffScriptName")] public string BuffScriptName { get; set; }
        [BINValue("mBuffSpellObject")] public SpellObject BuffSpellObject { get; set; }

        public PerkBuff()
        {

        }
    }
    public class TimeBlendData : BaseBlendData
    {
        [BINValue("mTime")] public float Time { get; set; }

        public TimeBlendData()
        {

        }
    }
    public class HudHealthBarFadeData
    {
        [BINValue("fadeSpeed")] public float FadeSpeed { get; set; }
        [BINValue("fadeAcceleration")] public float FadeAcceleration { get; set; }
        [BINValue("fadeHoldTime")] public float FadeHoldTime { get; set; }

        public HudHealthBarFadeData()
        {

        }
    }
    public class MissileGroupSpawnerSpec
    {
        [BINValue("mChildMissileSpell")] public Link<SpellObject> ChildMissileSpell { get; set; }

        public MissileGroupSpawnerSpec()
        {

        }
    }
    public class SetRespawnTimerCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mTimerValue")] public float TimerValue { get; set; }

        public SetRespawnTimerCheat()
        {

        }
    }
    public class Class_1059987028
    {
        [BINValue(1397360953)] public Dictionary<uint, bool> m1397360953 { get; set; }

        public Class_1059987028()
        {

        }
    }
    public class Class_1062280453 : Class_4153143643
    {

        public Class_1062280453()
        {

        }
    }
    public interface IContextualAction
    {
        [BINValue("mHashedSituationTrigger")] Hash HashedSituationTrigger { get; set; }
        [BINValue("mMaxOccurences")] uint MaxOccurences { get; set; }
    }
    public class GameModeConstantInteger : GameModeConstant
    {
        [BINValue("mValue")] public int Value { get; set; }

        public GameModeConstantInteger()
        {

        }
    }
    public class SyncedAnimationRigPoseModifierData : BaseRigPoseModifierData
    {

        public SyncedAnimationRigPoseModifierData()
        {

        }
    }
    public class ContextualConditionItemID : IContextualCondition
    {
        [BINValue("mItems")] public List<Hash> Items { get; set; }

        public ContextualConditionItemID()
        {

        }
    }
    public interface IDynamicMaterialFloatDriver : IDynamicMaterialDriver
    {
    }
    public class VfxReflectionDefinitionData
    {
        [BINValue("reflectionMapTexture")] public string ReflectionMapTexture { get; set; }
        [BINValue("reflectionOpacityDirect")] public float ReflectionOpacityDirect { get; set; }
        [BINValue("reflectionOpacityGlancing")] public float ReflectionOpacityGlancing { get; set; }
        [BINValue("reflectionFresnel")] public float ReflectionFresnel { get; set; }
        [BINValue("reflectionFresnelColor")] public Vector4 ReflectionFresnelColor { get; set; }
        [BINValue("fresnel")] public float Fresnel { get; set; }
        [BINValue("fresnelColor")] public Vector4 FresnelColor { get; set; }

        public VfxReflectionDefinitionData()
        {

        }
    }
    public class FlexValueVector2
    {
        [BINValue("mFlexID")] public uint FlexID { get; set; }
        [BINValue("mValue")] public ValueVector2 Value { get; set; }

        public FlexValueVector2()
        {

        }
    }
    public class ContextualConditionNegation : IContextualCondition
    {
        [BINValue("mChildCondition")] public IContextualCondition ChildCondition { get; set; }

        public ContextualConditionNegation()
        {

        }
    }
    public class FlexValueVector3
    {
        [BINValue("mFlexID")] public uint FlexID { get; set; }
        [BINValue("mValue")] public ValueVector3 Value { get; set; }

        public FlexValueVector3()
        {

        }
    }
    public class SkinAnimationProperties
    {
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }

        public SkinAnimationProperties()
        {

        }
    }
    public class LoadScreenTip
    {
        [BINValue("mId")] public ushort Id { get; set; }
        [BINValue("mHeaderLocalizationKey")] public string HeaderLocalizationKey { get; set; }
        [BINValue("mMinimumSummonerLevel")] public Optional<uint> MinimumSummonerLevel { get; set; }
        [BINValue("mMaximumSummonerLevel")] public Optional<uint> MaximumSummonerLevel { get; set; }
        [BINValue("mLocalizationKey")] public string LocalizationKey { get; set; }

        public LoadScreenTip()
        {

        }
    }
    public class AudioTagListProperties
    {
        [BINValue("tags")] public List<string> Tags { get; set; }
        [BINValue("Key")] public string Key { get; set; }

        public AudioTagListProperties()
        {

        }
    }
    public class SpellDataResource
    {
        [BINValue("flags")] public uint Flags { get; set; }
        [BINValue("mAffectsTypeFlags")] public uint AffectsTypeFlags { get; set; }
        [BINValue("mAffectsStatusFlags")] public uint AffectsStatusFlags { get; set; }
        [BINValue("mRequiredUnitTags")] public ObjectTags RequiredUnitTags { get; set; }
        [BINValue("mExcludedUnitTags")] public ObjectTags ExcludedUnitTags { get; set; }
        [BINValue("mCastRequirementsCaster")] public List<ICastRequirement> CastRequirementsCaster { get; set; }
        [BINValue("mCastRequirementsTarget")] public List<ICastRequirement> CastRequirementsTarget { get; set; }
        [BINValue("mPlatformSpellInfo")] public PlatformSpellInfo PlatformSpellInfo { get; set; }
        [BINValue("mAlternateName")] public string AlternateName { get; set; }
        [BINValue("mDisplayName")] public string DisplayName { get; set; }
        [BINValue("mDescription")] public string Description { get; set; }
        [BINValue("mSpellTags")] public List<string> SpellTags { get; set; }
        [BINValue("mDynamicTooltip")] public string DynamicTooltip { get; set; }
        [BINValue("mDynamicExtended")] public string DynamicExtended { get; set; }
        [BINValue("mEffectAmount")] public List<SpellEffectAmount> EffectAmount { get; set; }
        [BINValue("mDataValues")] public List<SpellDataValue> DataValues { get; set; }
        [BINValue(2488738436)] public Dictionary<Hash, Class_389493299> m2488738436 { get; set; }
        [BINValue("mCoefficient")] public float Coefficient { get; set; }
        [BINValue("mCoefficient2")] public float Coefficient2 { get; set; }
        [BINValue("mAnimationName")] public string AnimationName { get; set; }
        [BINValue("mAnimationLoopName")] public string AnimationLoopName { get; set; }
        [BINValue("mAnimationWinddownName")] public string AnimationWinddownName { get; set; }
        [BINValue("mAnimationLeadOutName")] public string AnimationLeadOutName { get; set; }
        [BINValue("mImgIconName")] public List<string> ImgIconName { get; set; }
        [BINValue("mMinimapIconName")] public string MinimapIconName { get; set; }
        [BINValue("mKeywordWhenAcquired")] public string KeywordWhenAcquired { get; set; }
        [BINValue("mCastTime")] public float CastTime { get; set; }
        [BINValue("mChannelDuration")] public List<float> ChannelDuration { get; set; }
        [BINValue("cooldownTime")] public List<float> CooldownTime { get; set; }
        [BINValue("delayCastOffsetPercent")] public float DelayCastOffsetPercent { get; set; }
        [BINValue("delayTotalTimePercent")] public float DelayTotalTimePercent { get; set; }
        [BINValue("mPreCastLockoutDeltaTime")] public float PreCastLockoutDeltaTime { get; set; }
        [BINValue("mPostCastLockoutDeltaTime")] public float PostCastLockoutDeltaTime { get; set; }
        [BINValue("mIsDelayedByCastLocked")] public bool IsDelayedByCastLocked { get; set; }
        [BINValue("mStartCooldown")] public float StartCooldown { get; set; }
        [BINValue("mCastRangeGrowthMax")] public List<float> CastRangeGrowthMax { get; set; }
        [BINValue("mCastRangeGrowthStartTime")] public List<float> CastRangeGrowthStartTime { get; set; }
        [BINValue("mCastRangeGrowthDuration")] public List<float> CastRangeGrowthDuration { get; set; }
        [BINValue("mChargeUpdateInterval")] public float ChargeUpdateInterval { get; set; }
        [BINValue("mCancelChargeOnRecastTime")] public float CancelChargeOnRecastTime { get; set; }
        [BINValue(1031040799)] public byte m1031040799 { get; set; }
        [BINValue(372438780)] public List<Class_3562978890> m372438780 { get; set; }
        [BINValue("mMaxAmmo")] public List<int> MaxAmmo { get; set; }
        [BINValue("mAmmoUsed")] public List<int> AmmoUsed { get; set; }
        [BINValue("mAmmoRechargeTime")] public List<float> AmmoRechargeTime { get; set; }
        [BINValue("mAmmoNotAffectedByCDR")] public bool AmmoNotAffectedByCDR { get; set; }
        [BINValue("mCooldownNotAffectedByCDR")] public bool CooldownNotAffectedByCDR { get; set; }
        [BINValue("mAmmoCountHiddenInUI")] public bool AmmoCountHiddenInUI { get; set; }
        [BINValue("mCostAlwaysShownInUI")] public bool CostAlwaysShownInUI { get; set; }
        [BINValue("cannotBeSuppressed")] public bool CannotBeSuppressed { get; set; }
        [BINValue("canCastWhileDisabled")] public bool CanCastWhileDisabled { get; set; }
        [BINValue("mCanTriggerChargeSpellWhileDisabled")] public bool CanTriggerChargeSpellWhileDisabled { get; set; }
        [BINValue("canCastOrQueueWhileCasting")] public bool CanCastOrQueueWhileCasting { get; set; }
        [BINValue("canOnlyCastWhileDisabled")] public bool CanOnlyCastWhileDisabled { get; set; }
        [BINValue("mCantCancelWhileWindingUp")] public bool CantCancelWhileWindingUp { get; set; }
        [BINValue(2117350048)] public bool m2117350048 { get; set; }
        [BINValue("mCantCancelWhileChanneling")] public bool CantCancelWhileChanneling { get; set; }
        [BINValue("cantCastWhileRooted")] public bool CantCastWhileRooted { get; set; }
        [BINValue("mChannelIsInterruptedByDisables")] public bool ChannelIsInterruptedByDisables { get; set; }
        [BINValue("mChannelIsInterruptedByAttacking")] public bool ChannelIsInterruptedByAttacking { get; set; }
        [BINValue("mApplyAttackDamage")] public bool ApplyAttackDamage { get; set; }
        [BINValue("mApplyAttackEffect")] public bool ApplyAttackEffect { get; set; }
        [BINValue("mApplyMaterialOnHitSound")] public bool ApplyMaterialOnHitSound { get; set; }
        [BINValue("mDoesntBreakChannels")] public bool DoesntBreakChannels { get; set; }
        [BINValue("mBelongsToAvatar")] public bool BelongsToAvatar { get; set; }
        [BINValue("mIsDisabledWhileDead")] public bool IsDisabledWhileDead { get; set; }
        [BINValue("canOnlyCastWhileDead")] public bool CanOnlyCastWhileDead { get; set; }
        [BINValue("mCursorChangesInGrass")] public bool CursorChangesInGrass { get; set; }
        [BINValue("mCursorChangesInTerrain")] public bool CursorChangesInTerrain { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mSpellRevealsChampion")] public bool SpellRevealsChampion { get; set; }
        [BINValue("mUseMinimapTargeting")] public bool UseMinimapTargeting { get; set; }
        [BINValue("castRangeUseBoundingBoxes")] public bool CastRangeUseBoundingBoxes { get; set; }
        [BINValue("mMinimapIconRotation")] public bool MinimapIconRotation { get; set; }
        [BINValue("mUseChargeChanneling")] public bool UseChargeChanneling { get; set; }
        [BINValue("mCanMoveWhileChanneling")] public bool CanMoveWhileChanneling { get; set; }
        [BINValue("mDisableCastBar")] public bool DisableCastBar { get; set; }
        [BINValue("mShowChannelBar")] public bool ShowChannelBar { get; set; }
        [BINValue("alwaysSnapFacing")] public bool AlwaysSnapFacing { get; set; }
        [BINValue("useAnimatorFramerate")] public bool UseAnimatorFramerate { get; set; }
        [BINValue("bHaveHitEffect")] public bool BHaveHitEffect { get; set; }
        [BINValue("bIsToggleSpell")] public bool BIsToggleSpell { get; set; }
        [BINValue("mDoNotNeedToFaceTarget")] public bool DoNotNeedToFaceTarget { get; set; }
        [BINValue("mTurnSpeedScalar")] public float TurnSpeedScalar { get; set; }
        [BINValue("mNoWinddownIfCancelled")] public bool NoWinddownIfCancelled { get; set; }
        [BINValue("mIgnoreRangeCheck")] public bool IgnoreRangeCheck { get; set; }
        [BINValue("mOrientRadiusTextureFromPlayer")] public bool OrientRadiusTextureFromPlayer { get; set; }
        [BINValue(3579459509)] public Class_1471545228 m3579459509 { get; set; }
        [BINValue("mUseAutoattackCastTime")] public bool UseAutoattackCastTime { get; set; }
        [BINValue(4119453258)] public Class_868276581 m4119453258 { get; set; }
        [BINValue("mIgnoreAnimContinueUntilCastFrame")] public bool IgnoreAnimContinueUntilCastFrame { get; set; }
        [BINValue("mHideRangeIndicatorWhenCasting")] public bool HideRangeIndicatorWhenCasting { get; set; }
        [BINValue("mUpdateRotationWhenCasting")] public bool UpdateRotationWhenCasting { get; set; }
        [BINValue("mPingableWhileDisabled")] public bool PingableWhileDisabled { get; set; }
        [BINValue("mConsideredAsAutoAttack")] public bool ConsideredAsAutoAttack { get; set; }
        [BINValue("mDoesNotConsumeMana")] public bool DoesNotConsumeMana { get; set; }
        [BINValue("mDoesNotConsumeCooldown")] public bool DoesNotConsumeCooldown { get; set; }
        [BINValue("mLockedSpellOriginationCastID")] public bool LockedSpellOriginationCastID { get; set; }
        [BINValue(2307898068)] public bool m2307898068 { get; set; }
        [BINValue("mMinimapIconDisplayFlag")] public ushort MinimapIconDisplayFlag { get; set; }
        [BINValue("castRange")] public List<float> CastRange { get; set; }
        [BINValue("castRangeDisplayOverride")] public List<float> CastRangeDisplayOverride { get; set; }
        [BINValue("castRadius")] public List<float> CastRadius { get; set; }
        [BINValue("castRadiusSecondary")] public List<float> CastRadiusSecondary { get; set; }
        [BINValue("castConeAngle")] public float CastConeAngle { get; set; }
        [BINValue("castConeDistance")] public float CastConeDistance { get; set; }
        [BINValue("castTargetAdditionalUnitsRadius")] public float CastTargetAdditionalUnitsRadius { get; set; }
        [BINValue("luaOnMissileUpdateDistanceInterval")] public float LuaOnMissileUpdateDistanceInterval { get; set; }
        [BINValue("mMissileSpec")] public MissileSpecification MissileSpec { get; set; }
        [BINValue("mCastType")] public uint CastType { get; set; }
        [BINValue("castFrame")] public float CastFrame { get; set; }
        [BINValue("missileSpeed")] public float MissileSpeed { get; set; }
        [BINValue("mMissileEffectKey")] public Hash MissileEffectKey { get; set; }
        [BINValue("mMissileEffectName")] public string MissileEffectName { get; set; }
        [BINValue("mMissileEffectPlayerKey")] public Hash MissileEffectPlayerKey { get; set; }
        [BINValue("mMissileEffectPlayerName")] public string MissileEffectPlayerName { get; set; }
        [BINValue("mMissileEffectEnemyKey")] public Hash MissileEffectEnemyKey { get; set; }
        [BINValue("mMissileEffectEnemyName")] public string MissileEffectEnemyName { get; set; }
        [BINValue("mLineWidth")] public float LineWidth { get; set; }
        [BINValue("mLineDragLength")] public float LineDragLength { get; set; }
        [BINValue("mLookAtPolicy")] public uint LookAtPolicy { get; set; }
        [BINValue("mHitEffectOrientType")] public uint HitEffectOrientType { get; set; }
        [BINValue(2460302967)] public List<ResourceResolver> m2460302967 { get; set; }
        [BINValue("mHitEffectKey")] public Hash HitEffectKey { get; set; }
        [BINValue("mHitEffectName")] public string HitEffectName { get; set; }
        [BINValue("mHitEffectPlayerKey")] public Hash HitEffectPlayerKey { get; set; }
        [BINValue("mHitEffectPlayerName")] public string HitEffectPlayerName { get; set; }
        [BINValue("mAfterEffectKey")] public Hash AfterEffectKey { get; set; }
        [BINValue("mAfterEffectName")] public string AfterEffectName { get; set; }
        [BINValue("bHaveHitBone")] public bool BHaveHitBone { get; set; }
        [BINValue("mHitBoneName")] public string HitBoneName { get; set; }
        [BINValue("mParticleStartOffset")] public Vector3 ParticleStartOffset { get; set; }
        [BINValue("mFloatVarsDecimals")] public List<int> FloatVarsDecimals { get; set; }
        [BINValue("mana")] public List<float> Mana { get; set; }
        [BINValue("manaUiOverride")] public List<float> ManaUiOverride { get; set; }
        [BINValue("selectionPriority")] public uint SelectionPriority { get; set; }
        [BINValue("mTargetingTypeData")] public Class_2144288560 TargetingTypeData { get; set; }
        [BINValue("mVOEventCategory")] public string VOEventCategory { get; set; }
        [BINValue("mAIData")] public AISpellData AIData { get; set; }
        [BINValue("mSpellCooldownOrSealedQueueThreshold")] public Optional<float> SpellCooldownOrSealedQueueThreshold { get; set; }
        [BINValue(66335398)] public byte m66335398 { get; set; }
        [BINValue(16246204)] public bool m16246204 { get; set; }
        [BINValue("mClientData")] public SpellDataResourceClient ClientData { get; set; }

        public SpellDataResource()
        {

        }
    }
    public class VfxAnimatedColorVariableData
    {
        [BINValue("probabilityTables")] public List<VfxProbabilityTableData> ProbabilityTables { get; set; }
        [BINValue("times")] public List<float> Times { get; set; }
        [BINValue("values")] public List<Vector4> Values { get; set; }

        public VfxAnimatedColorVariableData()
        {

        }
    }
    public class LinearTransformProcessorData : ValueProcessorData
    {
        [BINValue("mMultiplier")] public float Multiplier { get; set; }
        [BINValue("mIncrement")] public float Increment { get; set; }

        public LinearTransformProcessorData()
        {

        }
    }
    public class CharacterVarsTable : ScriptTable
    {

        public CharacterVarsTable()
        {

        }
    }
    public class BoolGet : IBoolGet
    {
        [BINValue("value")] public bool Value { get; set; }

        public BoolGet()
        {

        }
    }
    public class CheatSet
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mIsPlayerFacing")] public bool IsPlayerFacing { get; set; }
        [BINValue("mGameMutator")] public string GameMutator { get; set; }
        [BINValue("mGameModeName")] public Hash GameModeName { get; set; }
        [BINValue(736167517)] public Link<Champion> m736167517 { get; set; }
        [BINValue("mCheatPages")] public List<CheatPage> CheatPages { get; set; }
        [BINValue("mUseIconsForButtons")] public bool UseIconsForButtons { get; set; }
        [BINValue("mIsUIAlwaysShown")] public bool IsUIAlwaysShown { get; set; }

        public CheatSet()
        {

        }
    }
    public interface IStringGet : IScriptValueGet
    {
    }
    public class VfxSystemDefinitionData : IResource
    {
        [BINValue("materialOverrideDefinitions")] public List<VfxMaterialOverrideDefinitionData> MaterialOverrideDefinitions { get; set; }
        [BINValue("complexEmitterDefinitionData")] public List<VfxEmitterDefinitionData> ComplexEmitterDefinitionData { get; set; }
        [BINValue("simpleEmitterDefinitionData")] public List<VfxEmitterDefinitionData> SimpleEmitterDefinitionData { get; set; }
        [BINValue("visibilityRadius")] public float VisibilityRadius { get; set; }
        [BINValue("particleName")] public string ParticleName { get; set; }
        [BINValue("particlePath")] public string ParticlePath { get; set; }
        [BINValue("overrideScaleCap")] public Optional<float> OverrideScaleCap { get; set; }
        [BINValue("soundOnCreateDefault")] public string SoundOnCreateDefault { get; set; }
        [BINValue("voiceOverOnCreateDefault")] public string VoiceOverOnCreateDefault { get; set; }
        [BINValue("soundPersistentDefault")] public string SoundPersistentDefault { get; set; }
        [BINValue("voiceOverPersistentDefault")] public string VoiceOverPersistentDefault { get; set; }
        [BINValue("assetCategory")] public string AssetCategory { get; set; }
        [BINValue("audioParameterFlexID")] public int AudioParameterFlexID { get; set; }
        [BINValue("audioParameterTimeScaledDuration")] public float AudioParameterTimeScaledDuration { get; set; }
        [BINValue("flags")] public uint Flags { get; set; }
        [BINValue("buildUpTime")] public float BuildUpTime { get; set; }
        [BINValue("selfIllumination")] public float SelfIllumination { get; set; }
        [BINValue("assetRemappingTable")] public List<VfxAssetRemap> AssetRemappingTable { get; set; }
        [BINValue("systemTranslation")] public Vector3 SystemTranslation { get; set; }
        [BINValue("systemScale")] public Vector3 SystemScale { get; set; }
        [BINValue("drawingLayer")] public uint DrawingLayer { get; set; }
        [BINValue("hudLayerDimension")] public float HudLayerDimension { get; set; }
        [BINValue(3180870615)] public float m3180870615 { get; set; }
        [BINValue("hudLayerStretchFullscreen")] public bool HudLayerStretchFullscreen { get; set; }
        [BINValue("hudAnchorPositionFromWorldProjection")] public bool HudAnchorPositionFromWorldProjection { get; set; }
        [BINValue("scaleDynamicallyWithAttachedBone")] public bool ScaleDynamicallyWithAttachedBone { get; set; }
        [BINValue("mEyeCandy")] public bool EyeCandy { get; set; }
        [BINValue(3473471718)] public bool m3473471718 { get; set; }

        public VfxSystemDefinitionData()
        {

        }
    }
    public class SwitchMaterialDriverElement
    {
        [BINValue("mCondition")] public IDynamicMaterialBoolDriver Condition { get; set; }
        [BINValue("mValue")] public IDynamicMaterialDriver Value { get; set; }

        public SwitchMaterialDriverElement()
        {

        }
    }
    public class Class_1173599148 : MapPlaceable
    {
        [BINValue(2120627422)] public Link<Class_2992376383> m2120627422 { get; set; }

        public Class_1173599148()
        {

        }
    }
    public class TrophyData : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("mPerceptionBubbleRadius")] public float PerceptionBubbleRadius { get; set; }
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }
        [BINValue("mVFXResourceResolver")] public ResourceResolver VFXResourceResolver { get; set; }
        [BINValue("mBracketTRAKey")] public string BracketTRAKey { get; set; }

        public TrophyData()
        {

        }
    }
    public class BuffData
    {
        [BINValue("mDescription")] public string Description { get; set; }
        [BINValue("mTooltipData")] public TooltipInstanceBuff TooltipData { get; set; }
        [BINValue("mVfxSpawnConditions")] public List<VfxSpawnConditions> VfxSpawnConditions { get; set; }
        [BINValue("mShowDuration")] public bool ShowDuration { get; set; }
        [BINValue("mFloatVarsDecimals")] public List<int> FloatVarsDecimals { get; set; }
        [BINValue("mBuffAttributeFlags")] public byte BuffAttributeFlags { get; set; }

        public BuffData()
        {

        }
    }
    public class Class_1181419247 : IDynamicMaterialDriver
    {
        [BINValue("mColor")] public Vector4 Color { get; set; }

        public Class_1181419247()
        {

        }
    }
    public class Class_1203614713 : IStatStoneLogicDriver
    {

        public Class_1203614713()
        {

        }
    }
    public class Class_1207715590
    {
        [BINValue(2551311184)] public float m2551311184 { get; set; }
        [BINValue(2194368105)] public float m2194368105 { get; set; }
        [BINValue("mMaxXTop")] public float MaxXTop { get; set; }
        [BINValue("mMaxXBottom")] public float MaxXBottom { get; set; }

        public Class_1207715590()
        {

        }
    }
    public class ESportLeagueEntry
    {
        [BINValue("leagueName")] public string LeagueName { get; set; }
        [BINValue("textureName")] public string TextureName { get; set; }

        public ESportLeagueEntry()
        {

        }
    }
    public class MapParticleGroups
    {
        [BINValue("groups")] public List<string> Groups { get; set; }

        public MapParticleGroups()
        {

        }
    }
    public interface GDSMapObjectExtraInfo
    {
    }
    public class VfxDistortionDefinitionData
    {
        [BINValue("distortion")] public float Distortion { get; set; }
        [BINValue("distortionMode")] public uint DistortionMode { get; set; }
        [BINValue("normalMapTexture")] public string NormalMapTexture { get; set; }

        public VfxDistortionDefinitionData()
        {

        }
    }
    public interface ISecondaryResourceDisplayData
    {
    }
    public class SelectorClipData : ClipBaseData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mSelectorPairDataList")] public List<SelectorPairData> SelectorPairDataList { get; set; }

        public SelectorClipData()
        {

        }
    }
    public class CharacterPreloadList
    {
        [BINValue("mCharacters")] public List<CharacterPreloadData> Characters { get; set; }

        public CharacterPreloadList()
        {

        }
    }
    public class InteractionData
    {
        [BINValue("idleAnim")] public string IdleAnim { get; set; }
        [BINValue("shouldRandomizeIdleAnimPhase")] public bool ShouldRandomizeIdleAnimPhase { get; set; }

        public InteractionData()
        {

        }
    }
    public class BuffCounterByCoefficientCalculationPart : Class_1989226833
    {
        [BINValue("mBuffName")] public Hash BuffName { get; set; }
        [BINValue(9297440)] public string m9297440 { get; set; }
        [BINValue(3047920162)] public string m3047920162 { get; set; }
        [BINValue("mCoefficient")] public float Coefficient { get; set; }

        public BuffCounterByCoefficientCalculationPart()
        {

        }
    }
    public class ColorChooserMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("mBoolDriver")] public IDynamicMaterialBoolDriver BoolDriver { get; set; }
        [BINValue("mColorOn")] public Vector4 ColorOn { get; set; }
        [BINValue("mColorOff")] public Vector4 ColorOff { get; set; }

        public ColorChooserMaterialDriver()
        {

        }
    }
    public class FunctionTableSet : ScriptTableSet
    {

        public FunctionTableSet()
        {

        }
    }
    public class VfxPrimitiveArbitraryQuad : VfxPrimitiveBase
    {

        public VfxPrimitiveArbitraryQuad()
        {

        }
    }
    public class UnitStatusData
    {
        [BINValue("locType")] public uint LocType { get; set; }
        [BINValue("attackableUnitStatusType")] public uint AttackableUnitStatusType { get; set; }
        [BINValue("statusName")] public string StatusName { get; set; }
        [BINValue("textColor")] public Optional<ColorRGBAVector4Byte> TextColor { get; set; }
        [BINValue("imageInfo")] public HealthbarImageInfo ImageInfo { get; set; }

        public UnitStatusData()
        {

        }
    }
    public interface TargeterDefinition
    {
        [BINValue(3384398744)] Class_1348413282 m3384398744 { get; set; }
    }
    public class FadeEventData : BaseEventData
    {
        [BINValue("mTimeToFade")] public float TimeToFade { get; set; }
        [BINValue("mTargetAlpha")] public float TargetAlpha { get; set; }

        public FadeEventData()
        {

        }
    }
    public class NeutralTimers
    {
        [BINValue("mSceneName")] public string SceneName { get; set; }
        [BINValue(4002892974)] public string m4002892974 { get; set; }
        [BINValue("mTimers")] public Dictionary<Hash, NeutralTimerData> Timers { get; set; }

        public NeutralTimers()
        {

        }
    }
    public class HudGearSelectionUIData
    {
        [BINValue("mGearSelectionTransitionIntro")] public HudMenuTransitionData GearSelectionTransitionIntro { get; set; }
        [BINValue("mGearSelectionTransitionOutro")] public HudMenuTransitionData GearSelectionTransitionOutro { get; set; }
        [BINValue("selectionButtonDelayTime")] public float SelectionButtonDelayTime { get; set; }
        [BINValue("timerEnabled")] public bool TimerEnabled { get; set; }
        [BINValue("timerCountdownDuration")] public float TimerCountdownDuration { get; set; }
        [BINValue("timerCountdownWarningStart")] public float TimerCountdownWarningStart { get; set; }

        public HudGearSelectionUIData()
        {

        }
    }
    public class DynamicMaterialTextureSwapDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("enabled")] public bool Enabled { get; set; }
        [BINValue("options")] public List<DynamicMaterialTextureSwapOption> Options { get; set; }

        public DynamicMaterialTextureSwapDef()
        {

        }
    }
    public class FollowTerrainHeightSolver : HeightSolverType
    {
        [BINValue("mHeightOffset")] public float HeightOffset { get; set; }
        [BINValue(3821269113)] public float m3821269113 { get; set; }

        public FollowTerrainHeightSolver()
        {

        }
    }
    public class ScriptPreloadModule
    {
        [BINValue("PreloadResourceName")] public string PreloadResourceName { get; set; }

        public ScriptPreloadModule()
        {

        }
    }
    public class HudSpellSlotResetFeedbackData
    {
        [BINValue("spellResetFlashFadeDuration")] public float SpellResetFlashFadeDuration { get; set; }
        [BINValue("spellResetFlashScaleDownDuration")] public float SpellResetFlashScaleDownDuration { get; set; }
        [BINValue("spellResetScaleMultiplier")] public float SpellResetScaleMultiplier { get; set; }

        public HudSpellSlotResetFeedbackData()
        {

        }
    }
    public class Class_1323437592 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }
        [BINValue("mSkinId")] public uint SkinId { get; set; }

        public Class_1323437592()
        {

        }
    }
    public class EffectDesaturateElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }
        [BINValue("MinimumSaturation")] public float MinimumSaturation { get; set; }
        [BINValue("MaximumSaturation")] public float MaximumSaturation { get; set; }

        public EffectDesaturateElementData()
        {

        }
    }
    public class MasteryBadgeData
    {
        [BINValue("mName")] public Hash Name { get; set; }
        [BINValue("mParticleName")] public string ParticleName { get; set; }
        [BINValue("mRenderScale")] public float RenderScale { get; set; }
        [BINValue("mVerticalOffset")] public float VerticalOffset { get; set; }
        [BINValue("mSummonerIconId")] public int SummonerIconId { get; set; }
        [BINValue("mMasteryLevel")] public uint MasteryLevel { get; set; }

        public MasteryBadgeData()
        {

        }
    }
    public class Class_1340671070
    {
        [BINValue(36378503)] public Class_1573027425 m36378503 { get; set; }
        [BINValue(4040593892)] public Class_2068371646 m4040593892 { get; set; }
        [BINValue(53570106)] public Class_1850343160 m53570106 { get; set; }

        public Class_1340671070()
        {

        }
    }
    public interface BlendableClipData : ClipBaseData
    {
        [BINValue("mMaskDataName")] Hash MaskDataName { get; set; }
        [BINValue("mTrackDataName")] Hash TrackDataName { get; set; }
        [BINValue("mSyncGroupDataName")] Hash SyncGroupDataName { get; set; }
        [BINValue("mEventDataMap")] Dictionary<Hash, BaseEventData> EventDataMap { get; set; }
    }
    public interface Class_1348413282
    {
    }
    public class Class_1349646866 : Class_3813882857
    {
        [BINValue("mConditions")] public List<Class_2412429686> Conditions { get; set; }
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public Class_1349646866()
        {

        }
    }
    public class ClearTargetCooldownCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }

        public ClearTargetCooldownCheat()
        {

        }
    }
    public class Class_1363101953
    {
        [BINValue(3319925574)] public string m3319925574 { get; set; }
        [BINValue(1650743417)] public bool m1650743417 { get; set; }
        [BINValue(1666346813)] public List<Class_2724041810> m1666346813 { get; set; }

        public Class_1363101953()
        {

        }
    }
    public class HermiteSplineInfo : ISplineInfo
    {
        [BINValue("mStartPositionOffset")] public Vector3 StartPositionOffset { get; set; }
        [BINValue("mUseMissilePositionAsOrigin")] public bool UseMissilePositionAsOrigin { get; set; }
        [BINValue("mControlPoint1")] public Vector3 ControlPoint1 { get; set; }
        [BINValue("mControlPoint2")] public Vector3 ControlPoint2 { get; set; }

        public HermiteSplineInfo()
        {

        }
    }
    public class FlexValueFloat
    {
        [BINValue("mFlexID")] public uint FlexID { get; set; }
        [BINValue("mValue")] public ValueFloat Value { get; set; }

        public FlexValueFloat()
        {

        }
    }
    public class VfxFloatOverLifeMaterialDriver : IVfxMaterialDriver
    {
        [BINValue("frequency")] public byte Frequency { get; set; }
        [BINValue("graph")] public VfxAnimatedFloatVariableData Graph { get; set; }

        public VfxFloatOverLifeMaterialDriver()
        {

        }
    }
    public class Class_1376467180
    {
        [BINValue(3602094040)] public bool m3602094040 { get; set; }
        [BINValue(1497660678)] public byte m1497660678 { get; set; }
        [BINValue(2073776835)] public uint m2073776835 { get; set; }

        public Class_1376467180()
        {

        }
    }
    public class ContextualConditionShopCloseCount : IContextualCondition
    {
        [BINValue("mShopCloseCount")] public uint ShopCloseCount { get; set; }

        public ContextualConditionShopCloseCount()
        {

        }
    }
    public class SkinCharacterMetaDataProperties_SpawningSkinOffset
    {
        [BINValue("tag")] public string Tag { get; set; }
        [BINValue("offset")] public int Offset { get; set; }

        public SkinCharacterMetaDataProperties_SpawningSkinOffset()
        {

        }
    }
    public class VfxProbabilityTableData
    {
        [BINValue("keyTimes")] public List<float> KeyTimes { get; set; }
        [BINValue("keyValues")] public List<float> KeyValues { get; set; }
        [BINValue("singleValue")] public float SingleValue { get; set; }

        public VfxProbabilityTableData()
        {

        }
    }
    public interface Class_1405067729
    {
    }
    public class PassThroughParamsTable : ScriptTable
    {

        public PassThroughParamsTable()
        {

        }
    }
    public class TrackMouseMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue(2226849642)] public List<float> m2226849642 { get; set; }
        [BINValue("mInferDirectionFromFacingIfNeeded")] public bool InferDirectionFromFacingIfNeeded { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mUseGroundHeightAtTarget")] public bool UseGroundHeightAtTarget { get; set; }
        [BINValue("mAcceleration")] public float Acceleration { get; set; }
        [BINValue("mMinSpeed")] public float MinSpeed { get; set; }
        [BINValue("mMaxSpeed")] public float MaxSpeed { get; set; }
        [BINValue("mInitialSpeed")] public float InitialSpeed { get; set; }
        [BINValue(1615432143)] public float m1615432143 { get; set; }

        public TrackMouseMovement()
        {

        }
    }
    public class WorldVarsTable : ScriptTable
    {

        public WorldVarsTable()
        {

        }
    }
    public class ContextualConditionHasGold : IContextualCondition
    {
        [BINValue("mGold")] public float Gold { get; set; }

        public ContextualConditionHasGold()
        {

        }
    }
    public class UpdaterResourceData
    {
        [BINValue("mUpdaterDataList")] public List<UpdaterData> UpdaterDataList { get; set; }

        public UpdaterResourceData()
        {

        }
    }
    public class RigResource
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mAssetName")] public string AssetName { get; set; }
        [BINValue("mFlags")] public ushort Flags { get; set; }
        [BINValue("mJointList")] public List<Joint> JointList { get; set; }
        [BINValue("mShaderJointList")] public List<ushort> ShaderJointList { get; set; }

        public RigResource()
        {

        }
    }
    public class Class_1441690361
    {

        public Class_1441690361()
        {

        }
    }
    public class Class_1442744202 : IContextualCondition
    {
        [BINValue(253046910)] public List<string> m253046910 { get; set; }

        public Class_1442744202()
        {

        }
    }
    public class Class_1442793122 : IStatStoneLogicDriver
    {
        [BINValue(1203421971)] public bool m1203421971 { get; set; }
        [BINValue(507497828)] public bool m507497828 { get; set; }
        [BINValue(3588584256)] public bool m3588584256 { get; set; }

        public Class_1442793122()
        {

        }
    }
    public class ContextualConditionCharacterLevel : IContextualCondition
    {
        [BINValue("mCharacterLevel")] public byte CharacterLevel { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionCharacterLevel()
        {

        }
    }
    public class Class_1459861871 : SwitchMaterialDriver
    {
        [BINValue(970057882)] public float m970057882 { get; set; }
        [BINValue(642664763)] public List<float> m642664763 { get; set; }

        public Class_1459861871()
        {

        }
    }
    public class VfxPrimitiveArbitraryTrail : VfxPrimitiveTrailBase
    {
        [BINValue("mTrail")] public VfxTrailDefinitionData Trail { get; set; }

        public VfxPrimitiveArbitraryTrail()
        {

        }
    }
    public class Class_1461391717
    {
        [BINValue("color")] public Optional<ColorRGBAVector4Byte> Color { get; set; }
        [BINValue("bold")] public Optional<bool> Bold { get; set; }
        [BINValue(2924892218)] public Optional<bool> m2924892218 { get; set; }
        [BINValue(3850515583)] public Optional<bool> m3850515583 { get; set; }

        public Class_1461391717()
        {

        }
    }
    public class HasUnitTagsCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mUnitTags")] public ObjectTags UnitTags { get; set; }

        public HasUnitTagsCastRequirement()
        {

        }
    }
    public class BuffCounterDynamicMaterialFloatDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mScriptName")] public string ScriptName { get; set; }

        public BuffCounterDynamicMaterialFloatDriver()
        {

        }
    }
    public class Class_1471545228
    {
        [BINValue(546903361)] public Class_389493299 m546903361 { get; set; }
        [BINValue(2238351055)] public float m2238351055 { get; set; }

        public Class_1471545228()
        {

        }
    }
    public class StatByCoefficientCalculationPart : Class_3052837161
    {
        [BINValue("mStat")] public byte Stat { get; set; }
        [BINValue(2100383980)] public byte m2100383980 { get; set; }
        [BINValue("mCoefficient")] public float Coefficient { get; set; }

        public StatByCoefficientCalculationPart()
        {

        }
    }
    public class Class_1484706743
    {
        [BINValue(1309176603)] public List<Class_730516414> m1309176603 { get; set; }

        public Class_1484706743()
        {

        }
    }
    public class HudRadialWheelData
    {
        [BINValue("mRadialWheelUITransitionData")] public HudMenuTransitionData RadialWheelUITransitionData { get; set; }
        [BINValue("mRadialWheelButtonTransitionIntro")] public HudMenuTransitionData RadialWheelButtonTransitionIntro { get; set; }
        [BINValue("mRadialWheelButtonTransitionOutro")] public HudMenuTransitionData RadialWheelButtonTransitionOutro { get; set; }
        [BINValue("activateWheelDelayTime")] public float ActivateWheelDelayTime { get; set; }

        public HudRadialWheelData()
        {

        }
    }
    public class MapParticle : MapPlaceable
    {
        [BINValue("system")] public Link<VfxSystemDefinitionData> System { get; set; }
        [BINValue("eyeCandy")] public bool EyeCandy { get; set; }
        [BINValue("quality")] public int Quality { get; set; }
        [BINValue("visibilityMode")] public uint VisibilityMode { get; set; }
        [BINValue("colorModulate")] public Vector4 ColorModulate { get; set; }
        [BINValue("groupName")] public string GroupName { get; set; }

        public MapParticle()
        {

        }
    }
    public class MapPlaceable
    {
        [BINValue("transform")] public R3DMatrix44 Transform { get; set; }
        [BINValue("name")] public string Name { get; set; }
        [BINValue(3438777127)] public byte m3438777127 { get; set; }

        public MapPlaceable()
        {

        }
    }
    public class PerkReplacement
    {
        [BINValue("mReplaceTarget")] public Hash ReplaceTarget { get; set; }
        [BINValue("mReplaceWith")] public Hash ReplaceWith { get; set; }

        public PerkReplacement()
        {

        }
    }
    public class PlatformSpellInfo
    {
        [BINValue("mAvatarLevelRequired")] public int AvatarLevelRequired { get; set; }
        [BINValue("mSpellID")] public int SpellID { get; set; }
        [BINValue("mPlatformEnabled")] public bool PlatformEnabled { get; set; }
        [BINValue("mGameModes")] public List<string> GameModes { get; set; }

        public PlatformSpellInfo()
        {

        }
    }
    public class PerkConfig
    {
        [BINValue("mBotOverrideSet")] public Link<OverridePerkSelectionSet> BotOverrideSet { get; set; }
        [BINValue("mPerkReplacements")] public PerkReplacementList PerkReplacements { get; set; }
        [BINValue(277771373)] public uint m277771373 { get; set; }

        public PerkConfig()
        {

        }
    }
    public class HasBuffCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mBuffName")] public Hash BuffName { get; set; }
        [BINValue("mFromAnyone")] public bool FromAnyone { get; set; }

        public HasBuffCastRequirement()
        {

        }
    }
    public class IntOffsetTableGet : IIntGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("offset")] public int Offset { get; set; }

        public IntOffsetTableGet()
        {

        }
    }
    public class AtomicClipData : BlendableClipData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mMaskDataName")] public Hash MaskDataName { get; set; }
        [BINValue("mTrackDataName")] public Hash TrackDataName { get; set; }
        [BINValue("mSyncGroupDataName")] public Hash SyncGroupDataName { get; set; }
        [BINValue("mEventDataMap")] public Dictionary<Hash, BaseEventData> EventDataMap { get; set; }
        [BINValue("mTickDuration")] public float TickDuration { get; set; }
        [BINValue("mAnimationResourceData")] public AnimationResourceData AnimationResourceData { get; set; }
        [BINValue("mUpdaterResourceData")] public UpdaterResourceData UpdaterResourceData { get; set; }

        public AtomicClipData()
        {

        }
    }
    public interface ICastRequirement
    {
        [BINValue("mInvertResult")] bool InvertResult { get; set; }
    }
    public class Class_1556398653 : Class_3813882857
    {
        [BINValue("mConditions")] public List<Class_3706207649> Conditions { get; set; }
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public Class_1556398653()
        {

        }
    }
    public class Class_1559666382 : Class_308440063
    {
        [BINValue("mLevel1Value")] public float Level1Value { get; set; }
        [BINValue(48149840)] public float m48149840 { get; set; }
        [BINValue("mBreakpoints")] public List<Breakpoint> Breakpoints { get; set; }

        public Class_1559666382()
        {

        }
    }
    public class GetKeyValueInCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("Key")] public IScriptValueGet Key { get; set; }
        [BINValue("OutValue")] public ScriptTableSet OutValue { get; set; }

        public GetKeyValueInCustomTableBlock()
        {

        }
    }
    public class EmblemPosition
    {
        [BINValue("mVertical")] public string Vertical { get; set; }
        [BINValue("mHorizontal")] public string Horizontal { get; set; }

        public EmblemPosition()
        {

        }
    }
    public class Class_1572954563 : Class_66354938
    {
        [BINValue(1664582205)] public string m1664582205 { get; set; }
        [BINValue(1686403411)] public Vector4 m1686403411 { get; set; }
        [BINValue(2411172191)] public List<Class_769601740> m2411172191 { get; set; }
        [BINValue(839153119)] public bool m839153119 { get; set; }

        public Class_1572954563()
        {

        }
    }
    public class Class_1573027425
    {
        [BINValue(3747431117)] public HudMenuTransitionData m3747431117 { get; set; }
        [BINValue(1162113435)] public float m1162113435 { get; set; }

        public Class_1573027425()
        {

        }
    }
    public class ParticleEventDataPair
    {
        [BINValue("mBoneName")] public Hash BoneName { get; set; }
        [BINValue("mTargetBoneName")] public Hash TargetBoneName { get; set; }

        public ParticleEventDataPair()
        {

        }
    }
    public class Class_1577686390 : IStatStoneLogicDriver
    {
        [BINValue(3803982007)] public float m3803982007 { get; set; }

        public Class_1577686390()
        {

        }
    }
    public class EffectLineElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }
        [BINValue("mThickness")] public float Thickness { get; set; }
        [BINValue("mRightSlicePercentage")] public float RightSlicePercentage { get; set; }

        public EffectLineElementData()
        {

        }
    }
    public class SpellObject
    {
        [BINValue("mScriptName")] public string ScriptName { get; set; }
        [BINValue("mScript")] public LolSpellScript Script { get; set; }
        [BINValue("mSpell")] public SpellDataResource Spell { get; set; }
        [BINValue("mBuff")] public BuffData Buff { get; set; }

        public SpellObject()
        {

        }
    }
    public class VfxAlphaErosionDefinitionData
    {
        [BINValue("erosionDriveCurve")] public ValueFloat ErosionDriveCurve { get; set; }
        [BINValue("erosionDriveSource")] public uint ErosionDriveSource { get; set; }
        [BINValue(649389603)] public bool m649389603 { get; set; }
        [BINValue(2102344908)] public ValueFloat m2102344908 { get; set; }
        [BINValue("erosionFeatherIn")] public float ErosionFeatherIn { get; set; }
        [BINValue("erosionFeatherOut")] public float ErosionFeatherOut { get; set; }
        [BINValue("erosionSliceWidth")] public float ErosionSliceWidth { get; set; }
        [BINValue("erosionMapName")] public string ErosionMapName { get; set; }
        [BINValue("erosionMapChannelMixer")] public ValueColor ErosionMapChannelMixer { get; set; }
        [BINValue("erosionMapAddressMode")] public uint ErosionMapAddressMode { get; set; }

        public VfxAlphaErosionDefinitionData()
        {

        }
    }
    public class TooltipInstanceBuff : TooltipInstance
    {
        [BINValue(2929024189)] public bool m2929024189 { get; set; }

        public TooltipInstanceBuff()
        {

        }
    }
    public class Class_1589364011
    {
        [BINValue(766608976)] public List<uint> m766608976 { get; set; }

        public Class_1589364011()
        {

        }
    }
    public class EVOSettings
    {
        [BINValue("mEnableChatVO")] public bool EnableChatVO { get; set; }
        [BINValue("mEnableAnnouncerVOReplacement")] public bool EnableAnnouncerVOReplacement { get; set; }
        [BINValue("mChatVOThrottleCounterThreshold")] public int ChatVOThrottleCounterThreshold { get; set; }
        [BINValue("mChatVOThrottleCounterDecayTime")] public float ChatVOThrottleCounterDecayTime { get; set; }
        [BINValue("mPingVOThrottleThreshold")] public float PingVOThrottleThreshold { get; set; }

        public EVOSettings()
        {

        }
    }
    public class StatByNamedDataValueCalculationPart : Class_3052837161
    {
        [BINValue("mStat")] public byte Stat { get; set; }
        [BINValue(2100383980)] public byte m2100383980 { get; set; }
        [BINValue("mDataValue")] public Hash DataValue { get; set; }

        public StatByNamedDataValueCalculationPart()
        {

        }
    }
    public class ContextualConditionMoveDistance : IContextualCondition
    {
        [BINValue("mDistance")] public float Distance { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionMoveDistance()
        {

        }
    }
    public class SpawningUIDefinition
    {
        [BINValue("buffNameFilter")] public string BuffNameFilter { get; set; }
        [BINValue("maxNumberOfUnits")] public int MaxNumberOfUnits { get; set; }

        public SpawningUIDefinition()
        {

        }
    }
    public class FloatGet : IFloatGet
    {
        [BINValue("value")] public float Value { get; set; }

        public FloatGet()
        {

        }
    }
    public class ContextualConditionSpellName : IContextualConditionSpell
    {
        [BINValue("mSpell")] public Hash Spell { get; set; }

        public ContextualConditionSpellName()
        {

        }
    }
    public class ContextualConditionCharacterIsCastingRecall : ICharacterSubcondition
    {

        public ContextualConditionCharacterIsCastingRecall()
        {

        }
    }
    public class ShaderStaticSwitch
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("onByDefault")] public bool OnByDefault { get; set; }

        public ShaderStaticSwitch()
        {

        }
    }
    public class SameTeamCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }

        public SameTeamCastRequirement()
        {

        }
    }
    public class SkinMeshDataProperties
    {
        [BINValue("skeleton")] public string Skeleton { get; set; }
        [BINValue("simpleSkin")] public string SimpleSkin { get; set; }
        [BINValue("maxNumBlendWeights")] public int MaxNumBlendWeights { get; set; }
        [BINValue("texture")] public string Texture { get; set; }
        [BINValue("emissiveTexture")] public string EmissiveTexture { get; set; }
        [BINValue("glossTexture")] public string GlossTexture { get; set; }
        [BINValue("skinScale")] public float SkinScale { get; set; }
        [BINValue("selfIllumination")] public float SelfIllumination { get; set; }
        [BINValue("brushAlphaOverride")] public float BrushAlphaOverride { get; set; }
        [BINValue("overrideBoundingBox")] public Optional<Vector3> OverrideBoundingBox { get; set; }
        [BINValue("material")] public Link<IMaterialDef> Material { get; set; }
        [BINValue("boundingCylinderRadius")] public float BoundingCylinderRadius { get; set; }
        [BINValue("boundingCylinderHeight")] public float BoundingCylinderHeight { get; set; }
        [BINValue("boundingSphereRadius")] public Optional<float> BoundingSphereRadius { get; set; }
        [BINValue("fresnelColor")] public ColorRGBAVector4Byte FresnelColor { get; set; }
        [BINValue("fresnel")] public float Fresnel { get; set; }
        [BINValue("usesSkinVO")] public bool UsesSkinVO { get; set; }
        [BINValue("castShadows")] public bool CastShadows { get; set; }
        [BINValue("allowCharacterInking")] public bool AllowCharacterInking { get; set; }
        [BINValue("reflectionMap")] public string ReflectionMap { get; set; }
        [BINValue("reflectionOpacityDirect")] public float ReflectionOpacityDirect { get; set; }
        [BINValue("reflectionOpacityGlancing")] public float ReflectionOpacityGlancing { get; set; }
        [BINValue("reflectionFresnel")] public float ReflectionFresnel { get; set; }
        [BINValue("reflectionFresnelColor")] public ColorRGBAVector4Byte ReflectionFresnelColor { get; set; }
        [BINValue("initialSubmeshToHide")] public string InitialSubmeshToHide { get; set; }
        [BINValue("initialSubmeshShadowsToHide")] public string InitialSubmeshShadowsToHide { get; set; }
        [BINValue("initialSubmeshMouseOversToHide")] public string InitialSubmeshMouseOversToHide { get; set; }
        [BINValue("submeshRenderOrder")] public string SubmeshRenderOrder { get; set; }
        [BINValue("materialOverride")] public List<SkinMeshDataProperties_MaterialOverride> MaterialOverride { get; set; }
        [BINValue(2059875848)] public Class_3460011047 m2059875848 { get; set; }
        [BINValue("rigPoseModifierData")] public List<BaseRigPoseModifierData> RigPoseModifierData { get; set; }

        public SkinMeshDataProperties()
        {

        }
    }
    public class ContextualConditionOwnerTeamNetChampionKills : IContextualCondition
    {
        [BINValue("mOwnerTeamNetKillAdvantage")] public int OwnerTeamNetKillAdvantage { get; set; }
        [BINValue("mKillAdvantageCompareOp")] public byte KillAdvantageCompareOp { get; set; }
        [BINValue("mTimeFrameSeconds")] public float TimeFrameSeconds { get; set; }

        public ContextualConditionOwnerTeamNetChampionKills()
        {

        }
    }
    public class Class_1645499771
    {
        [BINValue(3754862555)] public float m3754862555 { get; set; }

        public Class_1645499771()
        {

        }
    }
    public class TargeterDefinitionWall : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("centerLocator")] public DrawablePositionLocator CenterLocator { get; set; }
        [BINValue("wallOrientation")] public uint WallOrientation { get; set; }
        [BINValue("wallRotation")] public float WallRotation { get; set; }
        [BINValue("thickness")] public FloatPerSpellLevel Thickness { get; set; }
        [BINValue("length")] public FloatPerSpellLevel Length { get; set; }
        [BINValue("textureWallOverrideName")] public string TextureWallOverrideName { get; set; }

        public TargeterDefinitionWall()
        {

        }
    }
    public interface GenericSplineMovementSpec : MissileMovementSpec
    {
        [BINValue("mSplineInfo")] ISplineInfo SplineInfo { get; set; }
        [BINValue("mUseMissilePositionAsOrigin")] bool UseMissilePositionAsOrigin { get; set; }
    }
    public class TftEffectAmount
    {
        [BINValue("name")] public Hash Name { get; set; }
        [BINValue("value")] public float Value { get; set; }
        [BINValue("formatString")] public string FormatString { get; set; }

        public TftEffectAmount()
        {

        }
    }
    public class TempTable3Table : ScriptTable
    {

        public TempTable3Table()
        {

        }
    }
    public class VfxFieldNoiseDefinitionData
    {
        [BINValue("position")] public ValueVector3 Position { get; set; }
        [BINValue("radius")] public ValueFloat Radius { get; set; }
        [BINValue("frequency")] public ValueFloat Frequency { get; set; }
        [BINValue("velocityDelta")] public ValueFloat VelocityDelta { get; set; }
        [BINValue("axisFraction")] public Vector3 AxisFraction { get; set; }

        public VfxFieldNoiseDefinitionData()
        {

        }
    }
    public interface ContextualActionPlayAudio : IContextualAction
    {
        [BINValue("mSelfEventName")] string SelfEventName { get; set; }
        [BINValue("mAllyEventName")] string AllyEventName { get; set; }
        [BINValue("mEnemyEventName")] string EnemyEventName { get; set; }
        [BINValue("mSpectatorEventName")] string SpectatorEventName { get; set; }
        [BINValue("mWaitForAnnouncerQueue")] bool WaitForAnnouncerQueue { get; set; }
        [BINValue("mWaitTimeout")] float WaitTimeout { get; set; }
    }
    public interface GameModeConstant
    {
    }
    public class ConditionFloatPairData
    {
        [BINValue("mClipName")] public Hash ClipName { get; set; }
        [BINValue("mValue")] public float Value { get; set; }
        [BINValue("mHoldAnimationToHigher")] public float HoldAnimationToHigher { get; set; }
        [BINValue("mHoldAnimationToLower")] public float HoldAnimationToLower { get; set; }

        public ConditionFloatPairData()
        {

        }
    }
    public class GameModeConstantBool : GameModeConstant
    {
        [BINValue("mValue")] public bool Value { get; set; }

        public GameModeConstantBool()
        {

        }
    }
    public class ContextualConditionCharacterDistance : ICharacterSubcondition
    {
        [BINValue("mDistance")] public float Distance { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }
        [BINValue("mDistanceTarget")] public byte DistanceTarget { get; set; }

        public ContextualConditionCharacterDistance()
        {

        }
    }
    public class Class_1681734441 : MapComponent
    {
        [BINValue(3704860912)] public Link<Class_2992376383> m3704860912 { get; set; }

        public Class_1681734441()
        {

        }
    }
    public class Self : Class_2144288560
    {

        public Self()
        {

        }
    }
    public class Class_1700895677
    {
        [BINValue(2039624121)] public string m2039624121 { get; set; }
        [BINValue(2454433267)] public byte m2454433267 { get; set; }

        public Class_1700895677()
        {

        }
    }
    public interface ISpellRankUpRequirement
    {
    }
    public class EmblemData
    {
        [BINValue("mShowOnLoadingScreen")] public bool ShowOnLoadingScreen { get; set; }
        [BINValue("mLoadingScreenScale")] public float LoadingScreenScale { get; set; }
        [BINValue("mImagePath")] public string ImagePath { get; set; }

        public EmblemData()
        {

        }
    }
    public class MusicAudioDataProperties
    {
        [BINValue("themeMusicID")] public string ThemeMusicID { get; set; }
        [BINValue("themeMusicTransitionID")] public string ThemeMusicTransitionID { get; set; }
        [BINValue("legacyThemeMusicID")] public string LegacyThemeMusicID { get; set; }
        [BINValue("legacyThemeMusicTransitionID")] public string LegacyThemeMusicTransitionID { get; set; }
        [BINValue("victoryMusicID")] public string VictoryMusicID { get; set; }
        [BINValue("defeatMusicID")] public string DefeatMusicID { get; set; }
        [BINValue("victoryBannerSound")] public string VictoryBannerSound { get; set; }
        [BINValue("defeatBannerSound")] public string DefeatBannerSound { get; set; }
        [BINValue("ambientEvent")] public string AmbientEvent { get; set; }
        [BINValue("reverbPreset")] public string ReverbPreset { get; set; }

        public MusicAudioDataProperties()
        {

        }
    }
    public class SyncGroupData
    {
        [BINValue("mType")] public uint Type { get; set; }

        public SyncGroupData()
        {

        }
    }
    public class Class_1722047856 : Class_1405067729
    {
        [BINValue(2226849642)] public List<float> m2226849642 { get; set; }

        public Class_1722047856()
        {

        }
    }
    public class HealthbarImageInfo
    {
        [BINValue("mTextureName")] public string TextureName { get; set; }
        [BINValue("mOffset")] public Vector2 Offset { get; set; }
        [BINValue("mTextureUvs")] public Vector4 TextureUvs { get; set; }

        public HealthbarImageInfo()
        {

        }
    }
    public class TempTable1Table : ScriptTable
    {

        public TempTable1Table()
        {

        }
    }
    public interface MissileVisibilitySpec
    {
        [BINValue("mTargetControlsVisibility")] bool TargetControlsVisibility { get; set; }
        [BINValue("mVisibleToOwnerTeamOnly")] bool VisibleToOwnerTeamOnly { get; set; }
        [BINValue("mPerceptionBubbleRadius")] float PerceptionBubbleRadius { get; set; }
    }
    public class VfxPrimitiveBeam : VfxPrimitiveBase
    {
        [BINValue("mMesh")] public VfxMeshDefinitionData Mesh { get; set; }
        [BINValue("mBeam")] public VfxBeamDefinitionData Beam { get; set; }

        public VfxPrimitiveBeam()
        {

        }
    }
    public class VectorGet : IVectorGet
    {
        [BINValue("value")] public Vector3 Value { get; set; }

        public VectorGet()
        {

        }
    }
    public class ValueVector3
    {
        [BINValue("constantValue")] public Vector3 ConstantValue { get; set; }
        [BINValue("dynamics")] public VfxAnimatedVector3fVariableData Dynamics { get; set; }

        public ValueVector3()
        {

        }
    }
    public class SkinUpgradeData
    {
        [BINValue(3411158819)] public List<GearSkinUpgrade> m3411158819 { get; set; }

        public SkinUpgradeData()
        {

        }
    }
    public class LolSpellScript : RScript
    {
        [BINValue("globalProperties")] public ScriptGlobalProperties GlobalProperties { get; set; }
        [BINValue("sequences")] public Dictionary<Hash, ScriptSequence> Sequences { get; set; }
        [BINValue("CustomSequences")] public Dictionary<string, ScriptSequence> CustomSequences { get; set; }
        [BINValue("PreloadData")] public LoLSpellPreloadData PreloadData { get; set; }

        public LolSpellScript()
        {

        }
    }
    public class ValueVector2
    {
        [BINValue("constantValue")] public Vector2 ConstantValue { get; set; }
        [BINValue("dynamics")] public VfxAnimatedVector2fVariableData Dynamics { get; set; }

        public ValueVector2()
        {

        }
    }
    public class Class_1780014848
    {
        [BINValue("tier")] public string Tier { get; set; }
        [BINValue("regaliaCrest")] public Link<RegaliaData> RegaliaCrest { get; set; }
        [BINValue("regaliaCrown1")] public Link<RegaliaData> RegaliaCrown1 { get; set; }
        [BINValue("regaliaCrown2")] public Link<RegaliaData> RegaliaCrown2 { get; set; }
        [BINValue("regaliaCrown3")] public Link<RegaliaData> RegaliaCrown3 { get; set; }
        [BINValue("regaliaCrown4")] public Link<RegaliaData> RegaliaCrown4 { get; set; }
        [BINValue(34629342)] public Link<RegaliaData> m34629342 { get; set; }
        [BINValue("regaliaSplit1")] public Link<RegaliaData> RegaliaSplit1 { get; set; }
        [BINValue("regaliaSplit2")] public Link<RegaliaData> RegaliaSplit2 { get; set; }
        [BINValue("regaliaSplit3")] public Link<RegaliaData> RegaliaSplit3 { get; set; }

        public Class_1780014848()
        {

        }
    }
    public class MapBakeProperties : MapComponent
    {
        [BINValue("lightGridSize")] public uint LightGridSize { get; set; }
        [BINValue("lightGridCharacterFullBrightIntensity")] public float LightGridCharacterFullBrightIntensity { get; set; }
        [BINValue(3931004104)] public float m3931004104 { get; set; }
        [BINValue(792417393)] public float m792417393 { get; set; }
        [BINValue("lightGridFileName")] public string LightGridFileName { get; set; }

        public MapBakeProperties()
        {

        }
    }
    public class VfxMeshDefinitionData
    {
        [BINValue("mSimpleMeshName")] public string SimpleMeshName { get; set; }
        [BINValue("mMeshName")] public string MeshName { get; set; }
        [BINValue("mMeshSkeletonName")] public string MeshSkeletonName { get; set; }
        [BINValue("mAnimationName")] public string AnimationName { get; set; }
        [BINValue("mAnimationVariants")] public List<string> AnimationVariants { get; set; }
        [BINValue("mSubmeshesToDraw")] public List<Hash> SubmeshesToDraw { get; set; }
        [BINValue("mSubmeshesToDrawAlways")] public List<Hash> SubmeshesToDrawAlways { get; set; }
        [BINValue("mLockMeshToAttachment")] public bool LockMeshToAttachment { get; set; }

        public VfxMeshDefinitionData()
        {

        }
    }
    public class HasBuffRequirement : ISpellRankUpRequirement
    {
        [BINValue("mBuffName")] public Hash BuffName { get; set; }
        [BINValue("mFromAnyone")] public bool FromAnyone { get; set; }

        public HasBuffRequirement()
        {

        }
    }
    public class AndScriptCondition : IScriptCondition
    {
        [BINValue("Conditions")] public List<IScriptCondition> Conditions { get; set; }

        public AndScriptCondition()
        {

        }
    }
    public interface MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] bool TracksTarget { get; set; }
        [BINValue(2856647070)] bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] string StartBoneName { get; set; }
        [BINValue(2798329764)] Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] string TargetBoneName { get; set; }
        [BINValue(2799230803)] float m2799230803 { get; set; }
    }
    public class MinimapPingEffectDefinition
    {
        [BINValue("alphaStart")] public uint AlphaStart { get; set; }
        [BINValue("alphaFadeSpeed")] public float AlphaFadeSpeed { get; set; }
        [BINValue("scaleStart")] public float ScaleStart { get; set; }
        [BINValue("scaleSpeed")] public float ScaleSpeed { get; set; }
        [BINValue("startDelay")] public float StartDelay { get; set; }
        [BINValue("life")] public float Life { get; set; }
        [BINValue("onDeathFadeSpeed")] public float OnDeathFadeSpeed { get; set; }
        [BINValue("repeatCount")] public uint RepeatCount { get; set; }
        [BINValue("blendWithAlpha")] public bool BlendWithAlpha { get; set; }

        public MinimapPingEffectDefinition()
        {

        }
    }
    public class IntegratedValueVector2 : ValueVector2
    {

        public IntegratedValueVector2()
        {

        }
    }
    public class SHData
    {
        [BINValue("bandData")] public List<Vector3> BandData { get; set; }

        public SHData()
        {

        }
    }
    public class IntegratedValueVector3 : ValueVector3
    {

        public IntegratedValueVector3()
        {

        }
    }
    public class SelectorPairData
    {
        [BINValue("mClipName")] public Hash ClipName { get; set; }
        [BINValue("mProbability")] public float Probability { get; set; }

        public SelectorPairData()
        {

        }
    }
    public class Class_1850343160
    {
        [BINValue(2215596130)] public float m2215596130 { get; set; }
        [BINValue(625770807)] public float m625770807 { get; set; }

        public Class_1850343160()
        {

        }
    }
    public class Class_1852984937
    {
        [BINValue("templateDefinition")] public List<Class_471801710> TemplateDefinition { get; set; }

        public Class_1852984937()
        {

        }
    }
    public class Class_1859523703 : BaseElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }

        public Class_1859523703()
        {

        }
    }
    public class Class_1863542244 : MissileBehaviorSpec
    {
        [BINValue(3426884646)] public float m3426884646 { get; set; }

        public Class_1863542244()
        {

        }
    }
    public class ContextualConditionSpellLevel : IContextualConditionSpell
    {
        [BINValue("mSpellLevel")] public byte SpellLevel { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionSpellLevel()
        {

        }
    }
    public class TftTraitData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue(3272883558)] public string m3272883558 { get; set; }
        [BINValue(1985943770)] public string m1985943770 { get; set; }
        [BINValue("mDisplayNameIcon")] public string DisplayNameIcon { get; set; }
        [BINValue("mIconPath")] public string IconPath { get; set; }
        [BINValue("mTraitSets")] public List<Class_3241198053> TraitSets { get; set; }

        public TftTraitData()
        {

        }
    }
    public class SwapChampionCheat : Cheat
    {

        public SwapChampionCheat()
        {

        }
    }
    public class Class_1887734700
    {
        [BINValue(1051835630)] public float m1051835630 { get; set; }
        [BINValue(2790426312)] public float m2790426312 { get; set; }
        [BINValue(618453125)] public float m618453125 { get; set; }
        [BINValue(746861530)] public float m746861530 { get; set; }
        [BINValue(2864308970)] public HudMenuTransitionData m2864308970 { get; set; }
        [BINValue(1165810701)] public HudMenuTransitionData m1165810701 { get; set; }
        [BINValue(2808554102)] public HudMenuTransitionData m2808554102 { get; set; }

        public Class_1887734700()
        {

        }
    }
    public class TableValueExistsScriptCondition : IScriptCondition
    {
        [BINValue("TableValue")] public ScriptTableGet TableValue { get; set; }

        public TableValueExistsScriptCondition()
        {

        }
    }
    public class FloatLiteralMaterialDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mValue")] public float Value { get; set; }

        public FloatLiteralMaterialDriver()
        {

        }
    }
    public class ContextualConditionCustomTimer : IContextualCondition
    {
        [BINValue("mCustomTimer")] public float CustomTimer { get; set; }

        public ContextualConditionCustomTimer()
        {

        }
    }
    public class AtlasData
    {
        [BINValue("mTextureName")] public string TextureName { get; set; }
        [BINValue("mTextureUV")] public Vector4 TextureUV { get; set; }
        [BINValue("mTextureSourceResolutionWidth")] public uint TextureSourceResolutionWidth { get; set; }
        [BINValue("mTextureSourceResolutionHeight")] public uint TextureSourceResolutionHeight { get; set; }

        public AtlasData()
        {

        }
    }
    public class GlobalPerLevelStatsFactor
    {
        [BINValue("mPerLevelStatsFactor")] public List<float> PerLevelStatsFactor { get; set; }

        public GlobalPerLevelStatsFactor()
        {

        }
    }
    public class EffectAnimationElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }
        [BINValue("FramesPerSecond")] public float FramesPerSecond { get; set; }
        [BINValue("TotalNumberOfFrames")] public float TotalNumberOfFrames { get; set; }
        [BINValue("NumberOfFramesPerRowInAtlas")] public float NumberOfFramesPerRowInAtlas { get; set; }
        [BINValue("mLooping")] public bool Looping { get; set; }

        public EffectAnimationElementData()
        {

        }
    }
    public class HasGearDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mGearIndex")] public byte GearIndex { get; set; }

        public HasGearDynamicMaterialBoolDriver()
        {

        }
    }
    public class BaseResourceResolver : IResourceResolver
    {
        [BINValue("resourceMap")] public Dictionary<Hash, Link<IResource>> ResourceMap { get; set; }

        public BaseResourceResolver()
        {

        }
    }
    public class ContextualConditionShopOpenCount : IContextualCondition
    {
        [BINValue("mShopOpenCount")] public uint ShopOpenCount { get; set; }

        public ContextualConditionShopOpenCount()
        {

        }
    }
    public class StaticMaterialChildTechniqueDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("parentName")] public string ParentName { get; set; }
        [BINValue("shaderMacros")] public Dictionary<string, string> ShaderMacros { get; set; }

        public StaticMaterialChildTechniqueDef()
        {

        }
    }
    public interface Class_1936278667
    {
        [BINValue("mSceneName")] string SceneName { get; set; }
    }
    public class SummonerEmote
    {
        [BINValue("summonerEmoteId")] public uint SummonerEmoteId { get; set; }
        [BINValue("vfxSystem")] public Link<VfxSystemDefinitionData> VfxSystem { get; set; }
        [BINValue("announcementIcon")] public string AnnouncementIcon { get; set; }
        [BINValue("selectionIcon")] public string SelectionIcon { get; set; }
        [BINValue("renderScale")] public float RenderScale { get; set; }
        [BINValue("verticalOffset")] public float VerticalOffset { get; set; }
        [BINValue("mReadyForPlaytest")] public bool ReadyForPlaytest { get; set; }
        [BINValue("visibleSelectionName")] public string VisibleSelectionName { get; set; }

        public SummonerEmote()
        {

        }
    }
    public class ContextualConditionEnemyDeathsNearby : IContextualCondition
    {
        [BINValue("mEnemyDeaths")] public uint EnemyDeaths { get; set; }

        public ContextualConditionEnemyDeathsNearby()
        {

        }
    }
    public class AbilityResourceByCoefficientCalculationPart : Class_3053458126
    {
        [BINValue("mCoefficient")] public float Coefficient { get; set; }
        [BINValue(1306624758)] public byte m1306624758 { get; set; }
        [BINValue(2100383980)] public byte m2100383980 { get; set; }

        public AbilityResourceByCoefficientCalculationPart()
        {

        }
    }
    public class SpellModifier
    {
        [BINValue("mModifierID")] public Hash ModifierID { get; set; }
        [BINValue(2848730102)] public byte m2848730102 { get; set; }
        [BINValue(2759808727)] public byte m2759808727 { get; set; }
        [BINValue(1527878389)] public uint m1527878389 { get; set; }
        [BINValue(1142566944)] public List<Class_3393100796> m1142566944 { get; set; }

        public SpellModifier()
        {

        }
    }
    public class Class_1986849908 : Class_2144288560
    {

        public Class_1986849908()
        {

        }
    }
    public class Class_1987560042 : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mUnitsRequirements")] public List<ICastRequirement> UnitsRequirements { get; set; }
        [BINValue("mUnitsRequired")] public uint UnitsRequired { get; set; }
        [BINValue("mRange")] public float Range { get; set; }
        [BINValue("mDistanceType")] public uint DistanceType { get; set; }

        public Class_1987560042()
        {

        }
    }
    public interface Class_1989226833 : Class_3053458126
    {
        [BINValue("mBuffName")] Hash BuffName { get; set; }
        [BINValue(9297440)] string m9297440 { get; set; }
        [BINValue(3047920162)] string m3047920162 { get; set; }
    }
    public class Class_1991855177 : BaseEventData
    {
        [BINValue(3117400491)] public float m3117400491 { get; set; }
        [BINValue(2577320358)] public float m2577320358 { get; set; }
        [BINValue(2367322749)] public float m2367322749 { get; set; }

        public Class_1991855177()
        {

        }
    }
    public class ContextualConditionCharacterRole : ICharacterSubcondition
    {
        [BINValue("mRole")] public byte Role { get; set; }

        public ContextualConditionCharacterRole()
        {

        }
    }
    public class AbilityResourceStateData
    {
        [BINValue("DefaultPalette")] public AbilityResourceStateColorOptions DefaultPalette { get; set; }
        [BINValue("ColorblindPalette")] public AbilityResourceStateColorOptions ColorblindPalette { get; set; }
        [BINValue("textureSuffix")] public string TextureSuffix { get; set; }
        [BINValue("animationSuffix")] public string AnimationSuffix { get; set; }

        public AbilityResourceStateData()
        {

        }
    }
    public class FixedSpeedSplineMovement : GenericSplineMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mSplineInfo")] public ISplineInfo SplineInfo { get; set; }
        [BINValue("mUseMissilePositionAsOrigin")] public bool UseMissilePositionAsOrigin { get; set; }
        [BINValue("mSpeed")] public float Speed { get; set; }

        public FixedSpeedSplineMovement()
        {

        }
    }
    public class CCScoreMultipliers
    {
        [BINValue("stun")] public float Stun { get; set; }
        [BINValue("taunt")] public float Taunt { get; set; }
        [BINValue("fear")] public float Fear { get; set; }
        [BINValue("flee")] public float Flee { get; set; }
        [BINValue("suppression")] public float Suppression { get; set; }
        [BINValue("knockup")] public float Knockup { get; set; }
        [BINValue("knockback")] public float Knockback { get; set; }
        [BINValue("polymorph")] public float Polymorph { get; set; }
        [BINValue("root")] public float Root { get; set; }
        [BINValue("silence")] public float Silence { get; set; }
        [BINValue("charm")] public float Charm { get; set; }
        [BINValue("slow")] public float Slow { get; set; }
        [BINValue("attackSpeedSlow")] public float AttackSpeedSlow { get; set; }
        [BINValue("blind")] public float Blind { get; set; }
        [BINValue("disarm")] public float Disarm { get; set; }
        [BINValue("grounded")] public float Grounded { get; set; }
        [BINValue("nearsight")] public float Nearsight { get; set; }
        [BINValue("drowsy")] public float Drowsy { get; set; }
        [BINValue("asleep")] public float Asleep { get; set; }

        public CCScoreMultipliers()
        {

        }
    }
    public class Class_2009563166 : BaseEventData
    {
        [BINValue(3454275985)] public bool m3454275985 { get; set; }

        public Class_2009563166()
        {

        }
    }
    public class VfxShape
    {
        [BINValue("birthTranslation")] public ValueVector3 BirthTranslation { get; set; }
        [BINValue("emitOffset")] public ValueVector3 EmitOffset { get; set; }
        [BINValue("emitRotationAngles")] public List<ValueFloat> EmitRotationAngles { get; set; }
        [BINValue("emitRotationAxes")] public List<Vector3> EmitRotationAxes { get; set; }

        public VfxShape()
        {

        }
    }
    public class ToggleBarracksCheat : Cheat
    {
        [BINValue("mKillExistingMinions")] public bool KillExistingMinions { get; set; }
        [BINValue("mKillWards")] public bool KillWards { get; set; }

        public ToggleBarracksCheat()
        {

        }
    }
    public class NextSpellVarsTable : ScriptTable
    {

        public NextSpellVarsTable()
        {

        }
    }
    public class BannerFlagData
    {
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }

        public BannerFlagData()
        {

        }
    }
    public class HudCheatMenuData
    {
        [BINValue("tooltipDelay")] public float TooltipDelay { get; set; }
        [BINValue("groupDividerGapSize")] public float GroupDividerGapSize { get; set; }
        [BINValue("groupDividerIndex")] public byte GroupDividerIndex { get; set; }

        public HudCheatMenuData()
        {

        }
    }
    public class BaseEventData
    {
        [BINValue("mName")] public Hash Name { get; set; }
        [BINValue("mStartFrame")] public float StartFrame { get; set; }
        [BINValue("mEndFrame")] public float EndFrame { get; set; }
        [BINValue("mIsSelfOnly")] public bool IsSelfOnly { get; set; }
        [BINValue("mFireIfAnimationEndsEarly")] public bool FireIfAnimationEndsEarly { get; set; }

        public BaseEventData()
        {

        }
    }
    public class NullMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mWaitForChildren")] public bool WaitForChildren { get; set; }
        [BINValue(3426884646)] public float m3426884646 { get; set; }

        public NullMovement()
        {

        }
    }
    public class HudTunables
    {
        [BINValue("mScaleSettings")] public HudScaleSettingsData ScaleSettings { get; set; }
        [BINValue("mLevelUpTransitionData")] public HudLevelUpData LevelUpTransitionData { get; set; }
        [BINValue("mGameScoreboardTransitionData")] public HudMenuTransitionData GameScoreboardTransitionData { get; set; }
        [BINValue("mReplayScoreboardTransitionData")] public HudMenuTransitionData ReplayScoreboardTransitionData { get; set; }
        [BINValue("mReplayGameStatsTransitionData")] public HudMenuTransitionData ReplayGameStatsTransitionData { get; set; }
        [BINValue("mReplayTeamFramesTransitionData")] public HudMenuTransitionData ReplayTeamFramesTransitionData { get; set; }
        [BINValue(2632753136)] public HudBannerData m2632753136 { get; set; }
        [BINValue(1316827209)] public HudAbilityPromptData m1316827209 { get; set; }
        [BINValue("mElementalSelectionAnimationData")] public HudElementalSectionUIData ElementalSelectionAnimationData { get; set; }
        [BINValue("mEmotePopupData")] public HudEmotePopupData EmotePopupData { get; set; }
        [BINValue("mGearSelectionData")] public HudGearSelectionUIData GearSelectionData { get; set; }
        [BINValue("mRadailWheelData")] public HudRadialWheelData RadailWheelData { get; set; }
        [BINValue("mReplayData")] public HudReplayData ReplayData { get; set; }
        [BINValue("mCheatMenuData")] public HudCheatMenuData CheatMenuData { get; set; }
        [BINValue("mPingData")] public HudPingData PingData { get; set; }
        [BINValue("mChatData")] public HudChatData ChatData { get; set; }
        [BINValue("mVoiceChatData")] public HudVoiceChatData VoiceChatData { get; set; }
        [BINValue("mInputBoxData")] public HudInputBoxData InputBoxData { get; set; }
        [BINValue("mHealthBarData")] public HudHealthBarData HealthBarData { get; set; }
        [BINValue("mHudSpellSlotResetFeedbackData")] public HudSpellSlotResetFeedbackData HudSpellSlotResetFeedbackData { get; set; }
        [BINValue(217938168)] public Class_4205759190 m217938168 { get; set; }
        [BINValue(3128315546)] public Class_1887734700 m3128315546 { get; set; }
        [BINValue(106443622)] public Class_4122721905 m106443622 { get; set; }
        [BINValue(3003275083)] public Class_593971085 m3003275083 { get; set; }
        [BINValue(3266966018)] public Class_3009378484 m3266966018 { get; set; }
        [BINValue(2252352223)] public Class_3854974626 m2252352223 { get; set; }
        [BINValue(1116989102)] public Class_1645499771 m1116989102 { get; set; }
        [BINValue(3882694614)] public Class_3305259773 m3882694614 { get; set; }

        public HudTunables()
        {

        }
    }
    public class ContextualConditionSpell : IContextualCondition
    {
        [BINValue("mSpellSlot")] public byte SpellSlot { get; set; }
        [BINValue("mChildConditions")] public List<IContextualConditionSpell> ChildConditions { get; set; }

        public ContextualConditionSpell()
        {

        }
    }
    public class MinimapPingData
    {
        [BINValue("mOMWPingRangeCutoffs")] public Dictionary<byte, float> OMWPingRangeCutoffs { get; set; }
        [BINValue("mPings")] public List<MinimapPingTypeContainer> Pings { get; set; }

        public MinimapPingData()
        {

        }
    }
    public class BuffCounterByNamedDataValueCalculationPart : Class_1989226833
    {
        [BINValue("mBuffName")] public Hash BuffName { get; set; }
        [BINValue(9297440)] public string m9297440 { get; set; }
        [BINValue(3047920162)] public string m3047920162 { get; set; }
        [BINValue("mDataValue")] public Hash DataValue { get; set; }

        public BuffCounterByNamedDataValueCalculationPart()
        {

        }
    }
    public class Class_2068371646
    {
        [BINValue("mSceneTransitionIn")] public HudMenuTransitionData SceneTransitionIn { get; set; }
        [BINValue("mSceneTransitionOut")] public HudMenuTransitionData SceneTransitionOut { get; set; }

        public Class_2068371646()
        {

        }
    }
    public class SkinEmblem
    {
        [BINValue("mEmblemData")] public Link<EmblemData> EmblemData { get; set; }
        [BINValue("mLoadingScreenAnchor")] public uint LoadingScreenAnchor { get; set; }

        public SkinEmblem()
        {

        }
    }
    public class TeamBuffData
    {
        [BINValue("mBuffName")] public string BuffName { get; set; }
        [BINValue(3736966593)] public string m3736966593 { get; set; }
        [BINValue(2589193282)] public bool m2589193282 { get; set; }

        public TeamBuffData()
        {

        }
    }
    public class CompanionData : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("level")] public uint Level { get; set; }
        [BINValue(1460531328)] public bool m1460531328 { get; set; }
        [BINValue("mCharacter")] public Hash Character { get; set; }
        [BINValue("mSkinId")] public uint SkinId { get; set; }
        [BINValue("mLoadScreen")] public string LoadScreen { get; set; }

        public CompanionData()
        {

        }
    }
    public class ContextualConditionObjectiveTakeByMyTeam : IContextualCondition
    {
        [BINValue("mTakenObjective")] public uint TakenObjective { get; set; }

        public ContextualConditionObjectiveTakeByMyTeam()
        {

        }
    }
    public class Class_2099815050
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue(103528693)] public float m103528693 { get; set; }
        [BINValue(3973906906)] public string m3973906906 { get; set; }
        [BINValue(4079192626)] public string m4079192626 { get; set; }
        [BINValue("mIconPath")] public string IconPath { get; set; }
        [BINValue(511705008)] public string m511705008 { get; set; }
        [BINValue(3730563465)] public string m3730563465 { get; set; }
        [BINValue(2793884270)] public string m2793884270 { get; set; }

        public Class_2099815050()
        {

        }
    }
    public class Class_2104163269 : Class_2144288560
    {

        public Class_2104163269()
        {

        }
    }
    public class ItemModifier
    {
        [BINValue("mItemModifierID")] public Hash ItemModifierID { get; set; }
        [BINValue("mModifiedItem")] public Link<ItemData> ModifiedItem { get; set; }
        [BINValue("mModifiedGroup")] public Link<ItemGroup> ModifiedGroup { get; set; }
        [BINValue("mModifiedIfBuildsFromItem")] public Link<ItemData> ModifiedIfBuildsFromItem { get; set; }
        [BINValue("mMinimumModifierInstancesToBeActive")] public int MinimumModifierInstancesToBeActive { get; set; }
        [BINValue("mMaximumModifierInstancesToBeActive")] public int MaximumModifierInstancesToBeActive { get; set; }
        [BINValue("mMaximumDeltasToStack")] public int MaximumDeltasToStack { get; set; }
        [BINValue("mShowAsModifiedInUI")] public bool ShowAsModifiedInUI { get; set; }
        [BINValue("mModifierIsInheritedByOwnedParentItems")] public bool ModifierIsInheritedByOwnedParentItems { get; set; }
        [BINValue("mAddedBuildFrom")] public List<ItemData> AddedBuildFrom { get; set; }
        [BINValue("mRemovedBuildFrom")] public List<ItemData> RemovedBuildFrom { get; set; }
        [BINValue("mReplaceInsteadOfAddingBuildFrom")] public bool ReplaceInsteadOfAddingBuildFrom { get; set; }
        [BINValue("mIgnoreMaxGroupOwnable")] public bool IgnoreMaxGroupOwnable { get; set; }
        [BINValue("mIgnoreSpecificMaxGroupOwnable")] public Hash IgnoreSpecificMaxGroupOwnable { get; set; }
        [BINValue("mDeltaGoldCost")] public float DeltaGoldCost { get; set; }
        [BINValue("mDeltaGoldCostPercent")] public float DeltaGoldCostPercent { get; set; }
        [BINValue("mDeltaBuffCurrencyCostPercent")] public float DeltaBuffCurrencyCostPercent { get; set; }
        [BINValue("mDeltaRequiredLevel")] public int DeltaRequiredLevel { get; set; }
        [BINValue("mDeltaBuffCurrencyCost")] public int DeltaBuffCurrencyCost { get; set; }
        [BINValue("mDeltaMaxStacks")] public int DeltaMaxStacks { get; set; }
        [BINValue("mVisualPriority")] public int VisualPriority { get; set; }
        [BINValue("inventoryIconToOverlay")] public string InventoryIconToOverlay { get; set; }
        [BINValue("mDescriptionToAppend")] public string DescriptionToAppend { get; set; }
        [BINValue("mDescriptionToPrepend")] public string DescriptionToPrepend { get; set; }
        [BINValue("mDescriptionToReplace")] public string DescriptionToReplace { get; set; }
        [BINValue("mDynamicTooltipToAppend")] public string DynamicTooltipToAppend { get; set; }
        [BINValue("mDynamicTooltipToPrepend")] public string DynamicTooltipToPrepend { get; set; }
        [BINValue(1565504299)] public string m1565504299 { get; set; }
        [BINValue("mDisplayNameToAppend")] public string DisplayNameToAppend { get; set; }
        [BINValue("mDisplayNameToPrepend")] public string DisplayNameToPrepend { get; set; }
        [BINValue("mDisplayNameToReplace")] public string DisplayNameToReplace { get; set; }
        [BINValue("mClickableToEnable")] public bool ClickableToEnable { get; set; }
        [BINValue("mMajorActiveItemToEnable")] public bool MajorActiveItemToEnable { get; set; }
        [BINValue("mSpellNameToReplace")] public string SpellNameToReplace { get; set; }

        public ItemModifier()
        {

        }
    }
    public class SpellDataResourceClient
    {
        [BINValue(928405213)] public Hash m928405213 { get; set; }
        [BINValue(2102005358)] public Hash m2102005358 { get; set; }
        [BINValue("mTooltipData")] public TooltipInstanceSpell TooltipData { get; set; }
        [BINValue("mSpawningUIDefinition")] public SpawningUIDefinition SpawningUIDefinition { get; set; }
        [BINValue("mTargeterDefinitions")] public List<TargeterDefinition> TargeterDefinitions { get; set; }
        [BINValue("mCustomTargeterDefinitions")] public Dictionary<Hash, CustomTargeterDefinitions> CustomTargeterDefinitions { get; set; }
        [BINValue("mMissileTargeterDefinitions")] public List<MissileAttachedTargetingDefinition> MissileTargeterDefinitions { get; set; }
        [BINValue("mLeftClickSpellAction")] public uint LeftClickSpellAction { get; set; }
        [BINValue("mRightClickSpellAction")] public uint RightClickSpellAction { get; set; }

        public SpellDataResourceClient()
        {

        }
    }
    public class Class_2115654752
    {
        [BINValue(1751568959)] public Dictionary<string, Class_1700895677> m1751568959 { get; set; }

        public Class_2115654752()
        {

        }
    }
    public class ContextualConditionHasItemFromVOGroup : IContextualCondition
    {
        [BINValue("mItemVOGroupHash")] public Hash ItemVOGroupHash { get; set; }

        public ContextualConditionHasItemFromVOGroup()
        {

        }
    }
    public class HudLevelUpData
    {
        [BINValue("minAlpha")] public byte MinAlpha { get; set; }
        [BINValue("maxAlpha")] public byte MaxAlpha { get; set; }
        [BINValue("maxOffset")] public float MaxOffset { get; set; }
        [BINValue("animTime")] public float AnimTime { get; set; }
        [BINValue("delay")] public float Delay { get; set; }
        [BINValue("overshoot")] public float Overshoot { get; set; }
        [BINValue("inertia")] public float Inertia { get; set; }
        [BINValue("playerBuffsOffset")] public float PlayerBuffsOffset { get; set; }
        [BINValue("idleSheenInterval")] public float IdleSheenInterval { get; set; }

        public HudLevelUpData()
        {

        }
    }
    public class MinimapPingEffectAndTextureData
    {
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mEffect")] public MinimapPingEffectDefinition Effect { get; set; }
        [BINValue("mDefault")] public TextureAndColorData Default { get; set; }
        [BINValue("mOrder")] public TextureAndColorData Order { get; set; }
        [BINValue("mChaos")] public TextureAndColorData Chaos { get; set; }

        public MinimapPingEffectAndTextureData()
        {

        }
    }
    public class SyncedAnimationEventData : BaseEventData
    {
        [BINValue("mLerpTime")] public float LerpTime { get; set; }

        public SyncedAnimationEventData()
        {

        }
    }
    public class AnimationFractionDynamicMaterialFloatDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mAnimationName")] public Hash AnimationName { get; set; }

        public AnimationFractionDynamicMaterialFloatDriver()
        {

        }
    }
    public interface Class_2144288560
    {
    }
    public class ContextualConditionTurretPosition : IContextualCondition
    {
        [BINValue("mTurretPosition")] public byte TurretPosition { get; set; }

        public ContextualConditionTurretPosition()
        {

        }
    }
    public class FloatingTextGlobalConfig
    {
        [BINValue("mTunables")] public FloatingTextTunables Tunables { get; set; }
        [BINValue("mDamageDisplayTypes")] public FloatingTextDamageDisplayTypeList DamageDisplayTypes { get; set; }
        [BINValue("mFloatingTextTypes")] public FloatingTextTypeList FloatingTextTypes { get; set; }

        public FloatingTextGlobalConfig()
        {

        }
    }
    public class EffectAnimatedRotatingIconElementData : EffectAnimationElementData
    {

        public EffectAnimatedRotatingIconElementData()
        {

        }
    }
    public class ShaderPhysicalParameter
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("data")] public Vector4 Data { get; set; }
        [BINValue("logicalParameters")] public List<ShaderLogicalParameter> LogicalParameters { get; set; }

        public ShaderPhysicalParameter()
        {

        }
    }
    public class EffectCooldownRadialElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mIsFill")] public bool IsFill { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }

        public EffectCooldownRadialElementData()
        {

        }
    }
    public class ConformToPathEventData : BaseEventData
    {
        [BINValue("mMaskDataName")] public Hash MaskDataName { get; set; }
        [BINValue("mBlendInTime")] public float BlendInTime { get; set; }
        [BINValue("mBlendOutTime")] public float BlendOutTime { get; set; }

        public ConformToPathEventData()
        {

        }
    }
    public class VfxMigrationResources
    {
        [BINValue("resourceMap")] public Dictionary<Hash, Link<VfxSystemDefinitionData>> ResourceMap { get; set; }

        public VfxMigrationResources()
        {

        }
    }
    public class Class_2188140632
    {
        [BINValue(4147583912)] public List<Class_4266457040> m4147583912 { get; set; }

        public Class_2188140632()
        {

        }
    }
    public class ContextualConditionCharacterPlayingAnimation : ICharacterSubcondition
    {
        [BINValue("mAnimationNameHash")] public Hash AnimationNameHash { get; set; }

        public ContextualConditionCharacterPlayingAnimation()
        {

        }
    }
    public class ToggleBuffCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mBuffName")] public string BuffName { get; set; }

        public ToggleBuffCheat()
        {

        }
    }
    public class Class_2225484659 : Class_3053458126
    {
        [BINValue("mSubparts")] public List<Class_3053458126> Subparts { get; set; }

        public Class_2225484659()
        {

        }
    }
    public class ItemDataClient
    {
        [BINValue("mTooltipData")] public Class_905298284 TooltipData { get; set; }
        [BINValue("mDescription")] public string Description { get; set; }
        [BINValue("mDynamicTooltip")] public string DynamicTooltip { get; set; }
        [BINValue("inventoryIcon")] public string InventoryIcon { get; set; }
        [BINValue("epicness")] public uint Epicness { get; set; }
        [BINValue("effectRadius")] public float EffectRadius { get; set; }
        [BINValue("mFloatVarsDecimals")] public List<int> FloatVarsDecimals { get; set; }

        public ItemDataClient()
        {

        }
    }
    public class StaticMaterialPassDef
    {
        [BINValue("shader")] public Link<IShaderDef> Shader { get; set; }
        [BINValue("shaderMacros")] public Dictionary<string, string> ShaderMacros { get; set; }
        [BINValue("paramValues")] public List<StaticMaterialShaderParamDef> ParamValues { get; set; }
        [BINValue("depthEnable")] public bool DepthEnable { get; set; }
        [BINValue("stencilEnable")] public bool StencilEnable { get; set; }
        [BINValue("blendEnable")] public bool BlendEnable { get; set; }
        [BINValue("cullEnable")] public bool CullEnable { get; set; }
        [BINValue("depthCompareFunc")] public uint DepthCompareFunc { get; set; }
        [BINValue("stencilCompareFunc")] public uint StencilCompareFunc { get; set; }
        [BINValue("stencilReferenceVal")] public uint StencilReferenceVal { get; set; }
        [BINValue("stencilMask")] public uint StencilMask { get; set; }
        [BINValue("stencilFailOp")] public uint StencilFailOp { get; set; }
        [BINValue("stencilPassDepthFailOp")] public uint StencilPassDepthFailOp { get; set; }
        [BINValue("stencilPassDepthPassOp")] public uint StencilPassDepthPassOp { get; set; }
        [BINValue("srcColorBlendFactor")] public uint SrcColorBlendFactor { get; set; }
        [BINValue("srcAlphaBlendFactor")] public uint SrcAlphaBlendFactor { get; set; }
        [BINValue("dstColorBlendFactor")] public uint DstColorBlendFactor { get; set; }
        [BINValue("dstAlphaBlendFactor")] public uint DstAlphaBlendFactor { get; set; }
        [BINValue("blendEquation")] public uint BlendEquation { get; set; }
        [BINValue("windingToCull")] public uint WindingToCull { get; set; }
        [BINValue("writeMask")] public uint WriteMask { get; set; }
        [BINValue("depthOffsetSlope")] public float DepthOffsetSlope { get; set; }
        [BINValue("depthOffsetBias")] public float DepthOffsetBias { get; set; }

        public StaticMaterialPassDef()
        {

        }
    }
    public class ForceSpawnNeutralCampsCheat : Cheat
    {
        [BINValue("mSpawnBaron")] public bool SpawnBaron { get; set; }

        public ForceSpawnNeutralCampsCheat()
        {

        }
    }
    public class VfxPrimitiveMesh : VfxPrimitiveMeshBase
    {
        [BINValue("mMesh")] public VfxMeshDefinitionData Mesh { get; set; }

        public VfxPrimitiveMesh()
        {

        }
    }
    public class Class_2243645043 : Class_3460011047
    {

        public Class_2243645043()
        {

        }
    }
    public class TooltipInstance
    {
        [BINValue("mObjectName")] public string ObjectName { get; set; }
        [BINValue("mFormat")] public Link<TooltipFormat> Format { get; set; }
        [BINValue("mLocKeys")] public Dictionary<string, string> LocKeys { get; set; }
        [BINValue("mLists")] public Dictionary<string, TooltipInstanceList> Lists { get; set; }

        public TooltipInstance()
        {

        }
    }
    public class AudioStatusEvents
    {
        [BINValue("rtpcName")] public string RtpcName { get; set; }
        [BINValue("startEvent")] public string StartEvent { get; set; }
        [BINValue("stopEvent")] public string StopEvent { get; set; }

        public AudioStatusEvents()
        {

        }
    }
    public class GlobalAudioDataProperties
    {
        [BINValue("systems")] public Dictionary<Hash, Link<AudioSystemDataProperties>> Systems { get; set; }
        [BINValue("cooldownVoiceOver")] public float CooldownVoiceOver { get; set; }
        [BINValue("localPlayerStatusEvents")] public Dictionary<byte, AudioStatusEvents> LocalPlayerStatusEvents { get; set; }

        public GlobalAudioDataProperties()
        {

        }
    }
    public class Class_2263200418 : Class_1405067729
    {

        public Class_2263200418()
        {

        }
    }
    public class SetKeyValueInCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("Key")] public IScriptValueGet Key { get; set; }
        [BINValue("value")] public IScriptValueGet Value { get; set; }

        public SetKeyValueInCustomTableBlock()
        {

        }
    }
    public class TargeterDefinitionCone : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("startLocator")] public DrawablePositionLocator StartLocator { get; set; }
        [BINValue("endLocator")] public DrawablePositionLocator EndLocator { get; set; }
        [BINValue("fallbackDirection")] public uint FallbackDirection { get; set; }
        [BINValue("hasMaxGrowRange")] public bool HasMaxGrowRange { get; set; }
        [BINValue("coneFollowsEnd")] public bool ConeFollowsEnd { get; set; }
        [BINValue("coneAngleDegrees")] public Optional<float> ConeAngleDegrees { get; set; }
        [BINValue("coneRange")] public Optional<float> ConeRange { get; set; }
        [BINValue("rangeGrowthStartTime")] public FloatPerSpellLevel RangeGrowthStartTime { get; set; }
        [BINValue("rangeGrowthDuration")] public FloatPerSpellLevel RangeGrowthDuration { get; set; }
        [BINValue("rangeGrowthMax")] public FloatPerSpellLevel RangeGrowthMax { get; set; }
        [BINValue("textureConeOverrideName")] public string TextureConeOverrideName { get; set; }
        [BINValue("textureConeMaxGrowName")] public string TextureConeMaxGrowName { get; set; }

        public TargeterDefinitionCone()
        {

        }
    }
    public class RegaliaData : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("texture")] public string Texture { get; set; }

        public RegaliaData()
        {

        }
    }
    public class GameModeConstantVector3f : GameModeConstant
    {
        [BINValue("mValue")] public Vector3 Value { get; set; }

        public GameModeConstantVector3f()
        {

        }
    }
    public class GDSMapObjectAnimationInfo : GDSMapObjectExtraInfo
    {
        [BINValue("defaultAnimation")] public string DefaultAnimation { get; set; }
        [BINValue("looping")] public bool Looping { get; set; }
        [BINValue("destroyOnCompletion")] public bool DestroyOnCompletion { get; set; }
        [BINValue("duration")] public float Duration { get; set; }

        public GDSMapObjectAnimationInfo()
        {

        }
    }
    public class PerkReplacementList
    {
        [BINValue("mReplacements")] public List<PerkReplacement> Replacements { get; set; }

        public PerkReplacementList()
        {

        }
    }
    public class GameModeMapData
    {
        [BINValue("mModeName")] public Hash ModeName { get; set; }
        [BINValue("mChampionLists")] public List<GameModeChampionList> ChampionLists { get; set; }
        [BINValue("mPreloadList")] public Link<CharacterPreloadList> PreloadList { get; set; }
        [BINValue(4148979643)] public string m4148979643 { get; set; }
        [BINValue(2519132899)] public Link<Class_4103435203> m2519132899 { get; set; }
        [BINValue("mRelativeColorization")] public bool RelativeColorization { get; set; }
        [BINValue("mNeutralTimersDisplay")] public Link<NeutralTimers> NeutralTimersDisplay { get; set; }
        [BINValue("mCursorConfig")] public Hash CursorConfig { get; set; }
        [BINValue("mCursorConfigUpdate")] public Hash CursorConfigUpdate { get; set; }
        [BINValue("mHudScoreData")] public Hash HudScoreData { get; set; }
        [BINValue("mRenderStyle")] public Link<RenderStyleData> RenderStyle { get; set; }
        [BINValue(1845085589)] public Link<Class_1059987028> m1845085589 { get; set; }
        [BINValue(531929294)] public Link<GameModeItemList> m531929294 { get; set; }
        [BINValue("mExperienceCurveData")] public Link<ExperienceCurveData> ExperienceCurveData { get; set; }
        [BINValue("mExperienceModData")] public Link<ExperienceModData> ExperienceModData { get; set; }
        [BINValue("mDeathTimes")] public Link<DeathTimes> DeathTimes { get; set; }
        [BINValue("mLoadScreenTipConfiguration")] public Link<LoadScreenTipConfiguration> LoadScreenTipConfiguration { get; set; }
        [BINValue("mMapLocators")] public Link<MapLocatorArray> MapLocators { get; set; }
        [BINValue("mPerkReplacements")] public PerkReplacementList PerkReplacements { get; set; }
        [BINValue("mGameModeConstants")] public Link<GameModeConstants> GameModeConstants { get; set; }
        [BINValue("mGameplayConfig")] public Link<GameplayConfig> GameplayConfig { get; set; }
        [BINValue(3386271259)] public Link<Class_4073390176> m3386271259 { get; set; }
        [BINValue(3906072283)] public Link<Class_2687760845> m3906072283 { get; set; }
        [BINValue(1890753597)] public List<Class_1936278667> m1890753597 { get; set; }
        [BINValue("mLoadingScreenBackground")] public string LoadingScreenBackground { get; set; }

        public GameModeMapData()
        {

        }
    }
    public class Class_2319232567 : MapPlaceable
    {
        [BINValue("sunColor")] public Vector4 SunColor { get; set; }
        [BINValue("sunDirection")] public Vector3 SunDirection { get; set; }
        [BINValue(3632599555)] public float m3632599555 { get; set; }
        [BINValue("skyLightColor")] public Vector4 SkyLightColor { get; set; }
        [BINValue("horizonColor")] public Vector4 HorizonColor { get; set; }
        [BINValue("groundColor")] public Vector4 GroundColor { get; set; }
        [BINValue("skyLightScale")] public float SkyLightScale { get; set; }
        [BINValue("lightMapColorScale")] public float LightMapColorScale { get; set; }
        [BINValue("fogEnabled")] public bool FogEnabled { get; set; }
        [BINValue("fogColor")] public Vector4 FogColor { get; set; }
        [BINValue("fogAlternateColor")] public Vector4 FogAlternateColor { get; set; }
        [BINValue("fogStartAndEnd")] public Vector2 FogStartAndEnd { get; set; }
        [BINValue("fogEmissiveRemap")] public float FogEmissiveRemap { get; set; }
        [BINValue("fogLowQualityModeEmissiveRemap")] public float FogLowQualityModeEmissiveRemap { get; set; }

        public Class_2319232567()
        {

        }
    }
    public class GameModeChampionList
    {
        [BINValue("mChampions")] public List<Hash> Champions { get; set; }

        public GameModeChampionList()
        {

        }
    }
    public class HasBuffDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mScriptName")] public string ScriptName { get; set; }
        [BINValue(4286635898)] public float m4286635898 { get; set; }

        public HasBuffDynamicMaterialBoolDriver()
        {

        }
    }
    public class Character
    {
        [BINValue("name")] public string Name { get; set; }

        public Character()
        {

        }
    }
    public class Class_2338173165
    {
        [BINValue("mBoneName")] public string BoneName { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue("mEffectName")] public string EffectName { get; set; }
        [BINValue("mEffectKey")] public Hash EffectKey { get; set; }
        [BINValue(4269114704)] public string m4269114704 { get; set; }
        [BINValue(2688193858)] public Hash m2688193858 { get; set; }
        [BINValue(3291281549)] public bool m3291281549 { get; set; }
        [BINValue(3967304360)] public float m3967304360 { get; set; }
        [BINValue(2757679739)] public bool m2757679739 { get; set; }
        [BINValue(2270784147)] public uint m2270784147 { get; set; }
        [BINValue(1660255353)] public bool m1660255353 { get; set; }
        [BINValue(2347668140)] public bool m2347668140 { get; set; }
        [BINValue(4246608820)] public bool m4246608820 { get; set; }
        [BINValue(1161004262)] public bool m1161004262 { get; set; }

        public Class_2338173165()
        {

        }
    }
    public class SkinMeshDataProperties_MaterialOverride
    {
        [BINValue("material")] public Link<IMaterialDef> Material { get; set; }
        [BINValue("texture")] public string Texture { get; set; }
        [BINValue("glossTexture")] public string GlossTexture { get; set; }
        [BINValue("submesh")] public string Submesh { get; set; }

        public SkinMeshDataProperties_MaterialOverride()
        {

        }
    }
    public class EffectValueCalculationPart : Class_3053458126
    {
        [BINValue(2331712095)] public int m2331712095 { get; set; }

        public EffectValueCalculationPart()
        {

        }
    }
    public class GenericMapPlaceable : MapPlaceable
    {

        public GenericMapPlaceable()
        {

        }
    }
    public class Class_2357149705 : Class_4153143643
    {
        [BINValue(3804467094)] public bool m3804467094 { get; set; }

        public Class_2357149705()
        {

        }
    }
    public class SequencerClipData : ClipBaseData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mClipNameList")] public List<Hash> ClipNameList { get; set; }

        public SequencerClipData()
        {

        }
    }
    public class Breakpoint
    {
        [BINValue("mLevel")] public uint Level { get; set; }
        [BINValue(3590129645)] public float m3590129645 { get; set; }
        [BINValue(1476248632)] public float m1476248632 { get; set; }

        public Breakpoint()
        {

        }
    }
    public class ConditionFloatClipData : ClipBaseData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mConditionFloatPairDataList")] public List<ConditionFloatPairData> ConditionFloatPairDataList { get; set; }
        [BINValue("mUpdaterType")] public uint UpdaterType { get; set; }
        [BINValue("mChangeAnimationMidPlay")] public bool ChangeAnimationMidPlay { get; set; }
        [BINValue("mChildAnimDelaySwitchTime")] public float ChildAnimDelaySwitchTime { get; set; }

        public ConditionFloatClipData()
        {

        }
    }
    public class DefaultSplashedPerkStyle
    {
        [BINValue("mStyle")] public Link<PerkStyle> Style { get; set; }
        [BINValue("mPerk1")] public Link<Perk> Perk1 { get; set; }
        [BINValue("mPerk2")] public Link<Perk> Perk2 { get; set; }

        public DefaultSplashedPerkStyle()
        {

        }
    }
    public class SkinAudioProperties
    {
        [BINValue("tagEventList")] public List<string> TagEventList { get; set; }
        [BINValue("bankUnits")] public List<BankUnit> BankUnits { get; set; }

        public SkinAudioProperties()
        {

        }
    }
    public class WallFollowMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mInferDirectionFromFacingIfNeeded")] public bool InferDirectionFromFacingIfNeeded { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mUseGroundHeightAtTarget")] public bool UseGroundHeightAtTarget { get; set; }
        [BINValue("mSpeed")] public float Speed { get; set; }
        [BINValue("mCounterClockwise")] public bool CounterClockwise { get; set; }
        [BINValue(2261403255)] public float m2261403255 { get; set; }
        [BINValue(3085905440)] public float m3085905440 { get; set; }
        [BINValue("mWallSearchRadius")] public float WallSearchRadius { get; set; }
        [BINValue(3170840289)] public bool m3170840289 { get; set; }

        public WallFollowMovement()
        {

        }
    }
    public class Class_2412429686 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }
        [BINValue("mBuffComparisons")] public Class_3686997399 BuffComparisons { get; set; }

        public Class_2412429686()
        {

        }
    }
    public class Class_2415052226
    {
        [BINValue(1916628881)] public Dictionary<string, Class_3828118224> m1916628881 { get; set; }

        public Class_2415052226()
        {

        }
    }
    public class FloorFloatMaterialDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mDriver")] public IDynamicMaterialFloatDriver Driver { get; set; }

        public FloorFloatMaterialDriver()
        {

        }
    }
    public class FloatComparisonMaterialDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mOperator")] public uint Operator { get; set; }
        [BINValue("mValueA")] public IDynamicMaterialFloatDriver ValueA { get; set; }
        [BINValue("mValueB")] public IDynamicMaterialFloatDriver ValueB { get; set; }

        public FloatComparisonMaterialDriver()
        {

        }
    }
    public class Class_2433758018 : Class_1348413282
    {
        [BINValue("mTimeStart")] public float TimeStart { get; set; }
        [BINValue("mTimeEnd")] public float TimeEnd { get; set; }
        [BINValue("mStartAlpha")] public float StartAlpha { get; set; }
        [BINValue("mEndAlpha")] public float EndAlpha { get; set; }

        public Class_2433758018()
        {

        }
    }
    public class DistanceToPlayerMaterialFloatDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("minDistance")] public float MinDistance { get; set; }
        [BINValue("maxDistance")] public float MaxDistance { get; set; }

        public DistanceToPlayerMaterialFloatDriver()
        {

        }
    }
    public class AllTrueMaterialDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mDrivers")] public List<IDynamicMaterialBoolDriver> Drivers { get; set; }

        public AllTrueMaterialDriver()
        {

        }
    }
    public class EnterFOWVisibility : MissileVisibilitySpec
    {
        [BINValue("mTargetControlsVisibility")] public bool TargetControlsVisibility { get; set; }
        [BINValue("mVisibleToOwnerTeamOnly")] public bool VisibleToOwnerTeamOnly { get; set; }
        [BINValue("mPerceptionBubbleRadius")] public float PerceptionBubbleRadius { get; set; }
        [BINValue("mMissileClientExitFOWPrediction")] public bool MissileClientExitFOWPrediction { get; set; }
        [BINValue("mMissileClientWaitForTargetUpdateBeforeMissileShow")] public bool MissileClientWaitForTargetUpdateBeforeMissileShow { get; set; }

        public EnterFOWVisibility()
        {

        }
    }
    public class SpellEffectAmount
    {
        [BINValue("value")] public List<float> Value { get; set; }

        public SpellEffectAmount()
        {

        }
    }
    public class VectorTableSet : ScriptTableSet
    {

        public VectorTableSet()
        {

        }
    }
    public interface Class_2479546740
    {
    }
    public class ExperienceCurveData
    {
        [BINValue("mExperienceRequiredPerLevel")] public List<float> ExperienceRequiredPerLevel { get; set; }
        [BINValue("mExperienceGrantedForKillPerLevel")] public List<float> ExperienceGrantedForKillPerLevel { get; set; }
        [BINValue("mBaseExperienceMultiplier")] public float BaseExperienceMultiplier { get; set; }
        [BINValue("mLevelDifferenceExperienceMultiplier")] public float LevelDifferenceExperienceMultiplier { get; set; }
        [BINValue("mMinimumExperienceMultiplier")] public float MinimumExperienceMultiplier { get; set; }

        public ExperienceCurveData()
        {

        }
    }
    public class RegionsThatAllowContent
    {
        [BINValue("mRegionList")] public List<Hash> RegionList { get; set; }

        public RegionsThatAllowContent()
        {

        }
    }
    public class Cheat
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mIsPlayerFacing")] public bool IsPlayerFacing { get; set; }
        [BINValue("mCheatMenuUIData")] public CheatMenuUIData CheatMenuUIData { get; set; }
        [BINValue("mRecastFrequency")] public float RecastFrequency { get; set; }

        public Cheat()
        {

        }
    }
    public class Class_2506805399
    {
        [BINValue(3287630061)] public List<Class_646351631> m3287630061 { get; set; }
        [BINValue(3004055014)] public List<Class_646351631> m3004055014 { get; set; }

        public Class_2506805399()
        {

        }
    }
    public class ContextualConditionCharacterMetadata : ICharacterSubcondition
    {
        [BINValue("mCategory")] public string Category { get; set; }
        [BINValue("mData")] public string Data { get; set; }

        public ContextualConditionCharacterMetadata()
        {

        }
    }
    public interface BaseLoadoutData : Class_2479546740
    {
        [BINValue(4134177491)] string m4134177491 { get; set; }
        [BINValue(607049692)] Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] string m1905664938 { get; set; }
    }
    public class Class_2515485450
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("type")] public uint Type { get; set; }
        [BINValue("frequency")] public uint Frequency { get; set; }
        [BINValue("constants")] public List<Class_19256412> Constants { get; set; }
        [BINValue(2825931196)] public bool m2825931196 { get; set; }
        [BINValue(761819584)] public int m761819584 { get; set; }
        [BINValue(3548357530)] public uint m3548357530 { get; set; }

        public Class_2515485450()
        {

        }
    }
    public class Class_2516419817 : IStatStoneLogicDriver
    {

        public Class_2516419817()
        {

        }
    }
    public class StatStoneSet : Class_2479546740
    {
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(3412566397)] public List<StatStoneData> m3412566397 { get; set; }

        public StatStoneSet()
        {

        }
    }
    public class VfxChildIdentifier
    {
        [BINValue("effectKey")] public Hash EffectKey { get; set; }
        [BINValue("effect")] public Link<VfxSystemDefinitionData> Effect { get; set; }
        [BINValue("effectName")] public string EffectName { get; set; }

        public VfxChildIdentifier()
        {

        }
    }
    public class GravityHeightSolver : HeightSolverType
    {
        [BINValue("mGravity")] public float Gravity { get; set; }

        public GravityHeightSolver()
        {

        }
    }
    public class VfxPrimitiveCameraQuad : VfxPrimitiveBase
    {

        public VfxPrimitiveCameraQuad()
        {

        }
    }
    public class ToonInkingFilterParams
    {
        [BINValue("mPixelSize")] public float PixelSize { get; set; }
        [BINValue("mMinVal")] public float MinVal { get; set; }
        [BINValue("mMaxVal")] public float MaxVal { get; set; }
        [BINValue("mResultScale")] public float ResultScale { get; set; }

        public ToonInkingFilterParams()
        {

        }
    }
    public class GameModeConstantFloat : GameModeConstant
    {
        [BINValue("mValue")] public float Value { get; set; }

        public GameModeConstantFloat()
        {

        }
    }
    public class TrackData
    {
        [BINValue("mPriority")] public uint Priority { get; set; }
        [BINValue("mBlendWeight")] public float BlendWeight { get; set; }
        [BINValue("mBlendMode")] public uint BlendMode { get; set; }

        public TrackData()
        {

        }
    }
    public class VelocityDynamicMaterialFloatDriver : IDynamicMaterialFloatDriver
    {

        public VelocityDynamicMaterialFloatDriver()
        {

        }
    }
    public class CreateFunctionBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("Function")] public FunctionTableSet Function { get; set; }
        [BINValue("FunctionDefinition")] public FunctionDefinition FunctionDefinition { get; set; }

        public CreateFunctionBlock()
        {

        }
    }
    public class Class_2572940566 : Class_3053458126
    {
        [BINValue(483933259)] public Class_3053458126 m483933259 { get; set; }
        [BINValue(3101490363)] public float m3101490363 { get; set; }
        [BINValue("mStat")] public byte Stat { get; set; }
        [BINValue(2100383980)] public byte m2100383980 { get; set; }
        [BINValue(2569852907)] public string m2569852907 { get; set; }
        [BINValue(2775882578)] public string m2775882578 { get; set; }

        public Class_2572940566()
        {

        }
    }
    public class Companion : Character
    {

        public Companion()
        {

        }
    }
    public class CheatPage
    {
        [BINValue("mCheats")] public List<Cheat> Cheats { get; set; }

        public CheatPage()
        {

        }
    }
    public class NumberFormattingData
    {
        [BINValue(1535520071)] public string m1535520071 { get; set; }
        [BINValue(3515031867)] public string m3515031867 { get; set; }
        [BINValue(3113614111)] public string m3113614111 { get; set; }
        [BINValue(1089846550)] public string m1089846550 { get; set; }
        [BINValue(3990416003)] public string m3990416003 { get; set; }
        [BINValue(823565823)] public string m823565823 { get; set; }
        [BINValue(3841310158)] public string m3841310158 { get; set; }
        [BINValue(19785452)] public string m19785452 { get; set; }
        [BINValue(1880587249)] public string m1880587249 { get; set; }
        [BINValue(2965779045)] public string m2965779045 { get; set; }
        [BINValue(2309425659)] public string m2309425659 { get; set; }
        [BINValue(2051901883)] public Dictionary<Hash, Link<NumberFormattingBehavior>> m2051901883 { get; set; }

        public NumberFormattingData()
        {

        }
    }
    public class DeathTimesScalingPoint
    {
        [BINValue("mStartTime")] public uint StartTime { get; set; }
        [BINValue("mPercentIncrease")] public float PercentIncrease { get; set; }

        public DeathTimesScalingPoint()
        {

        }
    }
    public class TooltipInstanceListElement
    {
        [BINValue("type")] public string Type { get; set; }
        [BINValue("typeIndex")] public int TypeIndex { get; set; }
        [BINValue("multiplier")] public float Multiplier { get; set; }
        [BINValue("nameOverride")] public string NameOverride { get; set; }
        [BINValue(2888859350)] public uint m2888859350 { get; set; }

        public TooltipInstanceListElement()
        {

        }
    }
    public class AnimationResourceData
    {
        [BINValue("mAnimationFilePath")] public string AnimationFilePath { get; set; }

        public AnimationResourceData()
        {

        }
    }
    public class Class_2599819896 : Class_3053458126
    {
        [BINValue(1854058873)] public Class_3053458126 m1854058873 { get; set; }
        [BINValue(4038717832)] public float m4038717832 { get; set; }

        public Class_2599819896()
        {

        }
    }
    public class FontLocaleType
    {
        [BINValue("localeName")] public string LocaleName { get; set; }
        [BINValue(2271524388)] public string m2271524388 { get; set; }
        [BINValue(281301214)] public string m281301214 { get; set; }
        [BINValue(1802990466)] public string m1802990466 { get; set; }

        public FontLocaleType()
        {

        }
    }
    public class Area : Class_2144288560
    {

        public Area()
        {

        }
    }
    public class SpellLevelUpInfo
    {
        [BINValue("mRequirements")] public List<SpellRankUpRequirements> Requirements { get; set; }

        public SpellLevelUpInfo()
        {

        }
    }
    public class SkinCharacterDataProperties
    {
        [BINValue("skinClassification")] public uint SkinClassification { get; set; }
        [BINValue("championSkinName")] public string ChampionSkinName { get; set; }
        [BINValue("attributeFlags")] public uint AttributeFlags { get; set; }
        [BINValue("skinParent")] public int SkinParent { get; set; }
        [BINValue("metaDataTags")] public string MetaDataTags { get; set; }
        [BINValue("emoteLoadout")] public Hash EmoteLoadout { get; set; }
        [BINValue("skinUpgradeData")] public SkinUpgradeData SkinUpgradeData { get; set; }
        [BINValue(1182316791)] public string m1182316791 { get; set; }
        [BINValue("loadscreen")] public string Loadscreen { get; set; }
        [BINValue("loadscreenVintage")] public string LoadscreenVintage { get; set; }
        [BINValue("uncensoredLoadscreens")] public Dictionary<Hash, string> UncensoredLoadscreens { get; set; }
        [BINValue("skinAudioProperties")] public SkinAudioProperties SkinAudioProperties { get; set; }
        [BINValue("skinAnimationProperties")] public SkinAnimationProperties SkinAnimationProperties { get; set; }
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }
        [BINValue("armorMaterial")] public string ArmorMaterial { get; set; }
        [BINValue("themeMusic")] public List<string> ThemeMusic { get; set; }
        [BINValue("defaultAnimations")] public List<string> DefaultAnimations { get; set; }
        [BINValue("idleParticlesEffects")] public List<SkinCharacterDataProperties_CharacterIdleEffect> IdleParticlesEffects { get; set; }
        [BINValue("particleOverride_ChampionKillDeathParticle")] public string ParticleOverride_ChampionKillDeathParticle { get; set; }
        [BINValue("particleOverride_DeathParticle")] public string ParticleOverride_DeathParticle { get; set; }
        [BINValue("mSpawnParticleName")] public string SpawnParticleName { get; set; }
        [BINValue("extraCharacterPreloads")] public List<string> ExtraCharacterPreloads { get; set; }
        [BINValue("voiceOverOverride")] public string VoiceOverOverride { get; set; }
        [BINValue("skipVOOverride")] public bool SkipVOOverride { get; set; }
        [BINValue("iconAvatar")] public string IconAvatar { get; set; }
        [BINValue("mContextualActionData")] public Link<ContextualActionData> ContextualActionData { get; set; }
        [BINValue("skinAudioNameOverride")] public string SkinAudioNameOverride { get; set; }
        [BINValue("iconCircle")] public Optional<string> IconCircle { get; set; }
        [BINValue("iconCircleScale")] public Optional<float> IconCircleScale { get; set; }
        [BINValue("iconSquare")] public Optional<string> IconSquare { get; set; }
        [BINValue(741440203)] public string m741440203 { get; set; }
        [BINValue("alternateIconsCircle")] public List<string> AlternateIconsCircle { get; set; }
        [BINValue("alternateIconsSquare")] public List<string> AlternateIconsSquare { get; set; }
        [BINValue("uncensoredIconCircles")] public Dictionary<Hash, string> UncensoredIconCircles { get; set; }
        [BINValue("uncensoredIconSquares")] public Dictionary<Hash, string> UncensoredIconSquares { get; set; }
        [BINValue("secondaryResourceHudDisplayData")] public ISecondaryResourceDisplayData SecondaryResourceHudDisplayData { get; set; }
        [BINValue("emoteBuffbone")] public string EmoteBuffbone { get; set; }
        [BINValue("emoteYOffset")] public float EmoteYOffset { get; set; }
        [BINValue("godrayFXbone")] public string GodrayFXbone { get; set; }
        [BINValue("healthBarData")] public CharacterHealthBarDataRecord HealthBarData { get; set; }
        [BINValue("mEmblems")] public List<SkinEmblem> Emblems { get; set; }
        [BINValue("rarityGemOverride")] public Optional<int> RarityGemOverride { get; set; }
        [BINValue("mResourceResolver")] public Link<ResourceResolver> ResourceResolver { get; set; }
        [BINValue(2188533552)] public List<ResourceResolver> m2188533552 { get; set; }

        public SkinCharacterDataProperties()
        {

        }
    }
    public class EffectArcFillElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }

        public EffectArcFillElementData()
        {

        }
    }
    public class ContextualConditionMultikillSize : IContextualCondition
    {
        [BINValue("mMultikillSize")] public byte MultikillSize { get; set; }

        public ContextualConditionMultikillSize()
        {

        }
    }
    public class Class_2611874788 : Class_1405067729
    {

        public Class_2611874788()
        {

        }
    }
    public class SoundEventData : BaseEventData
    {
        [BINValue("mSoundName")] public string SoundName { get; set; }
        [BINValue("mIsLoop")] public bool IsLoop { get; set; }
        [BINValue("mIsKillEvent")] public bool IsKillEvent { get; set; }

        public SoundEventData()
        {

        }
    }
    public class TextElementData : BaseElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFontDescription")] public Link<GameFontDescription> FontDescription { get; set; }
        [BINValue("mTextAlignmentHorizontal")] public byte TextAlignmentHorizontal { get; set; }
        [BINValue("mTextAlignmentVertical")] public byte TextAlignmentVertical { get; set; }
        [BINValue(2081063769)] public Link<Class_3173404643> m2081063769 { get; set; }
        [BINValue(1778988038)] public byte m1778988038 { get; set; }

        public TextElementData()
        {

        }
    }
    public class AddHealthCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mAmount")] public float Amount { get; set; }

        public AddHealthCheat()
        {

        }
    }
    public class ContextualConditionNeutralMinionCampName : IContextualCondition
    {
        [BINValue("mCampName")] public Hash CampName { get; set; }

        public ContextualConditionNeutralMinionCampName()
        {

        }
    }
    public class CastOnMovementComplete : MissileBehaviorSpec
    {

        public CastOnMovementComplete()
        {

        }
    }
    public class ContextualConditionTimeSinceStealthStateChange : IContextualCondition
    {
        [BINValue(2648368516)] public byte m2648368516 { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }
        [BINValue(3998225092)] public float m3998225092 { get; set; }

        public ContextualConditionTimeSinceStealthStateChange()
        {

        }
    }
    public class VectorTableGet : IVectorGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("Default")] public Optional<Vector3> Default { get; set; }

        public VectorTableGet()
        {

        }
    }
    public class Class_2667126912 : Class_3053458126
    {
        [BINValue("mNumber")] public float Number { get; set; }

        public Class_2667126912()
        {

        }
    }
    public class CustomTableGet : IScriptValueGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }

        public CustomTableGet()
        {

        }
    }
    public class Class_2687760845
    {
        [BINValue(1140283803)] public float m1140283803 { get; set; }
        [BINValue(244881724)] public float m244881724 { get; set; }
        [BINValue(3430961411)] public float m3430961411 { get; set; }
        [BINValue(989768947)] public float m989768947 { get; set; }
        [BINValue(321593752)] public Dictionary<byte, SurrenderTypeData> m321593752 { get; set; }

        public Class_2687760845()
        {

        }
    }
    public class ContextualConditionNeutralMinionCampIsAlive : IContextualCondition
    {
        [BINValue("mCampIsAlive")] public bool CampIsAlive { get; set; }

        public ContextualConditionNeutralMinionCampIsAlive()
        {

        }
    }
    public class VfxPrimitiveRay : VfxPrimitiveBase
    {

        public VfxPrimitiveRay()
        {

        }
    }
    public class ScriptPreloadSpell
    {
        [BINValue("PreloadResourceName")] public string PreloadResourceName { get; set; }

        public ScriptPreloadSpell()
        {

        }
    }
    public class Class_2709250460 : Class_1936278667
    {
        [BINValue("mSceneName")] public string SceneName { get; set; }
        [BINValue(2065649608)] public byte m2065649608 { get; set; }
        [BINValue(878940594)] public Link<Class_470840304> m878940594 { get; set; }

        public Class_2709250460()
        {

        }
    }
    public class GameModeConstantString : GameModeConstant
    {
        [BINValue("mValue")] public string Value { get; set; }

        public GameModeConstantString()
        {

        }
    }
    public class ContextualConditionCharacterUnitTags : ICharacterSubcondition
    {
        [BINValue("mTagMode")] public byte TagMode { get; set; }
        [BINValue("mUnitTags")] public ObjectTags UnitTags { get; set; }

        public ContextualConditionCharacterUnitTags()
        {

        }
    }
    public class MinimapBackground
    {
        [BINValue("mOrigin")] public Vector2 Origin { get; set; }
        [BINValue("mSize")] public Vector2 Size { get; set; }
        [BINValue("mTextureName")] public string TextureName { get; set; }

        public MinimapBackground()
        {

        }
    }
    public class Class_2722078078
    {
        [BINValue(1348827540)] public List<Class_1363101953> m1348827540 { get; set; }

        public Class_2722078078()
        {

        }
    }
    public class Class_2724041810
    {
        [BINValue("mItems")] public List<Hash> Items { get; set; }

        public Class_2724041810()
        {

        }
    }
    public class SecondaryResourceDisplayFractional : ISecondaryResourceDisplayData
    {

        public SecondaryResourceDisplayFractional()
        {

        }
    }
    public class Class_2727115092
    {
        [BINValue(1335420358)] public Dictionary<string, Class_1589364011> m1335420358 { get; set; }

        public Class_2727115092()
        {

        }
    }
    public class BoolTableSet : ScriptTableSet
    {

        public BoolTableSet()
        {

        }
    }
    public class ContextualConditionCharacter : IContextualCondition
    {
        [BINValue("mCharacterType")] public byte CharacterType { get; set; }
        [BINValue("mChildConditions")] public List<ICharacterSubcondition> ChildConditions { get; set; }

        public ContextualConditionCharacter()
        {

        }
    }
    public class TftMapSkin : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("mapContainer")] public string MapContainer { get; set; }

        public TftMapSkin()
        {

        }
    }
    public class HudBannerData
    {
        [BINValue("transitionTime")] public float TransitionTime { get; set; }
        [BINValue(2449524942)] public byte m2449524942 { get; set; }
        [BINValue(2960635160)] public byte m2960635160 { get; set; }
        [BINValue("transitionOffset")] public Vector2 TransitionOffset { get; set; }
        [BINValue(4045513993)] public Vector2 m4045513993 { get; set; }
        [BINValue(1284438647)] public float m1284438647 { get; set; }
        [BINValue(229098546)] public float m229098546 { get; set; }
        [BINValue(427443163)] public float m427443163 { get; set; }

        public HudBannerData()
        {

        }
    }
    public interface EffectElementData : BaseElementData
    {
    }
    public interface WadFileDescriptor
    {
    }
    public class Class_2746720777 : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }
        [BINValue("mDistance")] public float Distance { get; set; }

        public Class_2746720777()
        {

        }
    }
    public class BankUnit
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("bankPath")] public List<string> BankPath { get; set; }
        [BINValue("events")] public List<string> Events { get; set; }
        [BINValue("asynchrone")] public bool Asynchrone { get; set; }
        [BINValue("voiceOver")] public bool VoiceOver { get; set; }

        public BankUnit()
        {

        }
    }
    public class VfxPrimitiveAttachedMesh : VfxPrimitiveMeshBase
    {
        [BINValue("mMesh")] public VfxMeshDefinitionData Mesh { get; set; }

        public VfxPrimitiveAttachedMesh()
        {

        }
    }
    public class TooltipInstanceSpell : TooltipInstance
    {
        [BINValue(1669781464)] public bool m1669781464 { get; set; }

        public TooltipInstanceSpell()
        {

        }
    }
    public class PerkScriptData
    {
        [BINValue("mEffectAmount")] public Dictionary<Hash, float> EffectAmount { get; set; }
        [BINValue(2427468992)] public Dictionary<Hash, Class_2971960800> m2427468992 { get; set; }
        [BINValue(3702070358)] public Dictionary<Hash, Class_389493299> m3702070358 { get; set; }

        public PerkScriptData()
        {

        }
    }
    public class Class_2774165054 : MapComponent
    {
        [BINValue(2327119739)] public List<Class_243000503> m2327119739 { get; set; }

        public Class_2774165054()
        {

        }
    }
    public class ChampionMasteryMap
    {
        [BINValue("masteryData")] public Dictionary<int, Link<MasteryData>> MasteryData { get; set; }

        public ChampionMasteryMap()
        {

        }
    }
    public class SummonerIconData
    {
        [BINValue("iconId")] public uint IconId { get; set; }
        [BINValue(3114625026)] public Link<Class_3808259511> m3114625026 { get; set; }
        [BINValue("gameTexture")] public string GameTexture { get; set; }
        [BINValue(1357231841)] public bool m1357231841 { get; set; }
        [BINValue("eSportsEventMutator")] public string ESportsEventMutator { get; set; }

        public SummonerIconData()
        {

        }
    }
    public class EngineFeatureToggles
    {
        [BINValue("useKeywordsForVFXOwner")] public bool UseKeywordsForVFXOwner { get; set; }
        [BINValue(3388857582)] public bool m3388857582 { get; set; }
        [BINValue(3837752747)] public bool m3837752747 { get; set; }

        public EngineFeatureToggles()
        {

        }
    }
    public class ScriptSequence : RScript
    {
        [BINValue("blocks")] public List<IScriptBlock> Blocks { get; set; }

        public ScriptSequence()
        {

        }
    }
    public class ToggleTeamCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }

        public ToggleTeamCheat()
        {

        }
    }
    public interface IFloatGet : IScriptValueGet
    {
    }
    public class HudReplayData
    {
        [BINValue("messageVisibleTime")] public float MessageVisibleTime { get; set; }
        [BINValue(3478055546)] public Class_3784622423 m3478055546 { get; set; }

        public HudReplayData()
        {

        }
    }
    public class TogglePlantFastRespawnCheat : Cheat
    {

        public TogglePlantFastRespawnCheat()
        {

        }
    }
    public class EffectRotatingIconElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }

        public EffectRotatingIconElementData()
        {

        }
    }
    public class MapLocator : GenericMapPlaceable
    {

        public MapLocator()
        {

        }
    }
    public class NotScriptCondition : IScriptCondition
    {
        [BINValue("Condition")] public IScriptCondition Condition { get; set; }

        public NotScriptCondition()
        {

        }
    }
    public class VfxPaletteDefinitionData
    {
        [BINValue("paletteTexture")] public string PaletteTexture { get; set; }
        [BINValue("palleteSrcMixColor")] public ValueColor PalleteSrcMixColor { get; set; }
        [BINValue("paletteSelector")] public ValueVector3 PaletteSelector { get; set; }
        [BINValue("paletteCount")] public int PaletteCount { get; set; }
        [BINValue("paletteBlendRegister")] public int PaletteBlendRegister { get; set; }

        public VfxPaletteDefinitionData()
        {

        }
    }
    public class Class_2832031521 : Class_1348413282
    {
        [BINValue(3246681660)] public float m3246681660 { get; set; }

        public Class_2832031521()
        {

        }
    }
    public class VfxSpawnConditions
    {
        [BINValue(2275536844)] public List<Class_3390937687> m2275536844 { get; set; }
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public VfxSpawnConditions()
        {

        }
    }
    public class RemoveFromCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("Key")] public IScriptValueGet Key { get; set; }
        [BINValue("Index")] public IIntGet Index { get; set; }

        public RemoveFromCustomTableBlock()
        {

        }
    }
    public class RemapFloatMaterialDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mDriver")] public IDynamicMaterialFloatDriver Driver { get; set; }
        [BINValue("mMinValue")] public float MinValue { get; set; }
        [BINValue("mMaxValue")] public float MaxValue { get; set; }
        [BINValue("mOutputMinValue")] public float OutputMinValue { get; set; }
        [BINValue("mOutputMaxValue")] public float OutputMaxValue { get; set; }

        public RemapFloatMaterialDriver()
        {

        }
    }
    public class GameModeConstantFloatPerLevel : GameModeConstant
    {
        [BINValue("mValues")] public List<float> Values { get; set; }

        public GameModeConstantFloatPerLevel()
        {

        }
    }
    public class Cast : Class_1405067729
    {

        public Cast()
        {

        }
    }
    public class Class_2857147974 : IStatStoneLogicDriver
    {
        [BINValue(2715825086)] public bool m2715825086 { get; set; }
        [BINValue(2034521402)] public bool m2034521402 { get; set; }
        [BINValue(718612390)] public bool m718612390 { get; set; }
        [BINValue(1646138587)] public bool m1646138587 { get; set; }
        [BINValue(1622655414)] public bool m1622655414 { get; set; }
        [BINValue(3418552506)] public bool m3418552506 { get; set; }
        [BINValue(788241703)] public bool m788241703 { get; set; }
        [BINValue(385993226)] public bool m385993226 { get; set; }

        public Class_2857147974()
        {

        }
    }
    public class CustomTableSet : ScriptTableSet
    {

        public CustomTableSet()
        {

        }
    }
    public class SceneData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mHealthBar")] public bool HealthBar { get; set; }
        [BINValue("mParentScene")] public Link<SceneData> ParentScene { get; set; }

        public SceneData()
        {

        }
    }
    public class Class_2874766227 : Cheat
    {

        public Class_2874766227()
        {

        }
    }
    public class SwitchMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("mElements")] public List<SwitchMaterialDriverElement> Elements { get; set; }
        [BINValue("mDefaultValue")] public IDynamicMaterialDriver DefaultValue { get; set; }

        public SwitchMaterialDriver()
        {

        }
    }
    public class Class_2898073997 : IStatStoneLogicDriver
    {
        [BINValue(550470828)] public List<byte> m550470828 { get; set; }
        [BINValue(2443043316)] public bool m2443043316 { get; set; }

        public Class_2898073997()
        {

        }
    }
    public class VfxAnimatedVector3fVariableData
    {
        [BINValue("probabilityTables")] public List<VfxProbabilityTableData> ProbabilityTables { get; set; }
        [BINValue("times")] public List<float> Times { get; set; }
        [BINValue("values")] public List<Vector3> Values { get; set; }

        public VfxAnimatedVector3fVariableData()
        {

        }
    }
    public class EffectInstancedElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }
        [BINValue("mAdditionalOffsets")] public List<Vector2> AdditionalOffsets { get; set; }

        public EffectInstancedElementData()
        {

        }
    }
    public class MapLocatorArray
    {
        [BINValue("locators")] public List<MapLocator> Locators { get; set; }

        public MapLocatorArray()
        {

        }
    }
    public class Class_2903535207 : Class_3053458126
    {
        [BINValue("mPart1")] public Class_3053458126 Part1 { get; set; }
        [BINValue("mPart2")] public Class_3053458126 Part2 { get; set; }

        public Class_2903535207()
        {

        }
    }
    public interface IBoolGet : IScriptValueGet
    {
    }
    public class Class_2925773367 : IStatStoneLogicDriver
    {

        public Class_2925773367()
        {

        }
    }
    public class Joint
    {
        [BINValue("mIndex")] public ushort Index { get; set; }
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mNameHash")] public uint NameHash { get; set; }
        [BINValue("mFlags")] public ushort Flags { get; set; }
        [BINValue("mRadius")] public float Radius { get; set; }
        [BINValue("mParentIndex")] public short ParentIndex { get; set; }

        public Joint()
        {

        }
    }
    public class AcceleratingMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mInferDirectionFromFacingIfNeeded")] public bool InferDirectionFromFacingIfNeeded { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mUseGroundHeightAtTarget")] public bool UseGroundHeightAtTarget { get; set; }
        [BINValue("mAcceleration")] public float Acceleration { get; set; }
        [BINValue("mMinSpeed")] public float MinSpeed { get; set; }
        [BINValue("mMaxSpeed")] public float MaxSpeed { get; set; }
        [BINValue("mInitialSpeed")] public float InitialSpeed { get; set; }

        public AcceleratingMovement()
        {

        }
    }
    public class Class_2968154316 : Class_3813882857
    {
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public Class_2968154316()
        {

        }
    }
    public class ToolEducationData
    {
        [BINValue("firstItem")] public int FirstItem { get; set; }
        [BINValue("skillOrder")] public int SkillOrder { get; set; }

        public ToolEducationData()
        {

        }
    }
    public class Class_2971935795 : IStatStoneLogicDriver
    {
        [BINValue(3672164089)] public List<byte> m3672164089 { get; set; }

        public Class_2971935795()
        {

        }
    }
    public class Class_2971960800
    {
        [BINValue(2562594311)] public Dictionary<Hash, float> m2562594311 { get; set; }

        public Class_2971960800()
        {

        }
    }
    public class HudScaleSettingsData
    {
        [BINValue("maximumGlobalScale")] public float MaximumGlobalScale { get; set; }
        [BINValue("minimumGlobalScale")] public float MinimumGlobalScale { get; set; }
        [BINValue("maximumMinimapScale")] public float MaximumMinimapScale { get; set; }
        [BINValue("minimumMinimapScale")] public float MinimumMinimapScale { get; set; }
        [BINValue(1804113590)] public float m1804113590 { get; set; }
        [BINValue(3043348288)] public float m3043348288 { get; set; }
        [BINValue("maximumPracticeToolScale")] public float MaximumPracticeToolScale { get; set; }
        [BINValue("minimumPracticeToolScale")] public float MinimumPracticeToolScale { get; set; }
        [BINValue("maximumChatScale")] public float MaximumChatScale { get; set; }
        [BINValue("minimumChatScale")] public float MinimumChatScale { get; set; }

        public HudScaleSettingsData()
        {

        }
    }
    public class Class_2992376383
    {
        [BINValue("items")] public Dictionary<Hash, MapPlaceable> Items { get; set; }

        public Class_2992376383()
        {

        }
    }
    public class DecelToLocationMovement : AcceleratingMovement
    {

        public DecelToLocationMovement()
        {

        }
    }
    public class TooltipFormat
    {
        [BINValue("mObjectName")] public string ObjectName { get; set; }
        [BINValue("mInputLocKeysWithDefaults")] public Dictionary<string, string> InputLocKeysWithDefaults { get; set; }
        [BINValue("mListNames")] public List<string> ListNames { get; set; }
        [BINValue("mListTypeChoices")] public Dictionary<string, string> ListTypeChoices { get; set; }
        [BINValue(991429346)] public Dictionary<uint, string> m991429346 { get; set; }
        [BINValue("mUsesListValues")] public bool UsesListValues { get; set; }
        [BINValue("mListValueSeparator")] public string ListValueSeparator { get; set; }
        [BINValue("mListGridPrefix")] public string ListGridPrefix { get; set; }
        [BINValue("mListGridPostfix")] public string ListGridPostfix { get; set; }
        [BINValue("mListGridSeparator")] public string ListGridSeparator { get; set; }
        [BINValue("mOutputStrings")] public Dictionary<string, string> OutputStrings { get; set; }

        public TooltipFormat()
        {

        }
    }
    public interface BaseRigPoseModifierData
    {
    }
    public class Class_3009378484
    {
        [BINValue(730945406)] public HudMenuTransitionData m730945406 { get; set; }
        [BINValue(3856555387)] public HudMenuTransitionData m3856555387 { get; set; }

        public Class_3009378484()
        {

        }
    }
    public class MapAudioDataProperties
    {
        [BINValue("bankUnits")] public List<BankUnit> BankUnits { get; set; }
        [BINValue("features")] public List<FeatureAudioDataProperties> Features { get; set; }

        public MapAudioDataProperties()
        {

        }
    }
    public class JointSnapRigPoseModifilerData : BaseRigPoseModifierData
    {

        public JointSnapRigPoseModifilerData()
        {

        }
    }
    public class AbilityResourceTypeData
    {
        [BINValue("states")] public List<AbilityResourceStateData> States { get; set; }
        [BINValue("showAbilityResource")] public bool ShowAbilityResource { get; set; }
        [BINValue("showRegen")] public bool ShowRegen { get; set; }

        public AbilityResourceTypeData()
        {

        }
    }
    public class SummonerSpellPerkReplacementList
    {
        [BINValue("mReplacements")] public List<SummonerSpellPerkReplacement> Replacements { get; set; }

        public SummonerSpellPerkReplacementList()
        {

        }
    }
    public class GameplayFeatureToggles
    {
        [BINValue("NewActorStuckPathfinding")] public bool NewActorStuckPathfinding { get; set; }
        [BINValue("fowCastRayAccurate")] public bool FowCastRayAccurate { get; set; }
        [BINValue("disableSpellLevelMinimumProtections")] public bool DisableSpellLevelMinimumProtections { get; set; }
        [BINValue("IndividualItemVisibility")] public bool IndividualItemVisibility { get; set; }
        [BINValue("AFKDetection2")] public bool AFKDetection2 { get; set; }

        public GameplayFeatureToggles()
        {

        }
    }
    public class GearData
    {
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }
        [BINValue("mVFXResourceResolver")] public ResourceResolver VFXResourceResolver { get; set; }
        [BINValue("mEquipAnimation")] public string EquipAnimation { get; set; }
        [BINValue(1725649758)] public string m1725649758 { get; set; }
        [BINValue("mPortraitIcon")] public string PortraitIcon { get; set; }
        [BINValue(3066053883)] public List<Hash> m3066053883 { get; set; }
        [BINValue(565581438)] public List<Hash> m565581438 { get; set; }

        public GearData()
        {

        }
    }
    public class ContextualConditionRuleCooldown : IContextualCondition
    {
        [BINValue("mRuleCooldown")] public float RuleCooldown { get; set; }

        public ContextualConditionRuleCooldown()
        {

        }
    }
    public class LerpMaterialDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("mBoolDriver")] public IDynamicMaterialBoolDriver BoolDriver { get; set; }
        [BINValue("mOnValue")] public float OnValue { get; set; }
        [BINValue("mOffValue")] public float OffValue { get; set; }
        [BINValue("mTurnOnTimeSec")] public float TurnOnTimeSec { get; set; }
        [BINValue("mTurnOffTimeSec")] public float TurnOffTimeSec { get; set; }
        [BINValue(2756886175)] public bool m2756886175 { get; set; }

        public LerpMaterialDriver()
        {

        }
    }
    public class VfxChildParticleSetDefinitionData
    {
        [BINValue("childrenIdentifiers")] public List<VfxChildIdentifier> ChildrenIdentifiers { get; set; }
        [BINValue("boneToSpawnAt")] public List<string> BoneToSpawnAt { get; set; }
        [BINValue("childrenProbability")] public ValueFloat ChildrenProbability { get; set; }
        [BINValue("childEmitOnDeath")] public bool ChildEmitOnDeath { get; set; }

        public VfxChildParticleSetDefinitionData()
        {

        }
    }
    public class ToggleRegenCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mToggleHP")] public bool ToggleHP { get; set; }
        [BINValue("mTogglePAR")] public bool TogglePAR { get; set; }

        public ToggleRegenCheat()
        {

        }
    }
    public class JointSnapEventData : BaseEventData
    {
        [BINValue("mJointNameToOverride")] public Hash JointNameToOverride { get; set; }
        [BINValue("mJointNameToSnapTo")] public Hash JointNameToSnapTo { get; set; }

        public JointSnapEventData()
        {

        }
    }
    public interface Class_3052837161 : Class_3053458126
    {
        [BINValue("mStat")] byte Stat { get; set; }
        [BINValue(2100383980)] byte m2100383980 { get; set; }
    }
    public interface Class_3053458126
    {
    }
    public class VfxFieldOrbitalDefinitionData
    {
        [BINValue("isLocalSpace")] public bool IsLocalSpace { get; set; }
        [BINValue("direction")] public ValueVector3 Direction { get; set; }

        public VfxFieldOrbitalDefinitionData()
        {

        }
    }
    public class ContextualConditionCharacterFormName : ICharacterSubcondition
    {
        [BINValue("mFormName")] public string FormName { get; set; }

        public ContextualConditionCharacterFormName()
        {

        }
    }
    public class Perk : Class_3196794540
    {
        [BINValue("mPerkId")] public uint PerkId { get; set; }
        [BINValue("mPerkName")] public string PerkName { get; set; }
        [BINValue("mDisplayNameLocalizationKey")] public string DisplayNameLocalizationKey { get; set; }
        [BINValue("mTooltipNameLocalizationKey")] public string TooltipNameLocalizationKey { get; set; }
        [BINValue("mPingTextLocalizationKey")] public string PingTextLocalizationKey { get; set; }
        [BINValue("mShortDescLocalizationKey")] public string ShortDescLocalizationKey { get; set; }
        [BINValue("mLongDescLocalizationKey")] public string LongDescLocalizationKey { get; set; }
        [BINValue("mEndOfGameStatDescriptions")] public List<string> EndOfGameStatDescriptions { get; set; }
        [BINValue("mDisplayStatLocalizationKey")] public string DisplayStatLocalizationKey { get; set; }
        [BINValue("mIconTextureName")] public string IconTextureName { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue(3428652312)] public bool m3428652312 { get; set; }
        [BINValue("mScript")] public PerkScript Script { get; set; }
        [BINValue("mBuffs")] public List<PerkBuff> Buffs { get; set; }
        [BINValue("mVFXResourceResolver")] public ResourceResolver VFXResourceResolver { get; set; }
        [BINValue("mCharacters")] public List<string> Characters { get; set; }
        [BINValue("mDefault")] public bool Default { get; set; }
        [BINValue("mMajorChangePatchVersion")] public string MajorChangePatchVersion { get; set; }
        [BINValue("mSummonerPerkReplacements")] public SummonerSpellPerkReplacementList SummonerPerkReplacements { get; set; }

        public Perk()
        {

        }
    }
    public class Class_3070309571 : BaseElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue(2899083445)] public Link<SceneData> m2899083445 { get; set; }

        public Class_3070309571()
        {

        }
    }
    public class ContextualActionPlayAnimation : IContextualAction
    {
        [BINValue("mHashedSituationTrigger")] public Hash HashedSituationTrigger { get; set; }
        [BINValue("mMaxOccurences")] public uint MaxOccurences { get; set; }
        [BINValue("mHashedAnimationName")] public Hash HashedAnimationName { get; set; }
        [BINValue(3031797526)] public bool m3031797526 { get; set; }

        public ContextualActionPlayAnimation()
        {

        }
    }
    public class TriggerOnDelay : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }
        [BINValue("mDelay")] public float Delay { get; set; }

        public TriggerOnDelay()
        {

        }
    }
    public class IntTableGet : IIntGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("Default")] public Optional<int> Default { get; set; }

        public IntTableGet()
        {

        }
    }
    public class FloatingTextDamageDisplayTypeList
    {
        [BINValue("Default")] public Link<FloatTextDisplayOverrides> Default { get; set; }
        [BINValue("Impact")] public Link<FloatTextDisplayOverrides> Impact { get; set; }
        [BINValue("Zone")] public Link<FloatTextDisplayOverrides> Zone { get; set; }
        [BINValue("Ult")] public Link<FloatTextDisplayOverrides> Ult { get; set; }
        [BINValue("DotNoCombine")] public Link<FloatTextDisplayOverrides> DotNoCombine { get; set; }
        [BINValue("Dot")] public Link<FloatTextDisplayOverrides> Dot { get; set; }
        [BINValue("DotSlow")] public Link<FloatTextDisplayOverrides> DotSlow { get; set; }
        [BINValue("Multistrike")] public Link<FloatTextDisplayOverrides> Multistrike { get; set; }
        [BINValue("MultistrikeFast")] public Link<FloatTextDisplayOverrides> MultistrikeFast { get; set; }
        [BINValue("MultistrikeSlow")] public Link<FloatTextDisplayOverrides> MultistrikeSlow { get; set; }
        [BINValue("PlayerMinion")] public Link<FloatTextDisplayOverrides> PlayerMinion { get; set; }
        [BINValue("BarrackMinion")] public Link<FloatTextDisplayOverrides> BarrackMinion { get; set; }
        [BINValue("Mini")] public Link<FloatTextDisplayOverrides> Mini { get; set; }
        [BINValue("SelfTrueDamageCounter")] public Link<FloatTextDisplayOverrides> SelfTrueDamageCounter { get; set; }
        [BINValue("SelfPhysicalDamageCounter")] public Link<FloatTextDisplayOverrides> SelfPhysicalDamageCounter { get; set; }
        [BINValue("SelfMagicalDamageCounter")] public Link<FloatTextDisplayOverrides> SelfMagicalDamageCounter { get; set; }

        public FloatingTextDamageDisplayTypeList()
        {

        }
    }
    public class FontResolution
    {
        [BINValue("screenHeight")] public uint ScreenHeight { get; set; }
        [BINValue("fontSize")] public uint FontSize { get; set; }
        [BINValue("outlineSize")] public uint OutlineSize { get; set; }
        [BINValue("shadowDepthX")] public int ShadowDepthX { get; set; }
        [BINValue("shadowDepthY")] public int ShadowDepthY { get; set; }

        public FontResolution()
        {

        }
    }
    public class PerkSubStyleBonus
    {
        [BINValue("mStyleId")] public uint StyleId { get; set; }
        [BINValue("mPerk")] public Link<Perk> Perk { get; set; }

        public PerkSubStyleBonus()
        {

        }
    }
    public interface RScript
    {
    }
    public class ConcatenateStringsBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("String1")] public IStringGet String1 { get; set; }
        [BINValue("String2")] public IStringGet String2 { get; set; }
        [BINValue("Result")] public StringTableSet Result { get; set; }

        public ConcatenateStringsBlock()
        {

        }
    }
    public class Class_3145117116 : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }
        [BINValue("mDelay")] public int Delay { get; set; }

        public Class_3145117116()
        {

        }
    }
    public class BoolTableGet : IBoolGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("Default")] public Optional<bool> Default { get; set; }

        public BoolTableGet()
        {

        }
    }
    public class VfxFieldCollectionDefinitionData
    {
        [BINValue("fieldAccelerationDefinitions")] public List<VfxFieldAccelerationDefinitionData> FieldAccelerationDefinitions { get; set; }
        [BINValue("fieldAttractionDefinitions")] public List<VfxFieldAttractionDefinitionData> FieldAttractionDefinitions { get; set; }
        [BINValue("fieldDragDefinitions")] public List<VfxFieldDragDefinitionData> FieldDragDefinitions { get; set; }
        [BINValue("fieldNoiseDefinitions")] public List<VfxFieldNoiseDefinitionData> FieldNoiseDefinitions { get; set; }
        [BINValue("fieldOrbitalDefinitions")] public List<VfxFieldOrbitalDefinitionData> FieldOrbitalDefinitions { get; set; }

        public VfxFieldCollectionDefinitionData()
        {

        }
    }
    public class ItemSlotHasChargesCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }

        public ItemSlotHasChargesCastRequirement()
        {

        }
    }
    public class StatStoneCategory
    {
        [BINValue("gameIconUnlit")] public string GameIconUnlit { get; set; }
        [BINValue("gameIconLit")] public string GameIconLit { get; set; }
        [BINValue("gameIconFull")] public string GameIconFull { get; set; }
        [BINValue("gameIconMini")] public string GameIconMini { get; set; }
        [BINValue(3915826324)] public ColorRGBAVector4Byte m3915826324 { get; set; }

        public StatStoneCategory()
        {

        }
    }
    public class Class_3158348420 : Class_389493299
    {
        [BINValue("mMultiplier")] public Class_3053458126 Multiplier { get; set; }
        [BINValue(3419063832)] public byte m3419063832 { get; set; }
        [BINValue(923208333)] public byte m923208333 { get; set; }
        [BINValue(1357989312)] public List<Class_3053458126> m1357989312 { get; set; }
        [BINValue("mDisplayAsPercent")] public bool DisplayAsPercent { get; set; }
        [BINValue(148143844)] public int m148143844 { get; set; }

        public Class_3158348420()
        {

        }
    }
    public class SpellRankUpRequirements
    {
        [BINValue("mRequirements")] public List<ISpellRankUpRequirement> Requirements { get; set; }

        public SpellRankUpRequirements()
        {

        }
    }
    public class SetVarInTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("value")] public IScriptValueGet Value { get; set; }
        [BINValue("Dest")] public ScriptTableSet Dest { get; set; }

        public SetVarInTableBlock()
        {

        }
    }
    public class TargeterDefinitionArc : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("startLocator")] public DrawablePositionLocator StartLocator { get; set; }
        [BINValue("endLocator")] public DrawablePositionLocator EndLocator { get; set; }
        [BINValue("isClockwiseArc")] public bool IsClockwiseArc { get; set; }
        [BINValue("isConstrainedToRange")] public bool IsConstrainedToRange { get; set; }
        [BINValue("constraintRange")] public FloatPerSpellLevel ConstraintRange { get; set; }
        [BINValue("overrideRadius")] public FloatPerSpellLevel OverrideRadius { get; set; }
        [BINValue("textureArcOverrideName")] public string TextureArcOverrideName { get; set; }
        [BINValue("thicknessOffset")] public float ThicknessOffset { get; set; }

        public TargeterDefinitionArc()
        {

        }
    }
    public class Class_3161555652 : Class_3813882857
    {
        [BINValue("mConditions")] public List<Class_1323437592> Conditions { get; set; }
        [BINValue("mDefaultVfxData")] public Class_922712184 DefaultVfxData { get; set; }

        public Class_3161555652()
        {

        }
    }
    public class GameplayConfig
    {
        [BINValue("mSpellPostponeTimeoutSec")] public float SpellPostponeTimeoutSec { get; set; }
        [BINValue("mAutoAttackMinPreCastLockoutDeltaTimeSec")] public float AutoAttackMinPreCastLockoutDeltaTimeSec { get; set; }
        [BINValue("mAutoAttackMinPostCastLockoutDeltaTimeSec")] public float AutoAttackMinPostCastLockoutDeltaTimeSec { get; set; }
        [BINValue("mLethalityPercentGivenAtLevel0")] public float LethalityPercentGivenAtLevel0 { get; set; }
        [BINValue("mLethalityScalesToLevel")] public int LethalityScalesToLevel { get; set; }
        [BINValue("mLethalityScalesCapsAtLevel")] public int LethalityScalesCapsAtLevel { get; set; }
        [BINValue("mLethalityRatioFromTarget")] public float LethalityRatioFromTarget { get; set; }
        [BINValue("mLethalityRatioFromAttacker")] public float LethalityRatioFromAttacker { get; set; }
        [BINValue("mCritTotalArmorPenPercent")] public float CritTotalArmorPenPercent { get; set; }
        [BINValue("mCritBonusArmorPenPercent")] public float CritBonusArmorPenPercent { get; set; }
        [BINValue("mCritGlobalDamageMultiplier")] public float CritGlobalDamageMultiplier { get; set; }
        [BINValue("mAdaptiveForceAbilityPowerScale")] public float AdaptiveForceAbilityPowerScale { get; set; }
        [BINValue("mAdaptiveForceAttackDamageScale")] public float AdaptiveForceAttackDamageScale { get; set; }
        [BINValue("mMinionDeathDelay")] public float MinionDeathDelay { get; set; }
        [BINValue("mMinionAutoLeeway")] public float MinionAutoLeeway { get; set; }
        [BINValue("mMinionAAHelperLimit")] public float MinionAAHelperLimit { get; set; }
        [BINValue("mItemSellQueueTime")] public float ItemSellQueueTime { get; set; }
        [BINValue("mCCScoreMultipliers")] public CCScoreMultipliers CCScoreMultipliers { get; set; }
        [BINValue("mPerSlotCDRIsAdditive")] public bool PerSlotCDRIsAdditive { get; set; }
        [BINValue("mSummonerSpells")] public List<Hash> SummonerSpells { get; set; }
        [BINValue("mLegacySummonerSpells")] public List<Hash> LegacySummonerSpells { get; set; }
        [BINValue(518544983)] public Class_389493299 m518544983 { get; set; }
        [BINValue(1627693693)] public Hash m1627693693 { get; set; }
        [BINValue(2789737202)] public Hash m2789737202 { get; set; }

        public GameplayConfig()
        {

        }
    }
    public class SubmeshVisibilityEventData : BaseEventData
    {
        [BINValue("mShowSubmeshList")] public List<Hash> ShowSubmeshList { get; set; }
        [BINValue("mHideSubmeshList")] public List<Hash> HideSubmeshList { get; set; }

        public SubmeshVisibilityEventData()
        {

        }
    }
    public interface BaseBlendData
    {
    }
    public class Class_3173404643
    {
        [BINValue(3042401727)] public Dictionary<string, Class_1461391717> m3042401727 { get; set; }
        [BINValue(2380000075)] public string m2380000075 { get; set; }
        [BINValue("icons")] public Dictionary<string, Class_3991255873> Icons { get; set; }

        public Class_3173404643()
        {

        }
    }
    public class CustomTargeterDefinitions
    {
        [BINValue("mTargeterDefinitions")] public List<TargeterDefinition> TargeterDefinitions { get; set; }

        public CustomTargeterDefinitions()
        {

        }
    }
    public class IsEnemyDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {

        public IsEnemyDynamicMaterialBoolDriver()
        {

        }
    }
    public class Class_3181780357 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }
        [BINValue("mSpellSlot")] public uint SpellSlot { get; set; }
        [BINValue("mSpellLevel")] public int SpellLevel { get; set; }

        public Class_3181780357()
        {

        }
    }
    public class FixedDistanceIgnoringTerrain : MissileBehaviorSpec
    {
        [BINValue("mMaximumDistance")] public float MaximumDistance { get; set; }
        [BINValue("mMinimumGapBetweenTerrainWalls")] public float MinimumGapBetweenTerrainWalls { get; set; }
        [BINValue("mMaximumTerrainWallsToSkip")] public Optional<uint> MaximumTerrainWallsToSkip { get; set; }
        [BINValue("scanWidthOverride")] public Optional<float> ScanWidthOverride { get; set; }
        [BINValue("mTargeterDefinition")] public TargeterDefinitionSkipTerrain TargeterDefinition { get; set; }

        public FixedDistanceIgnoringTerrain()
        {

        }
    }
    public class LoadScreenTipConfiguration
    {
        [BINValue("mShowInCustomGames")] public bool ShowInCustomGames { get; set; }
        [BINValue("mShowPBITipsOnLoadingScreen")] public bool ShowPBITipsOnLoadingScreen { get; set; }
        [BINValue("mPBITipDurationOnLoadingScreen")] public float PBITipDurationOnLoadingScreen { get; set; }
        [BINValue("mDurationInGame")] public float DurationInGame { get; set; }

        public LoadScreenTipConfiguration()
        {

        }
    }
    public class EffectCooldownElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mEffectColor0")] public ColorRGBAVector4Byte EffectColor0 { get; set; }
        [BINValue("mEffectColor1")] public ColorRGBAVector4Byte EffectColor1 { get; set; }

        public EffectCooldownElementData()
        {

        }
    }
    public class Class_3193188146 : GameModeConstant
    {
        [BINValue("mValue")] public List<string> Value { get; set; }

        public Class_3193188146()
        {

        }
    }
    public class Class_3193505140 : Class_1348413282
    {
        [BINValue(1990666961)] public float m1990666961 { get; set; }
        [BINValue(1696085056)] public float m1696085056 { get; set; }
        [BINValue("mStartAlpha")] public float StartAlpha { get; set; }
        [BINValue("mEndAlpha")] public float EndAlpha { get; set; }

        public Class_3193505140()
        {

        }
    }
    public class ScriptGlobalProperties
    {
        [BINValue("PersistsThroughDeath")] public bool PersistsThroughDeath { get; set; }
        [BINValue("NonDispellable")] public bool NonDispellable { get; set; }
        [BINValue("OnPreDamagePriority")] public int OnPreDamagePriority { get; set; }
        [BINValue("DeathEventType")] public uint DeathEventType { get; set; }
        [BINValue("CastTime")] public float CastTime { get; set; }
        [BINValue("ChannelDuration")] public float ChannelDuration { get; set; }
        [BINValue("buffName")] public string BuffName { get; set; }
        [BINValue("buffTextureName")] public string BuffTextureName { get; set; }
        [BINValue("displayName")] public string DisplayName { get; set; }
        [BINValue("AutoBuffActivateEffects")] public List<string> AutoBuffActivateEffects { get; set; }
        [BINValue("AutoBuffActivateAttachBoneNames")] public List<string> AutoBuffActivateAttachBoneNames { get; set; }
        [BINValue("IsDeathRecapSource")] public bool IsDeathRecapSource { get; set; }
        [BINValue("SpellToggleSlot")] public uint SpellToggleSlot { get; set; }
        [BINValue("IsItemToggled")] public bool IsItemToggled { get; set; }
        [BINValue("SpellFXOverrideSkins")] public List<string> SpellFXOverrideSkins { get; set; }
        [BINValue("SpellVOOverrideSkins")] public List<string> SpellVOOverrideSkins { get; set; }
        [BINValue("PopupMessages")] public List<string> PopupMessages { get; set; }

        public ScriptGlobalProperties()
        {

        }
    }
    public class Class_3196462184 : IStatStoneLogicDriver
    {
        [BINValue(340455258)] public ObjectTags m340455258 { get; set; }

        public Class_3196462184()
        {

        }
    }
    public interface Class_3196794540
    {
        [BINValue("mPerkId")] uint PerkId { get; set; }
        [BINValue("mPerkName")] string PerkName { get; set; }
        [BINValue("mDisplayNameLocalizationKey")] string DisplayNameLocalizationKey { get; set; }
        [BINValue("mTooltipNameLocalizationKey")] string TooltipNameLocalizationKey { get; set; }
        [BINValue("mPingTextLocalizationKey")] string PingTextLocalizationKey { get; set; }
        [BINValue("mShortDescLocalizationKey")] string ShortDescLocalizationKey { get; set; }
        [BINValue("mLongDescLocalizationKey")] string LongDescLocalizationKey { get; set; }
        [BINValue("mEndOfGameStatDescriptions")] List<string> EndOfGameStatDescriptions { get; set; }
        [BINValue("mDisplayStatLocalizationKey")] string DisplayStatLocalizationKey { get; set; }
        [BINValue("mIconTextureName")] string IconTextureName { get; set; }
        [BINValue("mEnabled")] bool Enabled { get; set; }
        [BINValue(3428652312)] bool m3428652312 { get; set; }
        [BINValue("mScript")] PerkScript Script { get; set; }
        [BINValue("mBuffs")] List<PerkBuff> Buffs { get; set; }
        [BINValue("mVFXResourceResolver")] ResourceResolver VFXResourceResolver { get; set; }
        [BINValue("mCharacters")] List<string> Characters { get; set; }
    }
    public interface BaseElementData
    {
        [BINValue("mName")] string Name { get; set; }
        [BINValue("mScene")] Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] bool Enabled { get; set; }
        [BINValue("mDraggable")] uint Draggable { get; set; }
        [BINValue("mLayer")] uint Layer { get; set; }
        [BINValue("mAnchorOptional")] Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] bool m629911194 { get; set; }
    }
    public class VfxEmissionSurfaceData
    {
        [BINValue("meshName")] public string MeshName { get; set; }
        [BINValue("skeletonName")] public string SkeletonName { get; set; }
        [BINValue("animationName")] public string AnimationName { get; set; }
        [BINValue("meshScale")] public float MeshScale { get; set; }
        [BINValue("maxJointWeights")] public ushort MaxJointWeights { get; set; }
        [BINValue("useAvatarPose")] public bool UseAvatarPose { get; set; }
        [BINValue("useSurfaceNormalForBirthPhysics")] public bool UseSurfaceNormalForBirthPhysics { get; set; }

        public VfxEmissionSurfaceData()
        {

        }
    }
    public class MissileSpecification
    {
        [BINValue("mMissileWidth")] public float MissileWidth { get; set; }
        [BINValue("movementComponent")] public MissileMovementSpec MovementComponent { get; set; }
        [BINValue("visibilityComponent")] public MissileVisibilitySpec VisibilityComponent { get; set; }
        [BINValue("heightSolver")] public HeightSolverType HeightSolver { get; set; }
        [BINValue("verticalFacing")] public VerticalFacingType VerticalFacing { get; set; }
        [BINValue("missileGroupSpawners")] public List<MissileGroupSpawnerSpec> MissileGroupSpawners { get; set; }
        [BINValue("behaviors")] public List<MissileBehaviorSpec> Behaviors { get; set; }

        public MissileSpecification()
        {

        }
    }
    public class ContextualConditionMapRegionName : IContextualCondition
    {
        [BINValue("mRegionType")] public byte RegionType { get; set; }
        [BINValue("mRegionName")] public string RegionName { get; set; }

        public ContextualConditionMapRegionName()
        {

        }
    }
    public class Class_3225152729
    {
        [BINValue("mInStore")] public bool InStore { get; set; }
        [BINValue(781700779)] public bool m781700779 { get; set; }
        [BINValue(1831013931)] public bool m1831013931 { get; set; }

        public Class_3225152729()
        {

        }
    }
    public class Class_3234822452
    {
        [BINValue("mStyleId")] public uint StyleId { get; set; }
        [BINValue("mPerks")] public List<Perk> Perks { get; set; }

        public Class_3234822452()
        {

        }
    }
    public class LockRootOrientationEventData : BaseEventData
    {

        public LockRootOrientationEventData()
        {

        }
    }
    public class Class_3241198053
    {
        [BINValue("mMinUnits")] public uint MinUnits { get; set; }
        [BINValue("mMaxUnits")] public Optional<uint> MaxUnits { get; set; }
        [BINValue(75743297)] public byte m75743297 { get; set; }
        [BINValue(2516677504)] public byte m2516677504 { get; set; }
        [BINValue("mBuffName")] public string BuffName { get; set; }
        [BINValue(1435427873)] public string m1435427873 { get; set; }
        [BINValue("effectAmounts")] public List<TftEffectAmount> EffectAmounts { get; set; }

        public Class_3241198053()
        {

        }
    }
    public class EvolutionDescription
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mTitle")] public string Title { get; set; }
        [BINValue("mTooltips")] public List<string> Tooltips { get; set; }
        [BINValue("mIconNames")] public List<string> IconNames { get; set; }

        public EvolutionDescription()
        {

        }
    }
    public interface IIntGet : IScriptValueGet
    {
    }
    public class Class_3258535250 : IStatStoneLogicDriver
    {
        [BINValue(3358576079)] public int m3358576079 { get; set; }

        public Class_3258535250()
        {

        }
    }
    public class EffectAmmoElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mEffectColor0")] public ColorRGBAVector4Byte EffectColor0 { get; set; }
        [BINValue("mEffectColor1")] public ColorRGBAVector4Byte EffectColor1 { get; set; }

        public EffectAmmoElementData()
        {

        }
    }
    public class HudMenuTransitionData
    {
        [BINValue("transitionTime")] public float TransitionTime { get; set; }
        [BINValue("minAlpha")] public byte MinAlpha { get; set; }
        [BINValue("maxAlpha")] public byte MaxAlpha { get; set; }

        public HudMenuTransitionData()
        {

        }
    }
    public interface IStatStoneLogicDriver
    {
    }
    public class Destroy : Class_1405067729
    {

        public Destroy()
        {

        }
    }
    public class Class_3303051661
    {
        [BINValue(2332216382)] public byte m2332216382 { get; set; }
        [BINValue(3397650234)] public bool m3397650234 { get; set; }
        [BINValue(2256949180)] public string m2256949180 { get; set; }
        [BINValue(1615112080)] public string m1615112080 { get; set; }

        public Class_3303051661()
        {

        }
    }
    public class Class_3305259773
    {
        [BINValue(2847772997)] public string m2847772997 { get; set; }
        [BINValue(404749450)] public string m404749450 { get; set; }
        [BINValue(2846050793)] public string m2846050793 { get; set; }
        [BINValue(3439137196)] public string m3439137196 { get; set; }

        public Class_3305259773()
        {

        }
    }
    public class AddGoldCheat : Cheat
    {
        [BINValue("mGoldAmount")] public float GoldAmount { get; set; }
        [BINValue("mTarget")] public uint Target { get; set; }

        public AddGoldCheat()
        {

        }
    }
    public class Class_3320474296
    {
        [BINValue(4024645677)] public List<Class_3773788067> m4024645677 { get; set; }

        public Class_3320474296()
        {

        }
    }
    public interface IScriptCondition
    {
    }
    public class ContextualConditionIsAlly : ICharacterSubcondition
    {
        [BINValue("mIsAlly")] public bool IsAlly { get; set; }

        public ContextualConditionIsAlly()
        {

        }
    }
    public class Class_3350243090
    {
        [BINValue(2584072672)] public List<RegaliaData> m2584072672 { get; set; }

        public Class_3350243090()
        {

        }
    }
    public class LoLFeatureToggles
    {
        [BINValue("NewSpellScript")] public bool NewSpellScript { get; set; }
        [BINValue("DisableAutoSNR")] public bool DisableAutoSNR { get; set; }
        [BINValue("DisableDDR")] public bool DisableDDR { get; set; }
        [BINValue("queuedOrdersTriggerPreIssueOrder")] public bool QueuedOrdersTriggerPreIssueOrder { get; set; }
        [BINValue("DisableRenderUIChatOSX")] public bool DisableRenderUIChatOSX { get; set; }
        [BINValue("DisableRenderUIChatWindows")] public bool DisableRenderUIChatWindows { get; set; }
        [BINValue("LimitedTournamentPause")] public bool LimitedTournamentPause { get; set; }
        [BINValue("DontRefCountTargetableAndInvulnerable")] public bool DontRefCountTargetableAndInvulnerable { get; set; }
        [BINValue("EnableCustomPlayerScoreColoring")] public bool EnableCustomPlayerScoreColoring { get; set; }
        [BINValue("closeOnEndGameAfterDelay")] public bool CloseOnEndGameAfterDelay { get; set; }
        [BINValue("PromoController")] public bool PromoController { get; set; }
        [BINValue("cooldownSpellQueueing")] public bool CooldownSpellQueueing { get; set; }
        [BINValue("challengerRecall")] public bool ChallengerRecall { get; set; }
        [BINValue("useNewAttackSpeed")] public bool UseNewAttackSpeed { get; set; }
        [BINValue("UseNewFireBBEvents")] public bool UseNewFireBBEvents { get; set; }
        [BINValue("abilityResetUI")] public bool AbilityResetUI { get; set; }
        [BINValue(676261369)] public bool m676261369 { get; set; }
        [BINValue(532488372)] public bool m532488372 { get; set; }
        [BINValue(2798407076)] public bool m2798407076 { get; set; }
        [BINValue(3700560752)] public bool m3700560752 { get; set; }
        [BINValue(1744584201)] public bool m1744584201 { get; set; }
        [BINValue(1497565684)] public bool m1497565684 { get; set; }
        [BINValue(538393296)] public bool m538393296 { get; set; }
        [BINValue(2742376623)] public bool m2742376623 { get; set; }
        [BINValue(2785021207)] public bool m2785021207 { get; set; }
        [BINValue(3981460857)] public bool m3981460857 { get; set; }
        [BINValue(2298093632)] public bool m2298093632 { get; set; }
        [BINValue(67818155)] public bool m67818155 { get; set; }
        [BINValue(1397095888)] public bool m1397095888 { get; set; }
        [BINValue(3338859248)] public bool m3338859248 { get; set; }
        [BINValue(1012039836)] public bool m1012039836 { get; set; }
        [BINValue(4189446832)] public bool m4189446832 { get; set; }
        [BINValue(3377925053)] public bool m3377925053 { get; set; }
        [BINValue(935881602)] public bool m935881602 { get; set; }
        [BINValue(4044511864)] public bool m4044511864 { get; set; }
        [BINValue(2344897987)] public bool m2344897987 { get; set; }
        [BINValue(2118095324)] public bool m2118095324 { get; set; }
        [BINValue(1922166460)] public bool m1922166460 { get; set; }
        [BINValue(187507855)] public bool m187507855 { get; set; }

        public LoLFeatureToggles()
        {

        }
    }
    public interface Class_3362386950 : MissileBehaviorSpec
    {
        [BINValue("mActions")] List<Class_1405067729> Actions { get; set; }
    }
    public class ContextualConditionCharacterSkinID : ICharacterSubcondition
    {
        [BINValue("mSkinIDs")] public List<int> SkinIDs { get; set; }

        public ContextualConditionCharacterSkinID()
        {

        }
    }
    public class OneTrueMaterialDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mDrivers")] public List<IDynamicMaterialBoolDriver> Drivers { get; set; }

        public OneTrueMaterialDriver()
        {

        }
    }
    public class Class_3365626407
    {
        [BINValue("mSceneTransition")] public HudMenuTransitionData SceneTransition { get; set; }

        public Class_3365626407()
        {

        }
    }
    public class ParametricPairData
    {
        [BINValue("mClipName")] public Hash ClipName { get; set; }
        [BINValue("mValue")] public float Value { get; set; }

        public ParametricPairData()
        {

        }
    }
    public class Class_3383798399 : IStatStoneLogicDriver
    {
        [BINValue(2915965837)] public byte m2915965837 { get; set; }

        public Class_3383798399()
        {

        }
    }
    public interface Class_3390937687
    {
        [BINValue("mPersistentVfxs")] List<Class_2338173165> PersistentVfxs { get; set; }
    }
    public class Class_3393100796
    {
        [BINValue("mSourceStatType")] public byte SourceStatType { get; set; }
        [BINValue("mSourceStatOutput")] public byte SourceStatOutput { get; set; }
        [BINValue(346472573)] public byte m346472573 { get; set; }
        [BINValue(205246452)] public byte m205246452 { get; set; }
        [BINValue(2452082244)] public float m2452082244 { get; set; }

        public Class_3393100796()
        {

        }
    }
    public interface IContextualCondition
    {
    }
    public class FixedTimeSplineMovement : GenericSplineMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mSplineInfo")] public ISplineInfo SplineInfo { get; set; }
        [BINValue("mUseMissilePositionAsOrigin")] public bool UseMissilePositionAsOrigin { get; set; }
        [BINValue("mTravelTime")] public float TravelTime { get; set; }

        public FixedTimeSplineMovement()
        {

        }
    }
    public class ContextualConditionCharacterInRangeForSyncedAnimation : ICharacterSubcondition
    {

        public ContextualConditionCharacterInRangeForSyncedAnimation()
        {

        }
    }
    public class VertexAnimationRigPoseModifierData : BaseRigPoseModifierData
    {
        [BINValue("mMaxSpeed")] public float MaxSpeed { get; set; }
        [BINValue("mStiffness")] public float Stiffness { get; set; }
        [BINValue("mMass")] public float Mass { get; set; }
        [BINValue("mDamping")] public float Damping { get; set; }

        public VertexAnimationRigPoseModifierData()
        {

        }
    }
    public class Class_3421140098 : Class_1936278667
    {
        [BINValue("mSceneName")] public string SceneName { get; set; }
        [BINValue(263459155)] public uint m263459155 { get; set; }
        [BINValue(1478759938)] public uint m1478759938 { get; set; }
        [BINValue(237959287)] public uint m237959287 { get; set; }
        [BINValue(2734588361)] public uint m2734588361 { get; set; }
        [BINValue(3859670210)] public uint m3859670210 { get; set; }

        public Class_3421140098()
        {

        }
    }
    public class DestroyCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableSet CustomTable { get; set; }

        public DestroyCustomTableBlock()
        {

        }
    }
    public class Class_3428313767 : ICharacterSubcondition
    {
        [BINValue(201153598)] public List<Hash> m201153598 { get; set; }

        public Class_3428313767()
        {

        }
    }
    public class InsertIntoCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableGet CustomTable { get; set; }
        [BINValue("Index")] public IIntGet Index { get; set; }
        [BINValue("value")] public IScriptValueGet Value { get; set; }
        [BINValue("OutIndex")] public IntTableSet OutIndex { get; set; }

        public InsertIntoCustomTableBlock()
        {

        }
    }
    public class ContextualConditionItemPriceMinimum : IContextualCondition
    {
        [BINValue("mItemPriceMinimum")] public uint ItemPriceMinimum { get; set; }

        public ContextualConditionItemPriceMinimum()
        {

        }
    }
    public class Class_3440733311 : Class_3052837161
    {
        [BINValue("mStat")] public byte Stat { get; set; }
        [BINValue(2100383980)] public byte m2100383980 { get; set; }
        [BINValue(483933259)] public Class_3053458126 m483933259 { get; set; }

        public Class_3440733311()
        {

        }
    }
    public class MapSkin
    {
        [BINValue("mMapContainerLink")] public string MapContainerLink { get; set; }
        [BINValue("mMinimapBackgroundConfig")] public MinimapBackgroundConfig MinimapBackgroundConfig { get; set; }
        [BINValue("mMapObjectsCFG")] public string MapObjectsCFG { get; set; }
        [BINValue("mMapObjectsMOB")] public string MapObjectsMOB { get; set; }
        [BINValue("mNavigationMesh")] public string NavigationMesh { get; set; }
        [BINValue(351620029)] public Link<GameModeConstants> m351620029 { get; set; }
        [BINValue("mWorldGeometry")] public string WorldGeometry { get; set; }
        [BINValue("mWorldParticlesINI")] public string WorldParticlesINI { get; set; }
        [BINValue("mWorldParticlesDAT")] public string WorldParticlesDAT { get; set; }
        [BINValue("mColorizationPostEffect")] public MapSkinColorizationPostEffect ColorizationPostEffect { get; set; }
        [BINValue("mGrassTintTexture")] public string GrassTintTexture { get; set; }
        [BINValue(2968063630)] public string m2968063630 { get; set; }
        [BINValue("mObjectSkinFallbacks")] public Dictionary<Hash, int> ObjectSkinFallbacks { get; set; }
        [BINValue("mResourceResolver")] public Link<ResourceResolver> ResourceResolver { get; set; }

        public MapSkin()
        {

        }
    }
    public class DamageSourceSettings
    {
        [BINValue("damageTagDefinition")] public List<string> DamageTagDefinition { get; set; }
        [BINValue("templateDefinition")] public List<DamageSourceTemplate> TemplateDefinition { get; set; }

        public DamageSourceSettings()
        {

        }
    }
    public class ScriptPreloadParticle
    {
        [BINValue("PreloadResourceName")] public string PreloadResourceName { get; set; }

        public ScriptPreloadParticle()
        {

        }
    }
    public class ContextualConditionLastBoughtItem : IContextualCondition
    {
        [BINValue("mItem")] public Hash Item { get; set; }

        public ContextualConditionLastBoughtItem()
        {

        }
    }
    public class DrawablePositionLocator
    {
        [BINValue("basePosition")] public uint BasePosition { get; set; }
        [BINValue("distanceOffset")] public float DistanceOffset { get; set; }
        [BINValue("angleOffsetRadian")] public float AngleOffsetRadian { get; set; }
        [BINValue("orientationType")] public uint OrientationType { get; set; }

        public DrawablePositionLocator()
        {

        }
    }
    public class CursorDataCaptureCooldownContext
    {
        [BINValue("mData")] public List<CursorData> Data { get; set; }

        public CursorDataCaptureCooldownContext()
        {

        }
    }
    public class ConformToPathRigPoseModifierData : BaseRigPoseModifierData
    {
        [BINValue("mStartingJointName")] public Hash StartingJointName { get; set; }
        [BINValue("mEndingJointName")] public Hash EndingJointName { get; set; }
        [BINValue("mDefaultMaskName")] public Hash DefaultMaskName { get; set; }
        [BINValue("mMaxBoneAngle")] public float MaxBoneAngle { get; set; }
        [BINValue("mDampingValue")] public float DampingValue { get; set; }
        [BINValue("mVelMultiplier")] public float VelMultiplier { get; set; }
        [BINValue("mFrequency")] public float Frequency { get; set; }

        public ConformToPathRigPoseModifierData()
        {

        }
    }
    public class AbilityResourceSlotInfo
    {
        [BINValue("arType")] public byte ArType { get; set; }
        [BINValue("arBase")] public float ArBase { get; set; }
        [BINValue("arPerLevel")] public float ArPerLevel { get; set; }
        [BINValue("arBaseStaticRegen")] public float ArBaseStaticRegen { get; set; }
        [BINValue("arBaseFactorRegen")] public float ArBaseFactorRegen { get; set; }
        [BINValue("arRegenPerLevel")] public float ArRegenPerLevel { get; set; }
        [BINValue("arIncrements")] public float ArIncrements { get; set; }
        [BINValue("arMaxSegments")] public int ArMaxSegments { get; set; }
        [BINValue("arHasRegenText")] public bool ArHasRegenText { get; set; }
        [BINValue("arAllowMaxValueToBeOverridden")] public bool ArAllowMaxValueToBeOverridden { get; set; }
        [BINValue("arContributesToHealthValues")] public bool ArContributesToHealthValues { get; set; }
        [BINValue("arPreventRegenWhileAtZero")] public bool ArPreventRegenWhileAtZero { get; set; }
        [BINValue("arDisplayAsPips")] public bool ArDisplayAsPips { get; set; }
        [BINValue("arIsShown")] public bool ArIsShown { get; set; }
        [BINValue("arIsShownOnlyOnLocalPlayer")] public bool ArIsShownOnlyOnLocalPlayer { get; set; }
        [BINValue("arOverrideSmallPipName")] public string ArOverrideSmallPipName { get; set; }
        [BINValue("arOverrideLargePipName")] public string ArOverrideLargePipName { get; set; }
        [BINValue("arOverrideEmptyPipName")] public string ArOverrideEmptyPipName { get; set; }
        [BINValue("arOverrideSpacerName")] public string ArOverrideSpacerName { get; set; }
        [BINValue("arNegativeSpacer")] public bool ArNegativeSpacer { get; set; }

        public AbilityResourceSlotInfo()
        {

        }
    }
    public interface Class_3460011047
    {
    }
    public class SwitchCase
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("Condition")] public IScriptCondition Condition { get; set; }
        [BINValue("Sequence")] public ScriptSequence Sequence { get; set; }

        public SwitchCase()
        {

        }
    }
    public class ContextualActionData : IResource
    {
        [BINValue("mCooldown")] public float Cooldown { get; set; }
        [BINValue("mSituations")] public Dictionary<Hash, ContextualSituation> Situations { get; set; }
        [BINValue("mObjectPath")] public string ObjectPath { get; set; }

        public ContextualActionData()
        {

        }
    }
    public class FloatGraphMaterialDriver : IDynamicMaterialDriver
    {
        [BINValue("driver")] public IDynamicMaterialFloatDriver Driver { get; set; }
        [BINValue("graph")] public VfxAnimatedFloatVariableData Graph { get; set; }

        public FloatGraphMaterialDriver()
        {

        }
    }
    public class TftItemData
    {
        [BINValue("mId")] public int Id { get; set; }
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mBuffName")] public string BuffName { get; set; }
        [BINValue(2340665994)] public List<TftItemData> m2340665994 { get; set; }
        [BINValue("effectAmounts")] public List<TftEffectAmount> EffectAmounts { get; set; }
        [BINValue(3272883558)] public string m3272883558 { get; set; }
        [BINValue(1985943770)] public string m1985943770 { get; set; }
        [BINValue("mIconPath")] public string IconPath { get; set; }
        [BINValue("mColor")] public Optional<ColorRGBAVector4Byte> Color { get; set; }
        [BINValue(2446810623)] public Vector2 m2446810623 { get; set; }
        [BINValue("mVfxSystem")] public Link<VfxSystemDefinitionData> VfxSystem { get; set; }

        public TftItemData()
        {

        }
    }
    public class IntegratedValueFloat : ValueFloat
    {

        public IntegratedValueFloat()
        {

        }
    }
    public class Defaultvisibility : MissileVisibilitySpec
    {
        [BINValue("mTargetControlsVisibility")] public bool TargetControlsVisibility { get; set; }
        [BINValue("mVisibleToOwnerTeamOnly")] public bool VisibleToOwnerTeamOnly { get; set; }
        [BINValue("mPerceptionBubbleRadius")] public float PerceptionBubbleRadius { get; set; }

        public Defaultvisibility()
        {

        }
    }
    public class AbilityResourceDynamicMaterialFloatDriver : IDynamicMaterialFloatDriver
    {
        [BINValue("slot")] public byte Slot { get; set; }

        public AbilityResourceDynamicMaterialFloatDriver()
        {

        }
    }
    public class HudElementalSectionUIData
    {
        [BINValue("airColoration")] public ColorRGBAVector4Byte AirColoration { get; set; }
        [BINValue("fireColoration")] public ColorRGBAVector4Byte FireColoration { get; set; }
        [BINValue("earthColoration")] public ColorRGBAVector4Byte EarthColoration { get; set; }
        [BINValue("waterColoration")] public ColorRGBAVector4Byte WaterColoration { get; set; }
        [BINValue("darkColoration")] public ColorRGBAVector4Byte DarkColoration { get; set; }
        [BINValue("fairyColoration")] public ColorRGBAVector4Byte FairyColoration { get; set; }
        [BINValue("iceColoration")] public ColorRGBAVector4Byte IceColoration { get; set; }
        [BINValue("lightColoration")] public ColorRGBAVector4Byte LightColoration { get; set; }
        [BINValue("magmaColoration")] public ColorRGBAVector4Byte MagmaColoration { get; set; }
        [BINValue("stormColoration")] public ColorRGBAVector4Byte StormColoration { get; set; }
        [BINValue("meterFilledButtonFadeInDelay")] public float MeterFilledButtonFadeInDelay { get; set; }
        [BINValue("firstSelectionAnimationDelay")] public float FirstSelectionAnimationDelay { get; set; }
        [BINValue("secondSelectionAnimationDelay")] public float SecondSelectionAnimationDelay { get; set; }
        [BINValue("glowingRingCycleTime")] public float GlowingRingCycleTime { get; set; }

        public HudElementalSectionUIData()
        {

        }
    }
    public class MapTerrainPaint : Class_66354938
    {
        [BINValue(3270086406)] public string m3270086406 { get; set; }

        public MapTerrainPaint()
        {

        }
    }
    public class HudGameModeScoreData
    {
        [BINValue("mTeamScoreElementTypes")] public List<byte> TeamScoreElementTypes { get; set; }
        [BINValue("mIndividualScoreElementTypes")] public List<byte> IndividualScoreElementTypes { get; set; }
        [BINValue("mModeKeyName")] public string ModeKeyName { get; set; }
        [BINValue("mTeamGameScorePingMessage")] public string TeamGameScorePingMessage { get; set; }
        [BINValue(2321304744)] public Class_4180972365 m2321304744 { get; set; }
        [BINValue(527990547)] public Class_60771964 m527990547 { get; set; }
        [BINValue(618622443)] public Class_3784622423 m618622443 { get; set; }
        [BINValue(2770289004)] public Class_3365626407 m2770289004 { get; set; }
        [BINValue(936257914)] public List<Class_3920544379> m936257914 { get; set; }

        public HudGameModeScoreData()
        {

        }
    }
    public interface IScriptPreload
    {
    }
    public class Class_3562978890
    {
        [BINValue("mBuff")] public Link<SpellObject> Buff { get; set; }
        [BINValue(2257773130)] public uint m2257773130 { get; set; }
        [BINValue(1991670732)] public bool m1991670732 { get; set; }
        [BINValue(3420404466)] public bool m3420404466 { get; set; }
        [BINValue(933770753)] public byte m933770753 { get; set; }

        public Class_3562978890()
        {

        }
    }
    public class Class_3563037474 : Class_1405067729
    {
        [BINValue("mPreserveSpeed")] public bool PreserveSpeed { get; set; }
        [BINValue("mOverrideSpec")] public MissileMovementSpec OverrideSpec { get; set; }

        public Class_3563037474()
        {

        }
    }
    public class BannerFrameData
    {
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }

        public BannerFrameData()
        {

        }
    }
    public class FloatTableSet : ScriptTableSet
    {

        public FloatTableSet()
        {

        }
    }
    public class Class_3575093694 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }

        public Class_3575093694()
        {

        }
    }
    public class StringTableSet : ScriptTableSet
    {

        public StringTableSet()
        {

        }
    }
    public class NotMaterialDriver : IDynamicMaterialBoolDriver
    {
        [BINValue("mDriver")] public IDynamicMaterialBoolDriver Driver { get; set; }

        public NotMaterialDriver()
        {

        }
    }
    public class MaxAllSkillsCheat : Cheat
    {
        [BINValue("mOnlyOnePointEach")] public bool OnlyOnePointEach { get; set; }
        [BINValue("mTarget")] public uint Target { get; set; }

        public MaxAllSkillsCheat()
        {

        }
    }
    public class HudPingData
    {
        [BINValue("distanceToNotTrollPingCorpses")] public float DistanceToNotTrollPingCorpses { get; set; }
        [BINValue("timeToNotTrollPingCorpses")] public float TimeToNotTrollPingCorpses { get; set; }

        public HudPingData()
        {

        }
    }
    public class HealthDynamicMaterialFloatDriver : IDynamicMaterialFloatDriver
    {

        public HealthDynamicMaterialFloatDriver()
        {

        }
    }
    public class ChangeMissileSpeed : Class_1405067729
    {
        [BINValue("mSpeedChangeType")] public uint SpeedChangeType { get; set; }
        [BINValue("mSpeedValue")] public float SpeedValue { get; set; }

        public ChangeMissileSpeed()
        {

        }
    }
    public class VfxMaterialOverrideDefinitionData
    {
        [BINValue("priority")] public int Priority { get; set; }
        [BINValue("subMeshName")] public Optional<string> SubMeshName { get; set; }
        [BINValue("overrideBlendMode")] public uint OverrideBlendMode { get; set; }
        [BINValue("baseTexture")] public string BaseTexture { get; set; }
        [BINValue("glossTexture")] public string GlossTexture { get; set; }
        [BINValue("transitionTexture")] public string TransitionTexture { get; set; }
        [BINValue("transitionSample")] public float TransitionSample { get; set; }
        [BINValue("transitionSource")] public uint TransitionSource { get; set; }
        [BINValue("material")] public Link<IMaterialDef> Material { get; set; }

        public VfxMaterialOverrideDefinitionData()
        {

        }
    }
    public class CastOnHit : MissileBehaviorSpec
    {

        public CastOnHit()
        {

        }
    }
    public class ResetGoldCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }

        public ResetGoldCheat()
        {

        }
    }
    public class Class_3663270019 : IStatStoneLogicDriver
    {
        [BINValue(3770038919)] public bool m3770038919 { get; set; }
        [BINValue(1776971179)] public bool m1776971179 { get; set; }
        [BINValue(1683726967)] public bool m1683726967 { get; set; }

        public Class_3663270019()
        {

        }
    }
    public interface IDynamicMaterialBoolDriver : IDynamicMaterialFloatDriver
    {
    }
    public class Class_3666540112 : Class_1936278667
    {
        [BINValue("mSceneName")] public string SceneName { get; set; }
        [BINValue(4101352720)] public Class_1376467180 m4101352720 { get; set; }

        public Class_3666540112()
        {

        }
    }
    public class GdsMapObject : GenericMapPlaceable
    {
        [BINValue("type")] public byte Type { get; set; }
        [BINValue("ignoreCollisionOnPlacement")] public bool IgnoreCollisionOnPlacement { get; set; }
        [BINValue("eyeCandy")] public bool EyeCandy { get; set; }
        [BINValue("boxMin")] public Vector3 BoxMin { get; set; }
        [BINValue("boxMax")] public Vector3 BoxMax { get; set; }
        [BINValue("mapObjectSkinID")] public uint MapObjectSkinID { get; set; }
        [BINValue("extraInfo")] public List<GDSMapObjectExtraInfo> ExtraInfo { get; set; }

        public GdsMapObject()
        {

        }
    }
    public interface IVectorGet : IScriptValueGet
    {
    }
    public class Class_3686997399
    {
        [BINValue("mBuffs")] public List<HasBuffData> Buffs { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public Class_3686997399()
        {

        }
    }
    public class StringGet : IStringGet
    {
        [BINValue("value")] public string Value { get; set; }

        public StringGet()
        {

        }
    }
    public class ScriptCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue(3952419188)] public Hash m3952419188 { get; set; }

        public ScriptCheat()
        {

        }
    }
    public class AbilityObject
    {
        [BINValue("mRootSpell")] public Link<SpellObject> RootSpell { get; set; }
        [BINValue("mChildSpells")] public List<SpellObject> ChildSpells { get; set; }
        [BINValue(2262674907)] public bool m2262674907 { get; set; }
        [BINValue("mName")] public string Name { get; set; }

        public AbilityObject()
        {

        }
    }
    public class MissileAttachedTargetingDefinition
    {
        [BINValue("mEndPositionType")] public byte EndPositionType { get; set; }
        [BINValue("mLineTextureName")] public string LineTextureName { get; set; }
        [BINValue("mLineTextureWidth")] public float LineTextureWidth { get; set; }
        [BINValue("mLineEndTextureName")] public string LineEndTextureName { get; set; }
        [BINValue("mLineEndTextureWidth")] public float LineEndTextureWidth { get; set; }
        [BINValue("mLineEndTextureHeight")] public float LineEndTextureHeight { get; set; }

        public MissileAttachedTargetingDefinition()
        {

        }
    }
    public class Class_3701691417 : Class_66354938
    {
        [BINValue(4002480509)] public float m4002480509 { get; set; }
        [BINValue(3373705724)] public float m3373705724 { get; set; }

        public Class_3701691417()
        {

        }
    }
    public class HudReplaySliderIconData
    {
        [BINValue("mType")] public Hash Type { get; set; }
        [BINValue("mTooltipStyle")] public byte TooltipStyle { get; set; }
        [BINValue("mElementName")] public string ElementName { get; set; }
        [BINValue("mElementSpacer")] public float ElementSpacer { get; set; }
        [BINValue("mElementAlphaDefault")] public float ElementAlphaDefault { get; set; }
        [BINValue("mElementAlphaSelected")] public float ElementAlphaSelected { get; set; }
        [BINValue("mElementAlphaUnselected")] public float ElementAlphaUnselected { get; set; }
        [BINValue("mTooltipIconNames")] public List<string> TooltipIconNames { get; set; }

        public HudReplaySliderIconData()
        {

        }
    }
    public class Class_3706207649 : Class_3390937687
    {
        [BINValue("mPersistentVfxs")] public List<Class_2338173165> PersistentVfxs { get; set; }

        public Class_3706207649()
        {

        }
    }
    public class EffectCircleMaskDesaturateElementData : EffectDesaturateElementData
    {

        public EffectCircleMaskDesaturateElementData()
        {

        }
    }
    public class Cone : Class_2144288560
    {

        public Cone()
        {

        }
    }
    public class LoLSpellPreloadData
    {
        [BINValue("CharacterPreloads")] public List<ScriptPreloadCharacter> CharacterPreloads { get; set; }
        [BINValue("SpellPreloads")] public List<ScriptPreloadSpell> SpellPreloads { get; set; }
        [BINValue("ModulePreloads")] public List<ScriptPreloadModule> ModulePreloads { get; set; }
        [BINValue("ParticlePreloads")] public List<ScriptPreloadParticle> ParticlePreloads { get; set; }

        public LoLSpellPreloadData()
        {

        }
    }
    public interface VfxPrimitiveBeamBase : VfxPrimitiveBase
    {
        [BINValue("mBeam")] VfxBeamDefinitionData Beam { get; set; }
    }
    public class Class_3716126038 : BaseElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mVfxSystem")] public Link<VfxSystemDefinitionData> VfxSystem { get; set; }
        [BINValue(3296523975)] public uint m3296523975 { get; set; }
        [BINValue(42091584)] public bool m42091584 { get; set; }

        public Class_3716126038()
        {

        }
    }
    public class Class_3719146242
    {
        [BINValue(1597452091)] public long m1597452091 { get; set; }
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }

        public Class_3719146242()
        {

        }
    }
    public class MapContainer
    {
        [BINValue("mapPath")] public string MapPath { get; set; }
        [BINValue("components")] public List<MapComponent> Components { get; set; }
        [BINValue("boundsMin")] public Vector2 BoundsMin { get; set; }
        [BINValue("boundsMax")] public Vector2 BoundsMax { get; set; }
        [BINValue("lowestWalkableHeight")] public float LowestWalkableHeight { get; set; }
        [BINValue(1577983395)] public Dictionary<Hash, Link<Class_2992376383>> m1577983395 { get; set; }

        public MapContainer()
        {

        }
    }
    public interface ICharacterSubcondition
    {
    }
    public class Class_3727041878 : IDynamicMaterialBoolDriver
    {

        public Class_3727041878()
        {

        }
    }
    public class StaticMaterialShaderParamDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("value")] public Vector4 Value { get; set; }

        public StaticMaterialShaderParamDef()
        {

        }
    }
    public class ContextualConditionTeammateDeathsNearby : IContextualCondition
    {
        [BINValue("mTeammateDeaths")] public uint TeammateDeaths { get; set; }

        public ContextualConditionTeammateDeathsNearby()
        {

        }
    }
    public class MinimapIconTextureData
    {
        [BINValue("mBase")] public string Base { get; set; }
        [BINValue("mColorblind")] public Optional<string> Colorblind { get; set; }

        public MinimapIconTextureData()
        {

        }
    }
    public class ContextualConditionCharacterName : ICharacterSubcondition
    {
        [BINValue("mCharacters")] public List<Hash> Characters { get; set; }

        public ContextualConditionCharacterName()
        {

        }
    }
    public class IsSpecifiedUnitCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mUnit")] public Hash Unit { get; set; }

        public IsSpecifiedUnitCastRequirement()
        {

        }
    }
    public class ToggleInvulnerableCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }

        public ToggleInvulnerableCheat()
        {

        }
    }
    public class Direction : Class_2144288560
    {

        public Direction()
        {

        }
    }
    public class Map : WadFileDescriptor
    {
        [BINValue("mapStringId")] public string MapStringId { get; set; }
        [BINValue("BasedOnMap")] public Link<Map> BasedOnMap { get; set; }
        [BINValue("characterLists")] public List<MapCharacterList> CharacterLists { get; set; }
        [BINValue(2650904341)] public Class_1484706743 m2650904341 { get; set; }
        [BINValue(1830007018)] public Class_3880372342 m1830007018 { get; set; }

        public Map()
        {

        }
    }
    public class CameraConfig
    {
        [BINValue(108120199)] public Class_1207715590 m108120199 { get; set; }
        [BINValue("mAccelerationTimeMouse")] public float AccelerationTimeMouse { get; set; }
        [BINValue("mDecelerationTimeMouse")] public float DecelerationTimeMouse { get; set; }
        [BINValue("mAccelerationTimeKeyboard")] public float AccelerationTimeKeyboard { get; set; }
        [BINValue("mDecelerationTimeKeyboard")] public float DecelerationTimeKeyboard { get; set; }
        [BINValue("mTopdownZoom")] public float TopdownZoom { get; set; }
        [BINValue("mZoomMinDistance")] public float ZoomMinDistance { get; set; }
        [BINValue("mZoomMaxDistance")] public float ZoomMaxDistance { get; set; }
        [BINValue("mZoomEaseTime")] public float ZoomEaseTime { get; set; }
        [BINValue("mZoomMinSpeed")] public float ZoomMinSpeed { get; set; }
        [BINValue("mDragScale")] public float DragScale { get; set; }
        [BINValue("mDragMomentumDecay")] public float DragMomentumDecay { get; set; }
        [BINValue("mDragMomentumRecencyWeight")] public float DragMomentumRecencyWeight { get; set; }
        [BINValue("mLockedCameraEasingDistance")] public float LockedCameraEasingDistance { get; set; }
        [BINValue("mTransitionDurationIntoCinematicMode")] public float TransitionDurationIntoCinematicMode { get; set; }
        [BINValue(1909011002)] public Class_1207715590 m1909011002 { get; set; }
        [BINValue(4150359381)] public Class_1207715590 m4150359381 { get; set; }
        [BINValue(943673768)] public float m943673768 { get; set; }

        public CameraConfig()
        {

        }
    }
    public class Class_3773788067
    {
        [BINValue(3379329704)] public string m3379329704 { get; set; }
        [BINValue(3440598955)] public Class_2722078078 m3440598955 { get; set; }

        public Class_3773788067()
        {

        }
    }
    public class Class_3784622423
    {
        [BINValue("mSceneTransition")] public HudMenuTransitionData SceneTransition { get; set; }
        [BINValue(529870772)] public uint m529870772 { get; set; }
        [BINValue(2808220806)] public Class_4224366477 m2808220806 { get; set; }

        public Class_3784622423()
        {

        }
    }
    public class TargeterDefinitionAoe : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("centerLocator")] public DrawablePositionLocator CenterLocator { get; set; }
        [BINValue("textureOrientation")] public uint TextureOrientation { get; set; }
        [BINValue("isConstrainedToRange")] public bool IsConstrainedToRange { get; set; }
        [BINValue("constraintPosLocator")] public DrawablePositionLocator ConstraintPosLocator { get; set; }
        [BINValue("constraintRange")] public FloatPerSpellLevel ConstraintRange { get; set; }
        [BINValue("overrideRadius")] public FloatPerSpellLevel OverrideRadius { get; set; }
        [BINValue("textureRadiusOverrideName")] public string TextureRadiusOverrideName { get; set; }

        public TargeterDefinitionAoe()
        {

        }
    }
    public interface VfxPrimitiveBase
    {
    }
    public class Class_3808259511
    {
        [BINValue("teamId")] public uint TeamId { get; set; }
        [BINValue("shortName")] public string ShortName { get; set; }
        [BINValue("fullName")] public string FullName { get; set; }
        [BINValue("leagueName")] public string LeagueName { get; set; }

        public Class_3808259511()
        {

        }
    }
    public class GameFontDescription
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("typeData")] public Link<FontType> TypeData { get; set; }
        [BINValue("resolutionData")] public Link<FontResolutionData> ResolutionData { get; set; }
        [BINValue("color")] public ColorRGBAVector4Byte Color { get; set; }
        [BINValue("outlineColor")] public ColorRGBAVector4Byte OutlineColor { get; set; }
        [BINValue("shadowColor")] public ColorRGBAVector4Byte ShadowColor { get; set; }
        [BINValue("glowColor")] public ColorRGBAVector4Byte GlowColor { get; set; }
        [BINValue("colorblindColor")] public Optional<ColorRGBAVector4Byte> ColorblindColor { get; set; }
        [BINValue("colorblindOutlineColor")] public Optional<ColorRGBAVector4Byte> ColorblindOutlineColor { get; set; }
        [BINValue("colorblindShadowColor")] public Optional<ColorRGBAVector4Byte> ColorblindShadowColor { get; set; }
        [BINValue("colorblindGlowColor")] public Optional<ColorRGBAVector4Byte> ColorblindGlowColor { get; set; }
        [BINValue("fillTextureName")] public string FillTextureName { get; set; }

        public GameFontDescription()
        {

        }
    }
    public interface Class_3813882857
    {
    }
    public class MinimapPingTypeContainer
    {
        [BINValue("pingEffectList")] public List<MinimapPingEffectAndTextureData> PingEffectList { get; set; }

        public MinimapPingTypeContainer()
        {

        }
    }
    public class Class_3828118224
    {
        [BINValue("base")] public Link<RegaliaData> Base { get; set; }
        [BINValue(4222747664)] public Dictionary<int, Link<RegaliaData>> m4222747664 { get; set; }
        [BINValue(2939033354)] public Dictionary<int, Link<RegaliaData>> m2939033354 { get; set; }

        public Class_3828118224()
        {

        }
    }
    public class SwitchScriptBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("Cases")] public List<SwitchCase> Cases { get; set; }

        public SwitchScriptBlock()
        {

        }
    }
    public class ContextualConditionItemVOGroup : IContextualCondition
    {
        [BINValue("mItemVOGroupHash")] public Hash ItemVOGroupHash { get; set; }

        public ContextualConditionItemVOGroup()
        {

        }
    }
    public interface VfxPrimitiveProjectionBase : VfxPrimitiveBase
    {
        [BINValue("mProjection")] VfxProjectionDefinitionData Projection { get; set; }
    }
    public class HasBuffData
    {
        [BINValue("mBuffName")] public string BuffName { get; set; }
        [BINValue("mFromAnyone")] public bool FromAnyone { get; set; }
        [BINValue("mFromOwner")] public bool FromOwner { get; set; }
        [BINValue(3118580291)] public bool m3118580291 { get; set; }

        public HasBuffData()
        {

        }
    }
    public class AbilityResourceStateColorOptions
    {
        [BINValue("color")] public ColorRGBAVector4Byte Color { get; set; }
        [BINValue("fadeColor")] public ColorRGBAVector4Byte FadeColor { get; set; }

        public AbilityResourceStateColorOptions()
        {

        }
    }
    public class Class_3843873303 : Class_1405067729
    {
        [BINValue(1145244202)] public Optional<float> m1145244202 { get; set; }
        [BINValue(3941935197)] public Optional<float> m3941935197 { get; set; }
        [BINValue("mOverrideMovement")] public MissileMovementSpec OverrideMovement { get; set; }

        public Class_3843873303()
        {

        }
    }
    public class TftShopData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mRarity")] public byte Rarity { get; set; }
        [BINValue("mPortraitIconPath")] public string PortraitIconPath { get; set; }
        [BINValue("mIconPath")] public string IconPath { get; set; }
        [BINValue(3272883558)] public string m3272883558 { get; set; }
        [BINValue(2275842654)] public string m2275842654 { get; set; }
        [BINValue(3159300275)] public string m3159300275 { get; set; }

        public TftShopData()
        {

        }
    }
    public class Class_3854974626
    {
        [BINValue(2407574701)] public HudMenuTransitionData m2407574701 { get; set; }
        [BINValue(3756733196)] public float m3756733196 { get; set; }

        public Class_3854974626()
        {

        }
    }
    public class Class_3867527440 : IContextualCondition
    {
        [BINValue(2150865547)] public Hash m2150865547 { get; set; }
        [BINValue("mTime")] public float Time { get; set; }

        public Class_3867527440()
        {

        }
    }
    public class Class_3880372342
    {
        [BINValue(1884225360)] public Dictionary<string, Link<Class_953399041>> m1884225360 { get; set; }

        public Class_3880372342()
        {

        }
    }
    public class VfxFieldDragDefinitionData
    {
        [BINValue("position")] public ValueVector3 Position { get; set; }
        [BINValue("radius")] public ValueFloat Radius { get; set; }
        [BINValue("strength")] public ValueFloat Strength { get; set; }

        public VfxFieldDragDefinitionData()
        {

        }
    }
    public class UnitStatusPriorityList
    {
        [BINValue("mMinimumDisplayTime")] public float MinimumDisplayTime { get; set; }
        [BINValue("mPrioritizedUnitStatusData")] public List<UnitStatusData> PrioritizedUnitStatusData { get; set; }

        public UnitStatusPriorityList()
        {

        }
    }
    public class DamageSourceTemplate
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("DamageProperties")] public uint DamageProperties { get; set; }
        [BINValue("DamageTags")] public List<string> DamageTags { get; set; }

        public DamageSourceTemplate()
        {

        }
    }
    public interface VerticalFacingType
    {
    }
    public class HudColorData
    {
        [BINValue("mSelfColor")] public ColorRGBAVector4Byte SelfColor { get; set; }
        [BINValue("mFriendlyColor")] public ColorRGBAVector4Byte FriendlyColor { get; set; }
        [BINValue("mEnemyColor")] public ColorRGBAVector4Byte EnemyColor { get; set; }
        [BINValue("mNeutralColor")] public ColorRGBAVector4Byte NeutralColor { get; set; }
        [BINValue("mOrderColor")] public ColorRGBAVector4Byte OrderColor { get; set; }
        [BINValue("mChaosColor")] public ColorRGBAVector4Byte ChaosColor { get; set; }
        [BINValue("mJunglePlantColor")] public ColorRGBAVector4Byte JunglePlantColor { get; set; }
        [BINValue("mFriendlyLaneMinionBarColor")] public ColorRGBAVector4Byte FriendlyLaneMinionBarColor { get; set; }
        [BINValue("mEnemyLaneMinionBarColor")] public ColorRGBAVector4Byte EnemyLaneMinionBarColor { get; set; }
        [BINValue("mDeathFriendlyTeamColor")] public ColorRGBAVector4Byte DeathFriendlyTeamColor { get; set; }
        [BINValue("mDeathEnemyTeamColor")] public ColorRGBAVector4Byte DeathEnemyTeamColor { get; set; }
        [BINValue("mDeathOrderColor")] public ColorRGBAVector4Byte DeathOrderColor { get; set; }
        [BINValue("mDeathChaosColor")] public ColorRGBAVector4Byte DeathChaosColor { get; set; }
        [BINValue("mInputChatColor")] public ColorRGBAVector4Byte InputChatColor { get; set; }
        [BINValue("mShadowChatColor")] public ColorRGBAVector4Byte ShadowChatColor { get; set; }
        [BINValue("mFriendlyChatColor")] public ColorRGBAVector4Byte FriendlyChatColor { get; set; }
        [BINValue("mAllChatColor")] public ColorRGBAVector4Byte AllChatColor { get; set; }
        [BINValue("mEnemyChatColor")] public ColorRGBAVector4Byte EnemyChatColor { get; set; }
        [BINValue("mNeutralChatColor")] public ColorRGBAVector4Byte NeutralChatColor { get; set; }
        [BINValue("mPingChatColor")] public ColorRGBAVector4Byte PingChatColor { get; set; }
        [BINValue("mTeamChatColor")] public ColorRGBAVector4Byte TeamChatColor { get; set; }
        [BINValue("mNetworkChatColor")] public ColorRGBAVector4Byte NetworkChatColor { get; set; }
        [BINValue("mOrderChatColor")] public ColorRGBAVector4Byte OrderChatColor { get; set; }
        [BINValue("mChaosChatColor")] public ColorRGBAVector4Byte ChaosChatColor { get; set; }
        [BINValue("mGoldChatColor")] public ColorRGBAVector4Byte GoldChatColor { get; set; }
        [BINValue("mTimestampChatColor")] public ColorRGBAVector4Byte TimestampChatColor { get; set; }
        [BINValue("mWhisperColor")] public ColorRGBAVector4Byte WhisperColor { get; set; }
        [BINValue("mPartyChatColor")] public ColorRGBAVector4Byte PartyChatColor { get; set; }
        [BINValue("mPlatformChatColor")] public ColorRGBAVector4Byte PlatformChatColor { get; set; }
        [BINValue("mFeedbackChatColor")] public ColorRGBAVector4Byte FeedbackChatColor { get; set; }
        [BINValue("mItemCalloutBodyColor")] public ColorRGBAVector4Byte ItemCalloutBodyColor { get; set; }
        [BINValue("mItemCalloutItemColor")] public ColorRGBAVector4Byte ItemCalloutItemColor { get; set; }
        [BINValue("mMarkedIndicatorColor")] public ColorRGBAVector4Byte MarkedIndicatorColor { get; set; }
        [BINValue("mSelectedIndicatorColor")] public ColorRGBAVector4Byte SelectedIndicatorColor { get; set; }
        [BINValue("mItemHotKeyEnabledColor")] public ColorRGBAVector4Byte ItemHotKeyEnabledColor { get; set; }
        [BINValue("mItemHotKeyDisabledColor")] public ColorRGBAVector4Byte ItemHotKeyDisabledColor { get; set; }
        [BINValue("mSpellHotKeyEnabledColor")] public ColorRGBAVector4Byte SpellHotKeyEnabledColor { get; set; }
        [BINValue("mSpellHotKeyDisabledColor")] public ColorRGBAVector4Byte SpellHotKeyDisabledColor { get; set; }
        [BINValue("mStatNormalColor")] public ColorRGBAVector4Byte StatNormalColor { get; set; }
        [BINValue("mStatBoostedColor")] public ColorRGBAVector4Byte StatBoostedColor { get; set; }
        [BINValue("mLevelUpColor")] public ColorRGBAVector4Byte LevelUpColor { get; set; }
        [BINValue("mEvolutionColor")] public ColorRGBAVector4Byte EvolutionColor { get; set; }
        [BINValue("mSummonerNameDeadColor")] public ColorRGBAVector4Byte SummonerNameDeadColor { get; set; }
        [BINValue("mSummonerNameDefaultColor")] public ColorRGBAVector4Byte SummonerNameDefaultColor { get; set; }
        [BINValue("mSummonerNameSelfColor")] public ColorRGBAVector4Byte SummonerNameSelfColor { get; set; }
        [BINValue("mClubTagFriendlyChatColor")] public ColorRGBAVector4Byte ClubTagFriendlyChatColor { get; set; }
        [BINValue("mClubTagEnemyChatColor")] public ColorRGBAVector4Byte ClubTagEnemyChatColor { get; set; }
        [BINValue("mClubTagNeutralChatColor")] public ColorRGBAVector4Byte ClubTagNeutralChatColor { get; set; }
        [BINValue("mClubTagOrderChatColor")] public ColorRGBAVector4Byte ClubTagOrderChatColor { get; set; }
        [BINValue("mClubTagChaosChatColor")] public ColorRGBAVector4Byte ClubTagChaosChatColor { get; set; }
        [BINValue("mVoiceChatDefaultTextColor")] public ColorRGBAVector4Byte VoiceChatDefaultTextColor { get; set; }
        [BINValue("mVoiceChatHoverTextColor")] public ColorRGBAVector4Byte VoiceChatHoverTextColor { get; set; }
        [BINValue("mVoiceChatHaloTextureColor")] public ColorRGBAVector4Byte VoiceChatHaloTextureColor { get; set; }
        [BINValue(63589972)] public ColorRGBAVector4Byte m63589972 { get; set; }
        [BINValue(3755603872)] public ColorRGBAVector4Byte m3755603872 { get; set; }
        [BINValue(3591678551)] public ColorRGBAVector4Byte m3591678551 { get; set; }
        [BINValue(1139757985)] public ColorRGBAVector4Byte m1139757985 { get; set; }
        [BINValue(1371618007)] public ColorRGBAVector4Byte m1371618007 { get; set; }
        [BINValue(3154015837)] public ColorRGBAVector4Byte m3154015837 { get; set; }

        public HudColorData()
        {

        }
    }
    public interface IResourceResolver
    {
    }
    public interface ClipBaseData
    {
        [BINValue("mFlags")] uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] List<Hash> AnimationInterruptionGroupNames { get; set; }
    }
    public class VfxPrimitivePlanarProjection : VfxPrimitiveProjectionBase
    {
        [BINValue("mProjection")] public VfxProjectionDefinitionData Projection { get; set; }

        public VfxPrimitivePlanarProjection()
        {

        }
    }
    public class FontLocaleResolutions
    {
        [BINValue("localeName")] public string LocaleName { get; set; }
        [BINValue("resolutions")] public List<FontResolution> Resolutions { get; set; }

        public FontLocaleResolutions()
        {

        }
    }
    public class CurveTheDifferenceHeightSolver : HeightSolverType
    {
        [BINValue("mInitialTargetHeightOffset")] public float InitialTargetHeightOffset { get; set; }

        public CurveTheDifferenceHeightSolver()
        {

        }
    }
    public class Class_3920544379
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mPriority")] public uint Priority { get; set; }

        public Class_3920544379()
        {

        }
    }
    public class Class_3922646404 : Class_389493299
    {
        [BINValue("mMultiplier")] public Class_3053458126 Multiplier { get; set; }
        [BINValue(3419063832)] public byte m3419063832 { get; set; }
        [BINValue(923208333)] public byte m923208333 { get; set; }
        [BINValue(18101940)] public Hash m18101940 { get; set; }
        [BINValue(7331431)] public Hash m7331431 { get; set; }
        [BINValue(3225953125)] public ICastRequirement m3225953125 { get; set; }

        public Class_3922646404()
        {

        }
    }
    public class LoadoutFeatureData
    {
        [BINValue("mFeature")] public uint Feature { get; set; }
        [BINValue("mMutator")] public Optional<string> Mutator { get; set; }
        [BINValue("mBinaryFile")] public Optional<string> BinaryFile { get; set; }
        [BINValue("mDefaultTftCompanion")] public Hash DefaultTftCompanion { get; set; }
        [BINValue("mLoadoutCategory")] public string LoadoutCategory { get; set; }
        [BINValue("mLoadoutProperties")] public List<string> LoadoutProperties { get; set; }
        [BINValue("mGDSObjectPathTemplates")] public Dictionary<string, string> GDSObjectPathTemplates { get; set; }
        [BINValue("mLoadFromContentIds")] public bool LoadFromContentIds { get; set; }

        public LoadoutFeatureData()
        {

        }
    }
    public class Champion : WadFileDescriptor
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("statStoneSets")] public List<Hash> StatStoneSets { get; set; }
        [BINValue("additionalCharacters")] public List<Character> AdditionalCharacters { get; set; }
        [BINValue("fixedLoadScreenPosition")] public sbyte FixedLoadScreenPosition { get; set; }

        public Champion()
        {

        }
    }
    public class SelfAoe : Class_2144288560
    {

        public SelfAoe()
        {

        }
    }
    public class ContextualConditionSpellIsReady : IContextualConditionSpell
    {
        [BINValue("mSpellIsReady")] public bool SpellIsReady { get; set; }

        public ContextualConditionSpellIsReady()
        {

        }
    }
    public class CreateCustomTableBlock : IScriptBlock
    {
        [BINValue("IsDisabled")] public bool IsDisabled { get; set; }
        [BINValue("CustomTable")] public CustomTableSet CustomTable { get; set; }

        public CreateCustomTableBlock()
        {

        }
    }
    public class HudFeedbackDamageData
    {
        [BINValue("mPercentageDamageForFlash")] public float PercentageDamageForFlash { get; set; }
        [BINValue("mOverTimeForFlashSeconds")] public float OverTimeForFlashSeconds { get; set; }
        [BINValue("mMaxPercentageForMostReadHealth")] public float MaxPercentageForMostReadHealth { get; set; }
        [BINValue("mFlashDuration")] public float FlashDuration { get; set; }
        [BINValue("mStartFlashAlpha")] public float StartFlashAlpha { get; set; }
        [BINValue("mLowHealthFlashThresholdPercentage")] public float LowHealthFlashThresholdPercentage { get; set; }
        [BINValue("mLowHealthFlashDuration")] public float LowHealthFlashDuration { get; set; }
        [BINValue("mLowHealthFlashOpacityStrength")] public float LowHealthFlashOpacityStrength { get; set; }

        public HudFeedbackDamageData()
        {

        }
    }
    public class UpdaterData
    {
        [BINValue("mInputType")] public uint InputType { get; set; }
        [BINValue("mOutputType")] public uint OutputType { get; set; }
        [BINValue("mValueProcessorDataList")] public List<ValueProcessorData> ValueProcessorDataList { get; set; }

        public UpdaterData()
        {

        }
    }
    public class CharacterToolData
    {
        [BINValue("searchTags")] public string SearchTags { get; set; }
        [BINValue("searchTagsSecondary")] public string SearchTagsSecondary { get; set; }

        public CharacterToolData()
        {

        }
    }
    public class DamageUnitCheat : Cheat
    {
        [BINValue("mTarget")] public uint Target { get; set; }
        [BINValue("mDamageAmount")] public uint DamageAmount { get; set; }
        [BINValue("mPercentageOfAttack")] public float PercentageOfAttack { get; set; }
        [BINValue("mDamageType")] public uint DamageType { get; set; }
        [BINValue("mHitResult")] public uint HitResult { get; set; }

        public DamageUnitCheat()
        {

        }
    }
    public class Class_3967297150 : IContextualCondition
    {
        [BINValue(290168160)] public byte m290168160 { get; set; }

        public Class_3967297150()
        {

        }
    }
    public class HasNNearbyVisibleUnitsRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mUnitsRequirements")] public List<ICastRequirement> UnitsRequirements { get; set; }
        [BINValue("mUnitsRequired")] public uint UnitsRequired { get; set; }
        [BINValue("mRange")] public float Range { get; set; }
        [BINValue("mDistanceType")] public uint DistanceType { get; set; }

        public HasNNearbyVisibleUnitsRequirement()
        {

        }
    }
    public class VeritcalFacingMatchVelocity : VerticalFacingType
    {

        public VeritcalFacingMatchVelocity()
        {

        }
    }
    public interface IMaterialDef
    {
    }
    public class StatStoneData : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue(2415261508)] public List<Class_4146948500> m2415261508 { get; set; }
        [BINValue(3475980913)] public Link<StatStoneCategory> m3475980913 { get; set; }
        [BINValue(4213855983)] public uint m4213855983 { get; set; }
        [BINValue(678414787)] public uint m678414787 { get; set; }
        [BINValue(1401290250)] public List<ulong> m1401290250 { get; set; }
        [BINValue(1475661895)] public bool m1475661895 { get; set; }
        [BINValue(2094353733)] public bool m2094353733 { get; set; }
        [BINValue(539499133)] public bool m539499133 { get; set; }
        [BINValue(2007295361)] public string m2007295361 { get; set; }

        public StatStoneData()
        {

        }
    }
    public class FunctionDefinition
    {
        [BINValue("Sequence")] public ScriptSequence Sequence { get; set; }
        [BINValue("InputParameters")] public List<Hash> InputParameters { get; set; }
        [BINValue("OutputParameters")] public List<Hash> OutputParameters { get; set; }

        public FunctionDefinition()
        {

        }
    }
    public class Class_3987305908 : IStatStoneLogicDriver
    {

        public Class_3987305908()
        {

        }
    }
    public class FloatTableGet : IFloatGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("Default")] public Optional<float> Default { get; set; }

        public FloatTableGet()
        {

        }
    }
    public class Class_3991255873
    {
        [BINValue(1482915802)] public Vector2 m1482915802 { get; set; }
        [BINValue(1732755706)] public Vector2 m1732755706 { get; set; }
        [BINValue(2179074287)] public float m2179074287 { get; set; }

        public Class_3991255873()
        {

        }
    }
    public class Class_3994264754 : IStatStoneLogicDriver
    {
        [BINValue(1203421971)] public bool m1203421971 { get; set; }
        [BINValue(507497828)] public bool m507497828 { get; set; }
        [BINValue(3588584256)] public bool m3588584256 { get; set; }

        public Class_3994264754()
        {

        }
    }
    public class CursorConfig
    {
        [BINValue("mSingleContextCursors")] public List<CursorData> SingleContextCursors { get; set; }
        [BINValue("mTeamContextCursors")] public List<CursorDataTeamContext> TeamContextCursors { get; set; }
        [BINValue("mHoverNotUseableCursor")] public CursorDataCaptureCooldownContext HoverNotUseableCursor { get; set; }

        public CursorConfig()
        {

        }
    }
    public class TargeterDefinitionSkipTerrain : TargeterDefinition
    {
        [BINValue(3384398744)] public Class_1348413282 m3384398744 { get; set; }
        [BINValue("mStartLocator")] public DrawablePositionLocator StartLocator { get; set; }
        [BINValue("mEndLocator")] public DrawablePositionLocator EndLocator { get; set; }
        [BINValue("mBaseTextureName")] public string BaseTextureName { get; set; }
        [BINValue("mTerrainTextureName")] public string TerrainTextureName { get; set; }
        [BINValue("mTargetTextureName")] public string TargetTextureName { get; set; }
        [BINValue("mTargetTextureRadius")] public float TargetTextureRadius { get; set; }
        [BINValue("mFallbackDirection")] public uint FallbackDirection { get; set; }

        public TargeterDefinitionSkipTerrain()
        {

        }
    }
    public class Class_3997290289 : IDynamicMaterialDriver
    {
        [BINValue(2717239288)] public string m2717239288 { get; set; }
        [BINValue(3685552942)] public uint m3685552942 { get; set; }

        public Class_3997290289()
        {

        }
    }
    public class EffectGlowElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mFlipX")] public bool FlipX { get; set; }
        [BINValue("mFlipY")] public bool FlipY { get; set; }
        [BINValue("mPerPixelUvsX")] public bool PerPixelUvsX { get; set; }
        [BINValue("mAtlas")] public AtlasData Atlas { get; set; }
        [BINValue("CycleTime")] public float CycleTime { get; set; }
        [BINValue("BaseScale")] public float BaseScale { get; set; }
        [BINValue("CycleBasedScaleAddition")] public float CycleBasedScaleAddition { get; set; }
        [BINValue("MinimumAlpha")] public float MinimumAlpha { get; set; }

        public EffectGlowElementData()
        {

        }
    }
    public class ContextualConditionItemCanBePurchased : IContextualCondition
    {
        [BINValue("mItemCanBePurchased")] public bool ItemCanBePurchased { get; set; }

        public ContextualConditionItemCanBePurchased()
        {

        }
    }
    public class TextureAndColorData
    {
        [BINValue("textureFile")] public string TextureFile { get; set; }
        [BINValue("color")] public ColorRGBAVector4Byte Color { get; set; }
        [BINValue("colorblindTextureFile")] public Optional<string> ColorblindTextureFile { get; set; }
        [BINValue("colorblindColor")] public Optional<ColorRGBAVector4Byte> ColorblindColor { get; set; }

        public TextureAndColorData()
        {

        }
    }
    public class AISpellData
    {
        [BINValue("mSendAIEvent")] public bool SendAIEvent { get; set; }
        [BINValue("mRadius")] public float Radius { get; set; }
        [BINValue("mLifetime")] public float Lifetime { get; set; }
        [BINValue("mRange")] public float Range { get; set; }
        [BINValue("mSpeed")] public float Speed { get; set; }
        [BINValue("mEndOnly")] public bool EndOnly { get; set; }
        [BINValue("mBlockLevel")] public byte BlockLevel { get; set; }

        public AISpellData()
        {

        }
    }
    public class DynamicMaterialStaticSwitch
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("enabled")] public bool Enabled { get; set; }
        [BINValue("driver")] public IDynamicMaterialBoolDriver Driver { get; set; }

        public DynamicMaterialStaticSwitch()
        {

        }
    }
    public class ResourceResolver : BaseResourceResolver
    {

        public ResourceResolver()
        {

        }
    }
    public class CursorDataTeamContext
    {
        [BINValue("mData")] public List<CursorData> Data { get; set; }

        public CursorDataTeamContext()
        {

        }
    }
    public class SinusoidalHeightSolver : HeightSolverType
    {
        [BINValue("mVerticalOffset")] public float VerticalOffset { get; set; }
        [BINValue("mAmplitude")] public float Amplitude { get; set; }
        [BINValue("mNumberOfPeriods")] public float NumberOfPeriods { get; set; }

        public SinusoidalHeightSolver()
        {

        }
    }
    public class StringTableGet : IStringGet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }
        [BINValue("Default")] public Optional<string> Default { get; set; }

        public StringTableGet()
        {

        }
    }
    public class ExperienceModData
    {
        [BINValue("mPlayerMinionSplitXp")] public List<float> PlayerMinionSplitXp { get; set; }

        public ExperienceModData()
        {

        }
    }
    public class TrophyPedestalData : BaseLoadoutData
    {
        [BINValue(4134177491)] public string m4134177491 { get; set; }
        [BINValue(607049692)] public Class_607049692 m607049692 { get; set; }
        [BINValue(1905664938)] public string m1905664938 { get; set; }
        [BINValue("animationGraphData")] public Link<AnimationGraphData> AnimationGraphData { get; set; }
        [BINValue("mJointName")] public string JointName { get; set; }
        [BINValue("skinMeshProperties")] public SkinMeshDataProperties SkinMeshProperties { get; set; }
        [BINValue("mTierTRAKey")] public string TierTRAKey { get; set; }

        public TrophyPedestalData()
        {

        }
    }
    public class VfxPrimitiveCameraSegmentBeam : VfxPrimitiveBeamBase
    {
        [BINValue("mBeam")] public VfxBeamDefinitionData Beam { get; set; }

        public VfxPrimitiveCameraSegmentBeam()
        {

        }
    }
    public class InstanceVarsTable : ScriptTable
    {

        public InstanceVarsTable()
        {

        }
    }
    public class MouseOverEffectData
    {
        [BINValue("mAllyColor")] public ColorRGBAVector4Byte AllyColor { get; set; }
        [BINValue("mEnemyColor")] public ColorRGBAVector4Byte EnemyColor { get; set; }
        [BINValue("mNeutralColor")] public ColorRGBAVector4Byte NeutralColor { get; set; }
        [BINValue("mSelfColor")] public ColorRGBAVector4Byte SelfColor { get; set; }
        [BINValue("mMouseOverSize")] public int MouseOverSize { get; set; }
        [BINValue("mMouseOverColorFactor")] public float MouseOverColorFactor { get; set; }
        [BINValue("mMouseOverBlurPassCount")] public uint MouseOverBlurPassCount { get; set; }
        [BINValue("mSelectedSize")] public int SelectedSize { get; set; }
        [BINValue("mSelectedColorFactor")] public float SelectedColorFactor { get; set; }
        [BINValue("mSelectedBlurPassCount")] public uint SelectedBlurPassCount { get; set; }
        [BINValue("mAvatarSize")] public int AvatarSize { get; set; }
        [BINValue("mAvatarColorFactor")] public float AvatarColorFactor { get; set; }
        [BINValue("mAvatarColor")] public ColorRGBAVector4Byte AvatarColor { get; set; }
        [BINValue("mAvatarBlurPassCount")] public uint AvatarBlurPassCount { get; set; }
        [BINValue("mKillerSize")] public int KillerSize { get; set; }
        [BINValue("mKillerColorFactor")] public float KillerColorFactor { get; set; }
        [BINValue("mKillerBlurPassCount")] public uint KillerBlurPassCount { get; set; }
        [BINValue("mInteractionTimes")] public List<float> InteractionTimes { get; set; }
        [BINValue("mInteractionSizes")] public List<int> InteractionSizes { get; set; }

        public MouseOverEffectData()
        {

        }
    }
    public class ParametricClipData : BlendableClipData
    {
        [BINValue("mFlags")] public uint Flags { get; set; }
        [BINValue("mAnimationInterruptionGroupNames")] public List<Hash> AnimationInterruptionGroupNames { get; set; }
        [BINValue("mMaskDataName")] public Hash MaskDataName { get; set; }
        [BINValue("mTrackDataName")] public Hash TrackDataName { get; set; }
        [BINValue("mSyncGroupDataName")] public Hash SyncGroupDataName { get; set; }
        [BINValue("mEventDataMap")] public Dictionary<Hash, BaseEventData> EventDataMap { get; set; }
        [BINValue("mUpdaterType")] public uint UpdaterType { get; set; }
        [BINValue("mParametricPairDataList")] public List<ParametricPairData> ParametricPairDataList { get; set; }

        public ParametricClipData()
        {

        }
    }
    public class FeatureAudioDataProperties
    {
        [BINValue("bankUnits")] public List<BankUnit> BankUnits { get; set; }
        [BINValue("music")] public MusicAudioDataProperties Music { get; set; }
        [BINValue("feature")] public Hash Feature { get; set; }

        public FeatureAudioDataProperties()
        {

        }
    }
    public class Class_4073390176
    {
        [BINValue("dragon")] public TeamBuffData Dragon { get; set; }
        [BINValue(1081630498)] public TeamBuffData m1081630498 { get; set; }
        [BINValue(1265210044)] public TeamBuffData m1265210044 { get; set; }
        [BINValue(2125982193)] public TeamBuffData m2125982193 { get; set; }
        [BINValue(1537318524)] public TeamBuffData m1537318524 { get; set; }
        [BINValue(1818122524)] public TeamBuffData m1818122524 { get; set; }
        [BINValue(2414492958)] public TeamBuffData m2414492958 { get; set; }
        [BINValue(2397715339)] public TeamBuffData m2397715339 { get; set; }
        [BINValue(2380937720)] public TeamBuffData m2380937720 { get; set; }
        [BINValue(2498381053)] public TeamBuffData m2498381053 { get; set; }
        [BINValue(2481603434)] public TeamBuffData m2481603434 { get; set; }
        [BINValue(2464825815)] public TeamBuffData m2464825815 { get; set; }
        [BINValue(2448048196)] public TeamBuffData m2448048196 { get; set; }
        [BINValue(2297049625)] public TeamBuffData m2297049625 { get; set; }
        [BINValue(2280272006)] public TeamBuffData m2280272006 { get; set; }
        [BINValue(3149811562)] public TeamBuffData m3149811562 { get; set; }

        public Class_4073390176()
        {

        }
    }
    public class FixedShaderDef : IShaderDef
    {
        [BINValue("parameters")] public List<ShaderPhysicalParameter> Parameters { get; set; }
        [BINValue("staticSwitches")] public List<ShaderStaticSwitch> StaticSwitches { get; set; }
        [BINValue("textures")] public List<ShaderTexture> Textures { get; set; }
        [BINValue("featureDefines")] public Dictionary<string, string> FeatureDefines { get; set; }
        [BINValue("featureMask")] public uint FeatureMask { get; set; }
        [BINValue("vertexShader")] public string VertexShader { get; set; }
        [BINValue("pixelShader")] public string PixelShader { get; set; }

        public FixedShaderDef()
        {

        }
    }
    public class SkinSummonerEmoteLoadout
    {
        [BINValue("mEmotes")] public List<SummonerEmote> Emotes { get; set; }

        public SkinSummonerEmoteLoadout()
        {

        }
    }
    public class SummonerSpellPerkReplacement
    {
        [BINValue("mSummonerSpellRequired")] public Hash SummonerSpellRequired { get; set; }
        [BINValue(3565838065)] public Hash m3565838065 { get; set; }

        public SummonerSpellPerkReplacement()
        {

        }
    }
    public class TimeMaterialDriver : IDynamicMaterialFloatDriver
    {

        public TimeMaterialDriver()
        {

        }
    }
    public class EffectCircleMaskCooldownElementData : EffectElementData
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mScene")] public Link<SceneData> Scene { get; set; }
        [BINValue("mEnabled")] public bool Enabled { get; set; }
        [BINValue("mDraggable")] public uint Draggable { get; set; }
        [BINValue("mLayer")] public uint Layer { get; set; }
        [BINValue("mAnchorOptional")] public Optional<Vector2> AnchorOptional { get; set; }
        [BINValue("mAutoRect")] public bool AutoRect { get; set; }
        [BINValue("mNoPixelSnappingX")] public bool NoPixelSnappingX { get; set; }
        [BINValue("mNoPixelSnappingY")] public bool NoPixelSnappingY { get; set; }
        [BINValue("mRect")] public Vector4 Rect { get; set; }
        [BINValue("mUseRectSourceResolutionAsFloor")] public bool UseRectSourceResolutionAsFloor { get; set; }
        [BINValue("mRectSourceResolutionWidth")] public uint RectSourceResolutionWidth { get; set; }
        [BINValue("mRectSourceResolutionHeight")] public uint RectSourceResolutionHeight { get; set; }
        [BINValue("mKeepMaxScale")] public bool KeepMaxScale { get; set; }
        [BINValue("mHitTestPolygon")] public List<Vector2> HitTestPolygon { get; set; }
        [BINValue(629911194)] public bool m629911194 { get; set; }
        [BINValue("mEffectColor0")] public ColorRGBAVector4Byte EffectColor0 { get; set; }
        [BINValue("mEffectColor1")] public ColorRGBAVector4Byte EffectColor1 { get; set; }

        public EffectCircleMaskCooldownElementData()
        {

        }
    }
    public class GlobalStatsUIData
    {
        [BINValue(602756116)] public Dictionary<byte, StatUIData> m602756116 { get; set; }
        [BINValue("mNumberStyle")] public string NumberStyle { get; set; }
        [BINValue("mNumberStylePercent")] public string NumberStylePercent { get; set; }
        [BINValue("mNumberStyleBonus")] public string NumberStyleBonus { get; set; }
        [BINValue("mNumberStyleBonusPercent")] public string NumberStyleBonusPercent { get; set; }
        [BINValue("mNumberStyleTotalAndCoefficient")] public string NumberStyleTotalAndCoefficient { get; set; }
        [BINValue("mNumberStyleTotalAndCoefficientPercent")] public string NumberStyleTotalAndCoefficientPercent { get; set; }
        [BINValue(3983319277)] public string m3983319277 { get; set; }
        [BINValue(3917617343)] public string m3917617343 { get; set; }
        [BINValue(799458480)] public string m799458480 { get; set; }
        [BINValue(4031521229)] public byte m4031521229 { get; set; }
        [BINValue(2823080650)] public byte m2823080650 { get; set; }

        public GlobalStatsUIData()
        {

        }
    }
    public class Class_4095662801 : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mAffectsTypeFlags")] public uint AffectsTypeFlags { get; set; }
        [BINValue("mAffectsStatusFlags")] public uint AffectsStatusFlags { get; set; }

        public Class_4095662801()
        {

        }
    }
    public class Class_4100984476 : GameModeConstant
    {
        [BINValue("mValue")] public string Value { get; set; }

        public Class_4100984476()
        {

        }
    }
    public class UseableData
    {
        [BINValue("flags")] public uint Flags { get; set; }
        [BINValue("useHeroSpellName")] public string UseHeroSpellName { get; set; }
        [BINValue("useSpellName")] public string UseSpellName { get; set; }
        [BINValue("useCooldownSpellSlot")] public int UseCooldownSpellSlot { get; set; }

        public UseableData()
        {

        }
    }
    public class Class_4103435203
    {
        [BINValue(612716707)] public bool m612716707 { get; set; }
        [BINValue(284224491)] public Link<Class_3320474296> m284224491 { get; set; }
        [BINValue(3185914920)] public List<Class_4266457040> m3185914920 { get; set; }

        public Class_4103435203()
        {

        }
    }
    public class Class_4104567591
    {
        [BINValue("mName")] public string Name { get; set; }
        [BINValue("mIconPath")] public string IconPath { get; set; }
        [BINValue(3272883558)] public string m3272883558 { get; set; }
        [BINValue(3159300275)] public string m3159300275 { get; set; }

        public Class_4104567591()
        {

        }
    }
    public class Class_4107335487 : BaseEventData
    {
        [BINValue(3449836557)] public Hash m3449836557 { get; set; }

        public Class_4107335487()
        {

        }
    }
    public class ContextualConditionItemPurchased : IContextualCondition
    {
        [BINValue("mItemPurchased")] public bool ItemPurchased { get; set; }

        public ContextualConditionItemPurchased()
        {

        }
    }
    public class MasteryBadgeConfig
    {
        [BINValue("mBadges")] public List<MasteryBadgeData> Badges { get; set; }

        public MasteryBadgeConfig()
        {

        }
    }
    public class GameMutatorExpansions
    {
        [BINValue("mExpandedMutator")] public string ExpandedMutator { get; set; }
        [BINValue("mMutators")] public List<string> Mutators { get; set; }

        public GameMutatorExpansions()
        {

        }
    }
    public class Class_4122721905
    {
        [BINValue(2938438826)] public string m2938438826 { get; set; }
        [BINValue(3992539329)] public string m3992539329 { get; set; }
        [BINValue(1333781411)] public string m1333781411 { get; set; }
        [BINValue(3144760040)] public string m3144760040 { get; set; }
        [BINValue(1043625708)] public float m1043625708 { get; set; }
        [BINValue(3709612203)] public float m3709612203 { get; set; }
        [BINValue(776943490)] public float m776943490 { get; set; }
        [BINValue(2107277216)] public float m2107277216 { get; set; }
        [BINValue(3541856466)] public float m3541856466 { get; set; }
        [BINValue(973000595)] public float m973000595 { get; set; }
        [BINValue(2798761049)] public HudMenuTransitionData m2798761049 { get; set; }
        [BINValue(3053429941)] public HudMenuTransitionData m3053429941 { get; set; }
        [BINValue(803870366)] public HudMenuTransitionData m803870366 { get; set; }
        [BINValue(2615132873)] public Dictionary<uint, Link<VfxSystemDefinitionData>> m2615132873 { get; set; }
        [BINValue(1319476500)] public bool m1319476500 { get; set; }

        public Class_4122721905()
        {

        }
    }
    public class AnimationGraphData
    {
        [BINValue("mUseCascadeBlend")] public bool UseCascadeBlend { get; set; }
        [BINValue("mCascadeBlendValue")] public float CascadeBlendValue { get; set; }
        [BINValue("mClipDataMap")] public Dictionary<Hash, ClipBaseData> ClipDataMap { get; set; }
        [BINValue("mMaskDataMap")] public Dictionary<Hash, MaskData> MaskDataMap { get; set; }
        [BINValue("mTrackDataMap")] public Dictionary<Hash, TrackData> TrackDataMap { get; set; }
        [BINValue("mSyncGroupDataMap")] public Dictionary<Hash, SyncGroupData> SyncGroupDataMap { get; set; }
        [BINValue("mBlendDataTable")] public Dictionary<ulong, BaseBlendData> BlendDataTable { get; set; }

        public AnimationGraphData()
        {

        }
    }
    public class VfxAssetRemap
    {
        [BINValue("type")] public uint Type { get; set; }
        [BINValue("oldAsset")] public Hash OldAsset { get; set; }
        [BINValue("newAsset")] public string NewAsset { get; set; }

        public VfxAssetRemap()
        {

        }
    }
    public class RandomChanceScriptCondition : IScriptCondition
    {
        [BINValue("Chance")] public IFloatGet Chance { get; set; }

        public RandomChanceScriptCondition()
        {

        }
    }
    public class ScriptTableSet
    {
        [BINValue("Table")] public ScriptTable Table { get; set; }
        [BINValue("Var")] public Hash Var { get; set; }

        public ScriptTableSet()
        {

        }
    }
    public interface IScriptValueGet
    {
    }
    public class LoadScreenTipSet
    {
        [BINValue("mName")] public Hash Name { get; set; }
        [BINValue("mTips")] public List<LoadScreenTip> Tips { get; set; }

        public LoadScreenTipSet()
        {

        }
    }
    public class Class_4146948500
    {
        [BINValue(3033949705)] public uint m3033949705 { get; set; }
        [BINValue(4226789542)] public List<IStatStoneLogicDriver> m4226789542 { get; set; }

        public Class_4146948500()
        {

        }
    }
    public class FixedTimeMovement : MissileMovementSpec
    {
        [BINValue("mUseHeightOffsetAtEnd")] public bool UseHeightOffsetAtEnd { get; set; }
        [BINValue("mTracksTarget")] public bool TracksTarget { get; set; }
        [BINValue(2856647070)] public bool m2856647070 { get; set; }
        [BINValue("mTargetHeightAugment")] public float TargetHeightAugment { get; set; }
        [BINValue("mOffsetInitialTargetHeight")] public float OffsetInitialTargetHeight { get; set; }
        [BINValue("mStartBoneName")] public string StartBoneName { get; set; }
        [BINValue(2798329764)] public Dictionary<uint, string> m2798329764 { get; set; }
        [BINValue("mTargetBoneName")] public string TargetBoneName { get; set; }
        [BINValue(2799230803)] public float m2799230803 { get; set; }
        [BINValue("mInferDirectionFromFacingIfNeeded")] public bool InferDirectionFromFacingIfNeeded { get; set; }
        [BINValue("mProjectTargetToCastRange")] public bool ProjectTargetToCastRange { get; set; }
        [BINValue("mUseGroundHeightAtTarget")] public bool UseGroundHeightAtTarget { get; set; }
        [BINValue("mTravelTime")] public float TravelTime { get; set; }

        public FixedTimeMovement()
        {

        }
    }
    public class HudChatData
    {
        [BINValue("defaultWordWrapMargin")] public byte DefaultWordWrapMargin { get; set; }
        [BINValue("hideAfterSeconds")] public float HideAfterSeconds { get; set; }
        [BINValue(2161163606)] public byte m2161163606 { get; set; }
        [BINValue(2410634392)] public byte m2410634392 { get; set; }

        public HudChatData()
        {

        }
    }
    public interface Class_4153143643
    {
    }
    public class HasAllSubRequirementsCastRequirement : ICastRequirement
    {
        [BINValue("mInvertResult")] public bool InvertResult { get; set; }
        [BINValue("mSubRequirements")] public List<ICastRequirement> SubRequirements { get; set; }

        public HasAllSubRequirementsCastRequirement()
        {

        }
    }
    public class SkinCharacterMetaDataProperties
    {
        [BINValue("eSportCharacter")] public bool ESportCharacter { get; set; }
        [BINValue("eSportTeamTable")] public List<ESportTeamEntry> ESportTeamTable { get; set; }
        [BINValue("eSportLeagueTable")] public List<ESportLeagueEntry> ESportLeagueTable { get; set; }
        [BINValue("skinBasedRelativeColorScheme")] public bool SkinBasedRelativeColorScheme { get; set; }
        [BINValue("isRelativeColorCharacter")] public bool IsRelativeColorCharacter { get; set; }
        [BINValue("relativeColorSwapTable")] public List<int> RelativeColorSwapTable { get; set; }
        [BINValue("useAudioProperties")] public bool UseAudioProperties { get; set; }
        [BINValue("spawningSkinOffsets")] public List<SkinCharacterMetaDataProperties_SpawningSkinOffset> SpawningSkinOffsets { get; set; }
        [BINValue("useGDSBinaries")] public bool UseGDSBinaries { get; set; }

        public SkinCharacterMetaDataProperties()
        {

        }
    }
    public class Class_4180972365
    {
        [BINValue("mSceneTransition")] public HudMenuTransitionData SceneTransition { get; set; }
        [BINValue(2975799563)] public List<Class_3303051661> m2975799563 { get; set; }
        [BINValue("mTeamScoreMeterMaxRoundsPerTeam")] public uint TeamScoreMeterMaxRoundsPerTeam { get; set; }
        [BINValue(4265136050)] public bool m4265136050 { get; set; }
        [BINValue(2269398584)] public bool m2269398584 { get; set; }
        [BINValue(3757209935)] public byte m3757209935 { get; set; }

        public Class_4180972365()
        {

        }
    }
    public class WardSkinDisabler
    {
        [BINValue(1271103232)] public bool m1271103232 { get; set; }
        [BINValue(2384885417)] public List<uint> m2384885417 { get; set; }

        public WardSkinDisabler()
        {

        }
    }
    public class IsDeadDynamicMaterialBoolDriver : IDynamicMaterialBoolDriver
    {

        public IsDeadDynamicMaterialBoolDriver()
        {

        }
    }
    public class Class_4205759190
    {
        [BINValue(3969396588)] public Class_464608054 m3969396588 { get; set; }
        [BINValue(2635590115)] public bool m2635590115 { get; set; }
        [BINValue(1649527380)] public float m1649527380 { get; set; }
        [BINValue(2189949099)] public byte m2189949099 { get; set; }
        [BINValue(387190268)] public byte m387190268 { get; set; }

        public Class_4205759190()
        {

        }
    }
    public class DestroyOnMovementComplete : MissileBehaviorSpec
    {
        [BINValue("mDelay")] public int Delay { get; set; }

        public DestroyOnMovementComplete()
        {

        }
    }
    public class TooltipInstanceList
    {
        [BINValue("levelCount")] public uint LevelCount { get; set; }
        [BINValue("elements")] public List<TooltipInstanceListElement> Elements { get; set; }

        public TooltipInstanceList()
        {

        }
    }
    public class HasSkillPointRequirement : ISpellRankUpRequirement
    {

        public HasSkillPointRequirement()
        {

        }
    }
    public class Class_4224366477
    {
        [BINValue(1088652879)] public float m1088652879 { get; set; }
        [BINValue(1057185245)] public float m1057185245 { get; set; }
        [BINValue(587753271)] public float m587753271 { get; set; }

        public Class_4224366477()
        {

        }
    }
    public class RenderStyleData
    {
        [BINValue("mUnitFilterParamsInterior")] public ToonInkingFilterParams UnitFilterParamsInterior { get; set; }
        [BINValue("mUnitFilterParamsExterior")] public ToonInkingFilterParams UnitFilterParamsExterior { get; set; }
        [BINValue("mUnitStyleUseInking")] public bool UnitStyleUseInking { get; set; }

        public RenderStyleData()
        {

        }
    }
    public class ContextualSituation
    {
        [BINValue("mChooseRandomValidRule")] public bool ChooseRandomValidRule { get; set; }
        [BINValue("mCoolDownTime")] public float CoolDownTime { get; set; }
        [BINValue("mRules")] public List<ContextualRule> Rules { get; set; }

        public ContextualSituation()
        {

        }
    }
    public interface VfxPrimitiveMeshBase : VfxPrimitiveBase
    {
        [BINValue("mMesh")] VfxMeshDefinitionData Mesh { get; set; }
    }
    public class CharacterPreloadData
    {
        [BINValue("mCharacter")] public Hash Character { get; set; }
        [BINValue("mSkinId")] public uint SkinId { get; set; }

        public CharacterPreloadData()
        {

        }
    }
    public interface IFunctionGet : IScriptValueGet
    {
    }
    public class HudHealthBarBurstHealData
    {
        [BINValue("healTimeWindow")] public float HealTimeWindow { get; set; }
        [BINValue("healTriggerPercent")] public float HealTriggerPercent { get; set; }
        [BINValue("healFadeDuration")] public float HealFadeDuration { get; set; }

        public HudHealthBarBurstHealData()
        {

        }
    }
    public class ContextualConditionNumberOfCharactersNearTargetPos : IContextualCondition
    {
        [BINValue("mNumberOfCharacters")] public uint NumberOfCharacters { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }
        [BINValue("mTeamCompareOp")] public byte TeamCompareOp { get; set; }

        public ContextualConditionNumberOfCharactersNearTargetPos()
        {

        }
    }
    public class VfxAnimatedFloatVariableData
    {
        [BINValue("probabilityTables")] public List<VfxProbabilityTableData> ProbabilityTables { get; set; }
        [BINValue("times")] public List<float> Times { get; set; }
        [BINValue("values")] public List<float> Values { get; set; }

        public VfxAnimatedFloatVariableData()
        {

        }
    }
    public class ContextualConditionNearbyChampionCount : IContextualCondition
    {
        [BINValue("mTeamCompareOp")] public byte TeamCompareOp { get; set; }
        [BINValue(6566231)] public uint m6566231 { get; set; }
        [BINValue("mCompareOp")] public byte CompareOp { get; set; }

        public ContextualConditionNearbyChampionCount()
        {

        }
    }
    public class Class_4266457040
    {
        [BINValue(3155596802)] public int m3155596802 { get; set; }
        [BINValue(702522642)] public Hash m702522642 { get; set; }
        [BINValue(934764380)] public Hash m934764380 { get; set; }
        [BINValue(1077461003)] public Hash m1077461003 { get; set; }
        [BINValue(43002728)] public List<Hash> m43002728 { get; set; }
        [BINValue(144730223)] public List<Hash> m144730223 { get; set; }
        [BINValue(4257643354)] public Class_779837744 m4257643354 { get; set; }

        public Class_4266457040()
        {

        }
    }
    public class TriggerFromScript : Class_3362386950
    {
        [BINValue("mActions")] public List<Class_1405067729> Actions { get; set; }
        [BINValue("mTriggerName")] public Hash TriggerName { get; set; }
        [BINValue("mDelay")] public float Delay { get; set; }

        public TriggerFromScript()
        {

        }
    }
    public class HudInputBoxData
    {
        [BINValue("inputTextLengthMax")] public byte InputTextLengthMax { get; set; }
        [BINValue("caretAlphaMax")] public float CaretAlphaMax { get; set; }
        [BINValue("caretBlinkTime")] public float CaretBlinkTime { get; set; }
        [BINValue("markedOffsetY")] public float MarkedOffsetY { get; set; }
        [BINValue("markedLineSizePx")] public float MarkedLineSizePx { get; set; }
        [BINValue("selectedOffsetY")] public float SelectedOffsetY { get; set; }
        [BINValue("selectedLineSizePx")] public float SelectedLineSizePx { get; set; }
        [BINValue(3198939864)] public float m3198939864 { get; set; }

        public HudInputBoxData()
        {

        }
    }
    public class StaticMaterialDef : IResource, IMaterialDef
    {
        [BINValue("name")] public string Name { get; set; }
        [BINValue("type")] public uint Type { get; set; }
        [BINValue("defaultTechnique")] public string DefaultTechnique { get; set; }
        [BINValue("samplerValues")] public List<StaticMaterialShaderSamplerDef> SamplerValues { get; set; }
        [BINValue("paramValues")] public List<StaticMaterialShaderParamDef> ParamValues { get; set; }
        [BINValue("switches")] public List<StaticMaterialSwitchDef> Switches { get; set; }
        [BINValue("shaderMacros")] public Dictionary<string, string> ShaderMacros { get; set; }
        [BINValue("techniques")] public List<StaticMaterialTechniqueDef> Techniques { get; set; }
        [BINValue("childTechniques")] public List<StaticMaterialChildTechniqueDef> ChildTechniques { get; set; }
        [BINValue("dynamicMaterial")] public DynamicMaterialDef DynamicMaterial { get; set; }

        public StaticMaterialDef()
        {

        }
    }
    public class HudAbilityPromptData
    {
        [BINValue(3136505745)] public ColorRGBAVector4Byte m3136505745 { get; set; }
        [BINValue(1649820186)] public ColorRGBAVector4Byte m1649820186 { get; set; }
        [BINValue(4045513993)] public Vector2 m4045513993 { get; set; }
        [BINValue(1284438647)] public float m1284438647 { get; set; }
        [BINValue(427443163)] public float m427443163 { get; set; }

        public HudAbilityPromptData()
        {

        }
    }
}
