using System;

namespace ClientCommon
{
	public enum ClientEventName : short
	{
		kEvent_None,
		kEvent_HeartBeat,
		kEvent_HeroMoveStart,
		kEvent_HeroMoveEnd,
		kEvent_HeroMove,
		kEvent_HeroBeginAttack,
		kEvent_HeroAttackHit,
		kEvent_HeroBeginCast,
		kEvent_HeroBeginSkill,
		kEvent_HeroSkillHit,
		kEvent_MonsterMove,
		kEvent_Chat,
		kEvent_StoryDungeonAbandon,
		kEvent_StoryDungeonExit,
		kEvent_ExpDungeonAbandon,
		kEvent_ExpDungeonExit,
		kEvent_GoldDungeonAbandon,
		kEvent_GoldDungeonExit,
		kEvent_CursedDockNpcMove,
		kEvent_CounterAttackTraceTargetClear
	}
}
