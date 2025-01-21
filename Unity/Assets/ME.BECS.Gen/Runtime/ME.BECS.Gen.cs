namespace ME.BECS {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    [UnityEngine.Scripting.PreserveAttribute]
    public static unsafe class AOTBurstHelper {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void AOT() {
            StaticSystemTypes<ME.BECS.Attack.CanFireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.CanFireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.CanFireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.CanFireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.FireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.FireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.FireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.FireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.MoveToAttackerSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.MoveToAttackerSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.MoveToAttackerSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.MoveToAttackerSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.ReloadSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.ReloadSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.ReloadSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.ReloadSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.ResetCanFireSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.ResetCanFireSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.ResetCanFireSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.ResetCanFireSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.RotateWhileAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.RotateWhileAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.RotateWhileAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.RotateWhileAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.SearchTargetSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.SearchTargetSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.SearchTargetSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.SearchTargetSystem>(default);
            StaticSystemTypes<ME.BECS.Attack.StopWhileAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Attack.StopWhileAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Attack.StopWhileAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Attack.StopWhileAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Bullets.DestroySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Bullets.DestroySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Bullets.DestroySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Bullets.DestroySystem>(default);
            StaticSystemTypes<ME.BECS.Bullets.FlySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Bullets.FlySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Bullets.FlySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Bullets.FlySystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandAttackSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandAttackSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandAttackSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandAttackSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandBuildSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandBuildSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandBuildSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandBuildSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandBuildUpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandBuildUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandBuildUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandBuildUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.Commands.CommandMoveSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Commands.CommandMoveSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Commands.CommandMoveSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Commands.CommandMoveSystem>(default);
            StaticSystemTypes<ME.BECS.DestroyWithLifetimeSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.DestroyWithLifetimeSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.DestroyWithLifetimeSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.DestroyWithLifetimeSystem>(default);
            StaticSystemTypes<ME.BECS.DestroyWithTicksSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.DestroyWithTicksSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.DestroyWithTicksSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.DestroyWithTicksSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.CreateSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.CreateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.FogOfWar.CreateSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.CreateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.CreateTextureSystem>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.FogOfWar.CreateTextureSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.FogOfWar.CreateTextureSystem>.MakeMethod(null);
            StaticSystemTypes<ME.BECS.FogOfWar.DrawGizmosSystem>.Validate();
            BurstCompileOnDrawGizmos<ME.BECS.FogOfWar.DrawGizmosSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.FogOfWar.DrawGizmosSystem>.MakeMethod(null);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.FogOfWar.DrawGizmosSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.ShadowCopySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.ShadowCopySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.ShadowCopySystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.FogOfWar.UpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.UpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.UpdateSystem>(default);
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.FogOfWar.UpdateTextureSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.FogOfWar.UpdateTextureSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.BuildGraphSystem>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Pathfinding.BuildGraphSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Pathfinding.BuildGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Pathfinding.BuildGraphSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Pathfinding.BuildGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.BuildPathSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.BuildPathSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.BuildPathSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.BuildPathSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.DrawGizmosGraphSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Pathfinding.DrawGizmosGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.FollowPathSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.FollowPathSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.FollowPathSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.LookAtSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.LookAtSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.LookAtSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.LookAtSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.ShowBuildingGridSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.ShowBuildingGridSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Pathfinding.ShowBuildingGridSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.ShowBuildingGridSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Pathfinding.ShowBuildingGridSystem>(default);
            StaticSystemTypes<ME.BECS.Pathfinding.UpdateGraphSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Pathfinding.UpdateGraphSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Pathfinding.UpdateGraphSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Pathfinding.UpdateGraphSystem>(default);
            StaticSystemTypes<ME.BECS.Players.PlayersSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.Players.PlayersSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Players.PlayersSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Players.PlayersSystem>(default);
            StaticSystemTypes<ME.BECS.QuadTreeInsertSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.QuadTreeInsertSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.QuadTreeInsertSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.QuadTreeInsertSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.QuadTreeInsertSystem>(default);
            StaticSystemTypes<ME.BECS.QuadTreeQuerySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.QuadTreeQuerySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.QuadTreeQuerySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.QuadTreeQuerySystem>(default);
            StaticSystemTypes<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.Validate();
            BurstCompileOnAwake<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(default);
            StaticSystemTypes<ME.BECS.Units.DestroySystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.DestroySystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.DestroySystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.DestroySystem>(default);
            StaticSystemTypes<ME.BECS.Units.HitSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.HitSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.HitSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.HitSystem>(default);
            StaticSystemTypes<ME.BECS.Units.SteeringSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmos<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Units.SteeringSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.SteeringSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Units.SteeringSystem>(default);
            StaticSystemTypes<ME.BECS.Units.SteeringWithAvoidanceSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmos<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileOnDrawGizmosNoBurst<ME.BECS.Units.SteeringWithAvoidanceSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Units.SteeringWithAvoidanceSystem>(default);
            BurstCompileMethod.MakeDrawGizmos<ME.BECS.Units.SteeringWithAvoidanceSystem>(default);
            StaticSystemTypes<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.Validate();
            BurstCompileOnUpdate<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>(default);
            StaticSystemTypes<Sample.FilterEntitiesSystem>.Validate();
            BurstCompileOnUpdate<Sample.FilterEntitiesSystem>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<Sample.FilterEntitiesSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<Sample.FilterEntitiesSystem>(default);
            StaticSystemTypes<Sample.SpawnEntitiesSystem>.Validate();
            BurstCompileOnAwake<Sample.SpawnEntitiesSystem>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<Sample.SpawnEntitiesSystem>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<Sample.SpawnEntitiesSystem>(default);
            StaticTypes<ME.BECS.Attack.AttackComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackFilterComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.AOT();
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.AOT();
            StaticTypes<ME.BECS.Attack.CanFireComponent>.AOT();
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.AOT();
            StaticTypes<ME.BECS.Attack.FireUsedComponent>.AOT();
            StaticTypes<ME.BECS.Attack.OnFireEvent>.AOT();
            StaticTypes<ME.BECS.Attack.ReloadedComponent>.AOT();
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.AOT();
            StaticTypes<ME.BECS.Attack.RotateToAttackWhileIdleComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.FirePointComponent>.AOT();
            StaticTypes<ME.BECS.Bullets.TargetReachedComponent>.AOT();
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.AOT();
            StaticTypes<ME.BECS.Commands.BuildInProgress>.AOT();
            StaticTypes<ME.BECS.Commands.CommandAttack>.AOT();
            StaticTypes<ME.BECS.Commands.CommandBuild>.AOT();
            StaticTypes<ME.BECS.Commands.CommandMove>.AOT();
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.AOT();
            StaticTypes<ME.BECS.DestroyWithLifetime>.AOT();
            StaticTypes<ME.BECS.DestroyWithTicks>.AOT();
            StaticTypes<ME.BECS.Effects.EffectComponent>.AOT();
            StaticTypes<ME.BECS.EntityConfigComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarHasShadowCopyComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.AOT();
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.AOT();
            StaticTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>.AOT();
            StaticTypes<ME.BECS.IsInactive>.AOT();
            StaticTypes<ME.BECS.Pathfinding.AgentComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.RootGraphComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetInfoComponent>.AOT();
            StaticTypes<ME.BECS.Pathfinding.TargetPathComponent>.AOT();
            StaticTypes<ME.BECS.Players.IsPlayerDefeatTag>.AOT();
            StaticTypes<ME.BECS.Players.IsPlayerVictoryTag>.AOT();
            StaticTypes<ME.BECS.Players.OwnerChangedEvent>.AOT();
            StaticTypes<ME.BECS.Players.OwnerComponent>.AOT();
            StaticTypes<ME.BECS.Players.PlayerComponent>.AOT();
            StaticTypes<ME.BECS.Players.PlayerCurrentSelection>.AOT();
            StaticTypes<ME.BECS.Players.TeamComponent>.AOT();
            StaticTypes<ME.BECS.QuadTreeElement>.AOT();
            StaticTypes<ME.BECS.QuadTreeQuery>.AOT();
            StaticTypes<ME.BECS.QuadTreeQueryHasCustomFilterTag>.AOT();
            StaticTypes<ME.BECS.QuadTreeResult>.AOT();
            StaticTypes<ME.BECS.TNull>.AOT();
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.ParentComponent>.AOT();
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.AOT();
            StaticTypes<ME.BECS.UI.UIComponent>.AOT();
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.DamageTookComponent>.AOT();
            StaticTypes<ME.BECS.Units.DamageTookEvent>.AOT();
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.AOT();
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.AOT();
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.AOT();
            StaticTypes<ME.BECS.Units.PathFollowComponent>.AOT();
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitBelongsToComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.AOT();
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.AOT();
            StaticTypes<ME.BECS.Views.AssignViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.CameraComponent>.AOT();
            StaticTypes<ME.BECS.Views.DrawMeshProviderTag>.AOT();
            StaticTypes<ME.BECS.Views.EntityViewProviderTag>.AOT();
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.IsViewRequested>.AOT();
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.AOT();
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.AOT();
            StaticTypes<ME.BECS.Views.ViewComponent>.AOT();
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.AOT();
            StaticTypes<Sample.TestComponent>.AOT();
            StaticTypes<Sample.TestConfigComponent>.AOT();
            AutoDestroyRegistryStatic<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.Destroy(null);
            StaticTypesStatic<ME.BECS.Bullets.BulletEffectOnDestroy>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoint>.AOT();
            StaticTypesStatic<ME.BECS.Units.UnitEffectOnDestroyComponent>.AOT();
            StaticTypesStatic<ME.BECS.Units.UnitEffectOnHitComponent>.AOT();
            StaticTypesStatic<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            StaticTypesStatic<ME.BECS.Views.InstantiateViewComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Attack.AttackComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Pathfinding.GraphMaskComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.AOT();
            ConfigInitializeTypes<ME.BECS.Views.InstantiateViewComponent>.AOT();
        }
    }
    public static unsafe class StaticTypesInitializer {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void Load() {
            JobUtils.Initialize();
            StaticSystemTypes<ME.BECS.Attack.CanFireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.FireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.MoveToAttackerSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.ReloadSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.ResetCanFireSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.RotateWhileAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.SearchTargetSystem>.Validate();
            StaticSystemTypes<ME.BECS.Attack.StopWhileAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Bullets.DestroySystem>.Validate();
            StaticSystemTypes<ME.BECS.Bullets.FlySystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandAttackSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandBuildSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandBuildUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.Commands.CommandMoveSystem>.Validate();
            StaticSystemTypes<ME.BECS.DestroyWithLifetimeSystem>.Validate();
            StaticSystemTypes<ME.BECS.DestroyWithTicksSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.CreateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.CreateTextureSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.DrawGizmosSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopySystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.FogOfWar.UpdateTextureSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.BuildGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.BuildPathSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.LookAtSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.ShowBuildingGridSystem>.Validate();
            StaticSystemTypes<ME.BECS.Pathfinding.UpdateGraphSystem>.Validate();
            StaticSystemTypes<ME.BECS.Players.PlayersSystem>.Validate();
            StaticSystemTypes<ME.BECS.QuadTreeInsertSystem>.Validate();
            StaticSystemTypes<ME.BECS.QuadTreeQuerySystem>.Validate();
            StaticSystemTypes<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.DestroySystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.HitSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.SteeringSystem>.Validate();
            StaticSystemTypes<ME.BECS.Units.SteeringWithAvoidanceSystem>.Validate();
            StaticSystemTypes<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.Validate();
            StaticSystemTypes<Sample.FilterEntitiesSystem>.Validate();
            StaticSystemTypes<Sample.SpawnEntitiesSystem>.Validate();
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.BuildInProgress>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandAttack>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandBuild>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.CommandMove>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.ApplyGroup(typeof(ME.BECS.Commands.CommandComponentsGroup));
            StaticTypes<ME.BECS.DestroyWithLifetime>.ApplyGroup(typeof(ME.BECS.DestroyComponentGroup));
            StaticTypes<ME.BECS.DestroyWithTicks>.ApplyGroup(typeof(ME.BECS.DestroyComponentGroup));
            StaticTypes<ME.BECS.Effects.EffectComponent>.ApplyGroup(typeof(ME.BECS.Effects.EffectComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarHasShadowCopyComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.ApplyGroup(typeof(ME.BECS.FogOfWar.FogOfWarComponentGroup));
            StaticTypes<ME.BECS.Players.OwnerComponent>.ApplyGroup(typeof(ME.BECS.Players.UnitOwnerComponentGroup));
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.ParentComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.ApplyGroup(typeof(ME.BECS.Transforms.TransformComponentGroup));
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.DamageTookComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.DamageTookEvent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.PathFollowComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitEffectOnDestroyComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitEffectOnHitComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.ApplyGroup(typeof(ME.BECS.Units.UnitComponentGroup));
            StaticTypes<ME.BECS.Views.AssignViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.IsViewRequested>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.ViewComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.ApplyGroup(typeof(ME.BECS.Views.ViewsComponentGroup));
            StaticTypes<ME.BECS.Attack.AttackComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackComponent>.SetDefaultValue(ME.BECS.Attack.AttackComponent.Default);
            StaticTypes<ME.BECS.Attack.AttackFilterComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackRuntimeFireComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackTargetComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.CanFireComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.CanFireWhileMovesTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.FireUsedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.OnFireEvent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.ReloadedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Attack.RotateAttackSensorComponent>.SetDefaultValue(ME.BECS.Attack.RotateAttackSensorComponent.Default);
            StaticTypes<ME.BECS.Attack.RotateToAttackWhileIdleComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.FirePointComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Bullets.TargetReachedComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Commands.BuildingInProgress>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.BuildInProgress>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandAttack>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandBuild>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.CommandMove>.Validate(isTag: false);
            StaticTypes<ME.BECS.Commands.UnitAttackCommandComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.DestroyWithLifetime>.Validate(isTag: false);
            StaticTypes<ME.BECS.DestroyWithTicks>.Validate(isTag: false);
            StaticTypes<ME.BECS.Effects.EffectComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.EntityConfigComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarHasShadowCopyComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsPartialTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRangeTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsRectTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerIsSectorTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyRequiredComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.FogOfWar.FogOfWarStaticComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>.Validate(isTag: false);
            StaticTypes<ME.BECS.IsInactive>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.AgentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.IsShowGridComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.PlaceholderInvalidTagComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Pathfinding.RootGraphComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetInfoComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.TargetPathComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.IsPlayerDefeatTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Players.IsPlayerVictoryTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Players.OwnerChangedEvent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.OwnerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.PlayerComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.PlayerCurrentSelection>.Validate(isTag: false);
            StaticTypes<ME.BECS.Players.TeamComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeElement>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeQuery>.Validate(isTag: false);
            StaticTypes<ME.BECS.QuadTreeQueryHasCustomFilterTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.QuadTreeResult>.Validate(isTag: false);
            StaticTypes<ME.BECS.TNull>.Validate(isTag: true);
            StaticTypes<ME.BECS.Transforms.ChildrenComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.IsFirstLevelComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.SetDefaultValue(ME.BECS.Transforms.LocalRotationComponent.Default);
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.LocalScaleComponent>.SetDefaultValue(ME.BECS.Transforms.LocalScaleComponent.Default);
            StaticTypes<ME.BECS.Transforms.ParentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.UI.UIComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.CommandGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.DamageTookComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.DamageTookEvent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.IsCommandGroupDirty>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.IsUnitStaticComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.NavAgentComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.NavAgentRuntimeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.NavAgentRuntimeSpeedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.PathFollowComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.SelectionGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.TimeToBuildComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitBelongsToComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitHealthComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitHoldComponent>.Validate(isTag: true);
            StaticTypes<ME.BECS.Units.UnitLookAtComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitQuadSizeComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.AssignViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.CameraComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.DrawMeshProviderTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.EntityViewProviderTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.IsViewRequested>.Validate(isTag: true);
            StaticTypes<ME.BECS.Views.MeshFilterComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.MeshRendererComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.ViewComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Views.ViewCustomIdComponent>.Validate(isTag: false);
            StaticTypes<Sample.TestComponent>.Validate(isTag: false);
            StaticTypes<Sample.TestConfigComponent>.Validate(isTag: false);
            StaticTypesDestroy<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>.RegisterAutoDestroy(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletEffectOnDestroy>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoint>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnDestroyComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnHitComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            AspectTypeInfo<ME.BECS.QuadTreeAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeAspect>.typeId).Get(0) = StaticTypes<ME.BECS.QuadTreeElement>.typeId;
            AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.QuadTreeQueryAspect>.typeId).Get(0) = StaticTypes<ME.BECS.QuadTreeQuery>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Resize(5);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.NavAgentComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Units.UnitCommandGroupComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(2) = StaticTypes<ME.BECS.Units.UnitSelectionGroupComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(3) = StaticTypes<ME.BECS.Units.UnitHealthComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitAspect>.typeId).Get(4) = StaticTypes<ME.BECS.Players.OwnerComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitCommandGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.CommandGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.SelectionGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Units.UnitSelectionTempGroupAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Units.SelectionGroupComponent>.typeId;
            AspectTypeInfo<ME.BECS.Views.CameraAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Views.CameraAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Views.CameraAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Views.CameraComponent>.typeId;
            AspectTypeInfo<ME.BECS.Players.TeamAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.TeamAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.TeamAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Players.TeamComponent>.typeId;
            AspectTypeInfo<ME.BECS.Players.PlayerAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.PlayerAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Players.PlayerAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Players.PlayerComponent>.typeId;
            AspectTypeInfo<ME.BECS.Effects.EffectAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Effects.EffectAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Effects.EffectAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Effects.EffectComponent>.typeId;
            AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Bullets.BulletConfigComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Bullets.BulletAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Bullets.BulletRuntimeComponent>.typeId;
            AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Resize(3);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Transforms.LocalPositionComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Transforms.LocalRotationComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Transforms.TransformAspect>.typeId).Get(2) = StaticTypes<ME.BECS.Transforms.WorldMatrixComponent>.typeId;
            AspectTypeInfo<ME.BECS.Attack.AttackAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Attack.AttackComponent>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Attack.AttackAspect>.typeId).Get(1) = StaticTypes<ME.BECS.Attack.AttackRuntimeReloadComponent>.typeId;
            #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
            StaticMethods.InitializeJobsDebug();
            #endif
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopySystem.CreateJob>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob, ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob, ME.BECS.FogOfWar.FogOfWarShadowCopyComponent, ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent, ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob, ME.BECS.Transforms.ParentComponent, ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<ME.BECS.FogOfWar.UpdateSystem.RevealRectJob, ME.BECS.FogOfWar.FogOfWarRevealerComponent, ME.BECS.Players.OwnerComponent>();
            EarlyInit.DoComponents<Sample.FilterEntitiesSystem.JobSetTest, Sample.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Units.HitSystem.Job, ME.BECS.Units.DamageTookComponent>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobAddToScene, ME.BECS.Views.IsViewRequested>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobAssignViews, ME.BECS.Views.AssignViewComponent>();
            EarlyInit.DoComponents<ME.BECS.Views.Jobs.JobRemoveFromScene, ME.BECS.Views.ViewComponent>();
            EarlyInit.DoComponents<ME.BECS.DestroyWithTicksSystem.Job, ME.BECS.DestroyWithTicks>();
            EarlyInit.DoComponents<ME.BECS.DestroyWithLifetimeSystem.Job, ME.BECS.DestroyWithLifetime>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob, ME.BECS.Pathfinding.TargetPathComponent>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob, ME.BECS.Pathfinding.TargetComponent>();
            EarlyInit.DoComponents<ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob, ME.BECS.Pathfinding.GraphMaskComponent, ME.BECS.Pathfinding.GraphMaskRuntimeComponent>();
            EarlyInit.DoComponents<ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob, ME.BECS.Commands.BuildingInProgress>();
            EarlyInit.DoComponents<ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob, ME.BECS.Commands.BuildInProgress>();
            EarlyInit.DoParallelForAspect<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.FogOfWar.CreateSystem.CleanUpJob, ME.BECS.Players.TeamAspect>();
            EarlyInit.DoAspect<ME.BECS.FogOfWar.CreateSystem.CreateJob, ME.BECS.Players.TeamAspect>();
            EarlyInit.DoAspect<Sample.FilterEntitiesSystem.JobMove, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.QuadTreeQuerySystem.Job, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.QuadTreeInsertSystem.CollectJob, ME.BECS.QuadTreeAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.DestroySystem.DestroyJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.SteeringWithAvoidanceSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Units.SteeringSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Bullets.FlySystem.FlyJob, ME.BECS.Bullets.BulletAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Bullets.DestroySystem.DestroyJob, ME.BECS.Bullets.BulletAspect, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Pathfinding.LookAtSystem.Job, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandMoveSystem.Job, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandAttackSystem.MoveJob, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandBuildSystem.Job, ME.BECS.Units.UnitCommandGroupAspect>();
            EarlyInit.DoAspect<ME.BECS.Commands.CommandAttackSystem.CleanUpJob, ME.BECS.Units.UnitAspect>();
            EarlyInit.DoAspect<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.RotateWhileAttackSystem.IdleJob, ME.BECS.Units.UnitAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.StopWhileAttackSystem.JobRemove, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.StopWhileAttackSystem.JobRotate, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ReloadSystem.ReloadJob, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.FireSystem.FireJob, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.QuadTreeQueryAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.ResetCanFireSystem.Job, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.SearchTargetSystem.SearchTargetJob, ME.BECS.Attack.AttackAspect, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.CanFireSystem.Job, ME.BECS.Attack.AttackAspect>();
            EarlyInit.DoAspect<ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.TransformAspect>();
            EarlyInit.DoAspectsComponents2_1<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job, ME.BECS.QuadTreeQueryAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>();
            EarlyInit.DoAspectsComponents1_2<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob, ME.BECS.Transforms.TransformAspect, ME.BECS.Transforms.ParentComponent, ME.BECS.Transforms.IsFirstLevelComponent>();
            EarlyInit.DoAspectsComponents2_1<ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob, ME.BECS.Units.UnitAspect, ME.BECS.Transforms.TransformAspect, ME.BECS.Units.DamageTookEvent>();
            EarlyInit.DoAspectsComponents1_1<ME.BECS.Attack.StopWhileAttackSystem.JobSet, ME.BECS.Attack.AttackAspect, ME.BECS.Transforms.ParentComponent>();
            EarlyInit.DoAspectsComponents1_1<ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob, ME.BECS.Units.UnitAspect, ME.BECS.Commands.UnitAttackCommandComponent>();
            StaticTypes.collectionsCount.Resize(StaticTypes.counter + 1u);
        }
    }
    [UnityEngine.Scripting.PreserveAttribute]
    [UnityEngine.DefaultExecutionOrder(-100_000)]
    [BURST]
    public static unsafe class StaticMethods {
        [UnityEngine.Scripting.PreserveAttribute]
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Load() {
            Worlds.Initialize();
            SystemsStatic.Initialize();
            StaticTypesInitializer.Load();
            GlobalEvents.Initialize();
            CustomModules.InvokeResetPass();
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Network.UnsafeNetworkModule.MethodsStorage>(NetworkLoad);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Views.ViewsModuleData>(ViewsLoad);
            WorldStaticCallbacks.RegisterCallback<World>(AspectsConstruct);
            EntityConfigRegistry.Initialize();
            EntityConfigsRegistry.Initialize();
            CustomModules.InvokeFirstPass();
            CustomModules.InvokeSecondPass();
        }
        private static NativeArray<System.IntPtr> graphNodes28_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_28_SystemsCodeGenerator() {
            // FogOfWarGraph-Logic
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes28_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(6, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.CreateSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.CreateSystem>.alignInt);
                *(ME.BECS.FogOfWar.CreateSystem*)item = new ME.BECS.FogOfWar.CreateSystem {
                    mapPosition = new Unity.Mathematics.float2 {
                        x = 0f,
                        y = 0f,
                    }
                    ,
                    mapSize = new Unity.Mathematics.float2 {
                        x = 500f,
                        y = 500f,
                    }
                    ,
                    resolution = 1f,
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.CreateSystem>(28, item);
                graphNodes28_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.UpdateSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.UpdateSystem>.alignInt);
                *(ME.BECS.FogOfWar.UpdateSystem*)item = new ME.BECS.FogOfWar.UpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.UpdateSystem>(28, item);
                graphNodes28_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.DrawGizmosSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.DrawGizmosSystem>.alignInt);
                *(ME.BECS.FogOfWar.DrawGizmosSystem*)item = new ME.BECS.FogOfWar.DrawGizmosSystem {
                    drawGizmos = false,
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.DrawGizmosSystem>(28, item);
                graphNodes28_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.CreateTextureSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.CreateTextureSystem>.alignInt);
                *(ME.BECS.FogOfWar.CreateTextureSystem*)item = new ME.BECS.FogOfWar.CreateTextureSystem {
                    renderView = new ME.BECS.Views.View {
                        viewSource = new ME.BECS.Views.ViewSource {
                            providerId = 1,
                            prefabId = 11,
                        }
                        ,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.CreateTextureSystem>(28, item);
                graphNodes28_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.ShadowCopySystem>.sizeInt, TAlign<ME.BECS.FogOfWar.ShadowCopySystem>.alignInt);
                *(ME.BECS.FogOfWar.ShadowCopySystem*)item = new ME.BECS.FogOfWar.ShadowCopySystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.ShadowCopySystem>(28, item);
                graphNodes28_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>.alignInt);
                *(ME.BECS.FogOfWar.ShadowCopyUpdateSystem*)item = new ME.BECS.FogOfWar.ShadowCopyUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.ShadowCopyUpdateSystem>(28, item);
                graphNodes28_SystemsCodeGenerator[5] = (System.IntPtr)item;
            }
            // [!] system is null
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnAwake_0_28_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep28_0
        , ref Unity.Jobs.JobHandle dep28_2, ref Unity.Jobs.JobHandle dep28_4, ref Unity.Jobs.JobHandle dep28_6, ref Unity.Jobs.JobHandle dep28_3) {
            {
                var input = dep28_0;
                dep28_2 = input;
                var localContext28_2 = SystemContext.Create(dt, in world, dep28_2);
                ((ME.BECS.FogOfWar.CreateSystem*)(systems[0]))->OnAwake(ref localContext28_2);
                dep28_2 = localContext28_2.dependsOn;
            }
            dep28_4 = dep28_0;
            dep28_6 = dep28_0;
            dep28_3 = dep28_2;
            // BURST ENABLE CLOSE
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnAwake_3_28_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep28_0, ref Unity.Jobs.JobHandle dep28_2, ref Unity.Jobs.JobHandle dep28_4, ref Unity.Jobs.JobHandle dep28_6, ref Unity.Jobs.JobHandle dep28_3
        , ref Unity.Jobs.JobHandle dep28_5, ref Unity.Jobs.JobHandle dep28_7, ref Unity.Jobs.JobHandle dep28_9, ref Unity.Jobs.JobHandle dep28_8) {
            {
                var input = dep28_2;
                dep28_5 = input;
                var localContext28_5 = SystemContext.Create(dt, in world, dep28_5);
                ((ME.BECS.FogOfWar.CreateTextureSystem*)(systems[3]))->OnAwake(ref localContext28_5);
                dep28_5 = localContext28_5.dependsOn;
            }
            dep28_7 = JobsExt.CombineDependencies(dep28_6, dep28_3);
            dep28_9 = JobsExt.CombineDependencies(dep28_7, dep28_5, dep28_4);
            dep28_8 = dep28_9;
            dependsOn = dep28_8;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_28_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Logic
            var systems = (System.IntPtr*)graphNodes28_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep28_8 = default;
            Unity.Jobs.JobHandle dep28_9 = default;
            Unity.Jobs.JobHandle dep28_7 = default;
            Unity.Jobs.JobHandle dep28_5 = default;
            Unity.Jobs.JobHandle dep28_3 = default;
            Unity.Jobs.JobHandle dep28_6 = default;
            Unity.Jobs.JobHandle dep28_4 = default;
            Unity.Jobs.JobHandle dep28_2 = default;
            Unity.Jobs.JobHandle dep28_0 = default;
            dep28_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnAwake_0_28_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep28_0
            , ref dep28_2, ref dep28_4, ref dep28_6, ref dep28_3
            );
            
            InnerMethodOnAwake_3_28_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep28_0, ref dep28_2, ref dep28_4, ref dep28_6, ref dep28_3
            , ref dep28_5, ref dep28_7, ref dep28_9, ref dep28_8
            );
            
            dependsOn = dep28_8;
            // Dependencies scheme:
            // * dependsOn                        => dep28_0             START                            [ SKIPPED ]
            // * dep28_0                          => dep28_2             Create System                    [  BURST  ]
            // * dep28_0                          => dep28_4             Draw Gizmos System               [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep28_0                          => dep28_6             Shadow Copy System               [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep28_2                          => dep28_3             Update System                    [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep28_2                          => dep28_5             Create Texture System            [NOT BURST]
            // * dep28_6, dep28_3                 => dep28_7             Shadow Copy Update System        [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep28_7, dep28_5, dep28_4        => dep28_9             RelayNode                        [ SKIPPED ]
            // * dep28_9                          => dep28_8             System Node                      [ SKIPPED ]
            // * EXIT dependsOn = dep28_8;
            // * dep28_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_28_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Logic
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep28_0             START                            [ SKIPPED ]
            // * dep28_0                          => dep28_2             Create System                    [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_0                          => dep28_4             Draw Gizmos System               [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_0                          => dep28_6             Shadow Copy System               [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_2                          => dep28_3             Update System                    [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_2                          => dep28_5             Create Texture System            [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_6, dep28_3                 => dep28_7             Shadow Copy Update System        [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep28_7, dep28_5, dep28_4        => dep28_9             RelayNode                        [ SKIPPED ]
            // * dep28_9                          => dep28_8             System Node                      [ SKIPPED ]
            // * EXIT dependsOn = dep28_8;
            // * dep28_8                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_28_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep28_0
        , ref Unity.Jobs.JobHandle dep28_2, ref Unity.Jobs.JobHandle dep28_4, ref Unity.Jobs.JobHandle dep28_6, ref Unity.Jobs.JobHandle dep28_3, ref Unity.Jobs.JobHandle dep28_5, ref Unity.Jobs.JobHandle dep28_7, ref Unity.Jobs.JobHandle dep28_9, ref Unity.Jobs.JobHandle dep28_8) {
            {
                var input = dep28_0;
                dep28_2 = input;
                var localContext28_2 = SystemContext.Create(dt, in world, dep28_2);
                ((ME.BECS.FogOfWar.CreateSystem*)(systems[0]))->OnUpdate(ref localContext28_2);
                dep28_2 = localContext28_2.dependsOn;
            }
            dep28_4 = dep28_0;
            {
                var input = dep28_0;
                dep28_6 = input;
                var localContext28_6 = SystemContext.Create(dt, in world, dep28_6);
                ((ME.BECS.FogOfWar.ShadowCopySystem*)(systems[4]))->OnUpdate(ref localContext28_6);
                dep28_6 = localContext28_6.dependsOn;
            }
            {
                var input = dep28_2;
                dep28_3 = input;
                var localContext28_3 = SystemContext.Create(dt, in world, dep28_3);
                ((ME.BECS.FogOfWar.UpdateSystem*)(systems[1]))->OnUpdate(ref localContext28_3);
                dep28_3 = localContext28_3.dependsOn;
            }
            dep28_5 = dep28_2;
            {
                var input = JobsExt.CombineDependencies(dep28_6, dep28_3);
                dep28_7 = input;
                var localContext28_7 = SystemContext.Create(dt, in world, dep28_7);
                ((ME.BECS.FogOfWar.ShadowCopyUpdateSystem*)(systems[5]))->OnUpdate(ref localContext28_7);
                dep28_7 = localContext28_7.dependsOn;
            }
            dep28_9 = JobsExt.CombineDependencies(dep28_7, dep28_5, dep28_4);
            dep28_8 = dep28_9;
            dependsOn = dep28_8;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_28_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Logic
            var systems = (System.IntPtr*)graphNodes28_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep28_8 = default;
            Unity.Jobs.JobHandle dep28_9 = default;
            Unity.Jobs.JobHandle dep28_7 = default;
            Unity.Jobs.JobHandle dep28_5 = default;
            Unity.Jobs.JobHandle dep28_3 = default;
            Unity.Jobs.JobHandle dep28_6 = default;
            Unity.Jobs.JobHandle dep28_4 = default;
            Unity.Jobs.JobHandle dep28_2 = default;
            Unity.Jobs.JobHandle dep28_0 = default;
            dep28_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_28_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep28_0
            , ref dep28_2, ref dep28_4, ref dep28_6, ref dep28_3, ref dep28_5, ref dep28_7, ref dep28_9, ref dep28_8
            );
            
            dependsOn = dep28_8;
            // Dependencies scheme:
            // * dependsOn                        => dep28_0             START                            [ SKIPPED ]
            // * dep28_0                          => dep28_2             Create System                    [  BURST  ]
            // * dep28_0                          => dep28_4             Draw Gizmos System               [  BURST  ] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * dep28_0                          => dep28_6             Shadow Copy System               [  BURST  ]
            // * dep28_2                          => dep28_3             Update System                    [  BURST  ]
            // * dep28_2                          => dep28_5             Create Texture System            [  BURST  ] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * dep28_6, dep28_3                 => dep28_7             Shadow Copy Update System        [  BURST  ]
            // * dep28_7, dep28_5, dep28_4        => dep28_9             RelayNode                        [ SKIPPED ]
            // * dep28_9                          => dep28_8             System Node                      [ SKIPPED ]
            // * EXIT dependsOn = dep28_8;
            // * dep28_8                          => dependsOn       
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnDestroy_0_28_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep28_0, ref Unity.Jobs.JobHandle dep28_2, ref Unity.Jobs.JobHandle dep28_4, ref Unity.Jobs.JobHandle dep28_6, ref Unity.Jobs.JobHandle dep28_3
        , ref Unity.Jobs.JobHandle dep28_5, ref Unity.Jobs.JobHandle dep28_7, ref Unity.Jobs.JobHandle dep28_9, ref Unity.Jobs.JobHandle dep28_8) {
            {
                var input = dep28_2;
                dep28_5 = input;
                var localContext28_5 = SystemContext.Create(dt, in world, dep28_5);
                ((ME.BECS.FogOfWar.CreateTextureSystem*)(systems[3]))->OnDestroy(ref localContext28_5);
                dep28_5 = localContext28_5.dependsOn;
            }
            dep28_7 = JobsExt.CombineDependencies(dep28_6, dep28_3);
            dep28_9 = JobsExt.CombineDependencies(dep28_7, dep28_5, dep28_4);
            dep28_8 = dep28_9;
            dependsOn = dep28_8;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_28_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Logic
            var systems = (System.IntPtr*)graphNodes28_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep28_8 = default;
            Unity.Jobs.JobHandle dep28_9 = default;
            Unity.Jobs.JobHandle dep28_7 = default;
            Unity.Jobs.JobHandle dep28_5 = default;
            Unity.Jobs.JobHandle dep28_3 = default;
            Unity.Jobs.JobHandle dep28_6 = default;
            Unity.Jobs.JobHandle dep28_4 = default;
            Unity.Jobs.JobHandle dep28_2 = default;
            Unity.Jobs.JobHandle dep28_0 = default;
            dep28_0 = dependsOn;
            dep28_2 = dep28_0;
            dep28_4 = dep28_0;
            dep28_6 = dep28_0;
            dep28_3 = dep28_2;
            // BURST DISABLE CLOSE
            InnerMethodOnDestroy_0_28_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep28_0, ref dep28_2, ref dep28_4, ref dep28_6, ref dep28_3
            , ref dep28_5, ref dep28_7, ref dep28_9, ref dep28_8
            );
            
            dependsOn = dep28_8;
            // Dependencies scheme:
            // * dependsOn                        => dep28_0             START                            [ SKIPPED ]
            // * dep28_0                          => dep28_2             Create System                    [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep28_0                          => dep28_4             Draw Gizmos System               [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep28_0                          => dep28_6             Shadow Copy System               [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep28_2                          => dep28_3             Update System                    [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep28_2                          => dep28_5             Create Texture System            [NOT BURST]
            // * dep28_6, dep28_3                 => dep28_7             Shadow Copy Update System        [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep28_7, dep28_5, dep28_4        => dep28_9             RelayNode                        [ SKIPPED ]
            // * dep28_9                          => dep28_8             System Node                      [ SKIPPED ]
            // * EXIT dependsOn = dep28_8;
            // * dep28_8                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnDrawGizmos_0_28_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep28_0, ref Unity.Jobs.JobHandle dep28_2
        , ref Unity.Jobs.JobHandle dep28_4, ref Unity.Jobs.JobHandle dep28_6, ref Unity.Jobs.JobHandle dep28_3, ref Unity.Jobs.JobHandle dep28_5, ref Unity.Jobs.JobHandle dep28_7, ref Unity.Jobs.JobHandle dep28_9, ref Unity.Jobs.JobHandle dep28_8) {
            {
                var input = dep28_0;
                dep28_4 = input;
                var localContext28_4 = SystemContext.Create(dt, in world, dep28_4);
                ((ME.BECS.FogOfWar.DrawGizmosSystem*)(systems[2]))->OnDrawGizmos(ref localContext28_4);
                dep28_4 = localContext28_4.dependsOn;
            }
            dep28_6 = dep28_0;
            dep28_3 = dep28_2;
            dep28_5 = dep28_2;
            dep28_7 = JobsExt.CombineDependencies(dep28_6, dep28_3);
            dep28_9 = JobsExt.CombineDependencies(dep28_7, dep28_5, dep28_4);
            dep28_8 = dep28_9;
            dependsOn = dep28_8;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_28_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Logic
            var systems = (System.IntPtr*)graphNodes28_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep28_8 = default;
            Unity.Jobs.JobHandle dep28_9 = default;
            Unity.Jobs.JobHandle dep28_7 = default;
            Unity.Jobs.JobHandle dep28_5 = default;
            Unity.Jobs.JobHandle dep28_3 = default;
            Unity.Jobs.JobHandle dep28_6 = default;
            Unity.Jobs.JobHandle dep28_4 = default;
            Unity.Jobs.JobHandle dep28_2 = default;
            Unity.Jobs.JobHandle dep28_0 = default;
            dep28_0 = dependsOn;
            dep28_2 = dep28_0;
            // BURST ENABLE CLOSE
            InnerMethodOnDrawGizmos_0_28_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep28_0, ref dep28_2
            , ref dep28_4, ref dep28_6, ref dep28_3, ref dep28_5, ref dep28_7, ref dep28_9, ref dep28_8
            );
            
            dependsOn = dep28_8;
            // Dependencies scheme:
            // * dependsOn                        => dep28_0             START                            [ SKIPPED ]
            // * dep28_0                          => dep28_2             Create System                    [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep28_0                          => dep28_4             Draw Gizmos System               [  BURST  ]
            // * dep28_0                          => dep28_6             Shadow Copy System               [  BURST  ] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep28_2                          => dep28_3             Update System                    [  BURST  ] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep28_2                          => dep28_5             Create Texture System            [  BURST  ] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep28_6, dep28_3                 => dep28_7             Shadow Copy Update System        [  BURST  ] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep28_7, dep28_5, dep28_4        => dep28_9             RelayNode                        [ SKIPPED ]
            // * dep28_9                          => dep28_8             System Node                      [ SKIPPED ]
            // * EXIT dependsOn = dep28_8;
            // * dep28_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_28_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes28_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes29_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_29_SystemsCodeGenerator() {
            // FogOfWarGraph-Visual
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes29_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(1, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.FogOfWar.UpdateTextureSystem>.sizeInt, TAlign<ME.BECS.FogOfWar.UpdateTextureSystem>.alignInt);
                *(ME.BECS.FogOfWar.UpdateTextureSystem*)item = new ME.BECS.FogOfWar.UpdateTextureSystem {
                    fadeInSpeed = 8f,
                    fadeOutSpeed = 0.5f,
                }
                ;
                TSystemGraph.Register<ME.BECS.FogOfWar.UpdateTextureSystem>(29, item);
                graphNodes29_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_29_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep29_0             START                            [ SKIPPED ]
            // * dep29_0                          => dep29_2             Update Texture System            [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep29_2;
            // * dep29_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_29_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep29_0             START                            [ SKIPPED ]
            // * dep29_0                          => dep29_2             Update Texture System            [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep29_2;
            // * dep29_2                          => dependsOn       
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnUpdate_0_29_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep29_0
        , ref Unity.Jobs.JobHandle dep29_2) {
            {
                var input = dep29_0;
                dep29_2 = input;
                dep29_2 = Batches.Apply(dep29_2, world.state);
                var localContext29_2 = SystemContext.Create(dt, in world, dep29_2);
                ((ME.BECS.FogOfWar.UpdateTextureSystem*)(systems[0]))->OnUpdate(ref localContext29_2);
                dep29_2 = localContext29_2.dependsOn;
            }
            dependsOn = dep29_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_29_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Visual
            var systems = (System.IntPtr*)graphNodes29_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep29_2 = default;
            Unity.Jobs.JobHandle dep29_0 = default;
            dep29_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnUpdate_0_29_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep29_0
            , ref dep29_2
            );
            
            dependsOn = dep29_2;
            // Dependencies scheme:
            // * dependsOn                        => dep29_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep29_0 => dep29_2                                   [  SYNC   ]
            // * dep29_2                          => dep29_2             Update Texture System            [NOT BURST]
            // * EXIT dependsOn = dep29_2;
            // * dep29_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_29_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep29_0             START                            [ SKIPPED ]
            // * dep29_0                          => dep29_2             Update Texture System            [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep29_2;
            // * dep29_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_29_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // FogOfWarGraph-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep29_0             START                            [ SKIPPED ]
            // * dep29_0                          => dep29_2             Update Texture System            [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep29_2;
            // * dep29_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_29_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes29_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes24_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_24_SystemsCodeGenerator() {
            // Pathfinding-BuildGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes24_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(2, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Pathfinding.BuildGraphSystem>.sizeInt, TAlign<ME.BECS.Pathfinding.BuildGraphSystem>.alignInt);
                *(ME.BECS.Pathfinding.BuildGraphSystem*)item = new ME.BECS.Pathfinding.BuildGraphSystem {
                    agentTypesConfig = new ME.BECS.ObjectReference<ME.BECS.Pathfinding.AgentTypesConfig> {
                        id = 83,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<ME.BECS.Pathfinding.BuildGraphSystem>(24, item);
                graphNodes24_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Pathfinding.BuildPathSystem>.sizeInt, TAlign<ME.BECS.Pathfinding.BuildPathSystem>.alignInt);
                *(ME.BECS.Pathfinding.BuildPathSystem*)item = new ME.BECS.Pathfinding.BuildPathSystem {
                    filter = new ME.BECS.Pathfinding.Filter {
                        ignoreNonWalkable = 0,
                        flags = ME.BECS.Pathfinding.NodeFlag.None,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<ME.BECS.Pathfinding.BuildPathSystem>(24, item);
                graphNodes24_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnAwake_0_24_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep24_0
        , ref Unity.Jobs.JobHandle dep24_2, ref Unity.Jobs.JobHandle dep24_3) {
            {
                var input = dep24_0;
                dep24_2 = input;
                dep24_2 = Batches.Apply(dep24_2, world.state);
                var localContext24_2 = SystemContext.Create(dt, in world, dep24_2);
                ((ME.BECS.Pathfinding.BuildGraphSystem*)(systems[0]))->OnAwake(ref localContext24_2);
                dep24_2 = localContext24_2.dependsOn;
            }
            dep24_3 = dep24_2;
            dependsOn = dep24_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_24_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-BuildGraph
            var systems = (System.IntPtr*)graphNodes24_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep24_3 = default;
            Unity.Jobs.JobHandle dep24_2 = default;
            Unity.Jobs.JobHandle dep24_0 = default;
            dep24_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnAwake_0_24_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep24_0
            , ref dep24_2, ref dep24_3
            );
            
            dependsOn = dep24_3;
            // Dependencies scheme:
            // * dependsOn                        => dep24_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep24_0 => dep24_2                                   [  SYNC   ]
            // * dep24_2                          => dep24_2             Build Graph System               [NOT BURST]
            // * dep24_2                          => dep24_3             Build Path System                [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep24_3;
            // * dep24_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_24_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-BuildGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep24_0             START                            [ SKIPPED ]
            // * dep24_0                          => dep24_2             Build Graph System               [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep24_2                          => dep24_3             Build Path System                [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep24_3;
            // * dep24_3                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_24_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep24_0, ref Unity.Jobs.JobHandle dep24_2
        , ref Unity.Jobs.JobHandle dep24_3) {
            {
                var input = dep24_2;
                dep24_3 = input;
                dep24_3 = Batches.Apply(dep24_3, world.state);
                var localContext24_3 = SystemContext.Create(dt, in world, dep24_3);
                ((ME.BECS.Pathfinding.BuildPathSystem*)(systems[1]))->OnUpdate(ref localContext24_3);
                dep24_3 = localContext24_3.dependsOn;
            }
            dependsOn = dep24_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_24_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-BuildGraph
            var systems = (System.IntPtr*)graphNodes24_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep24_3 = default;
            Unity.Jobs.JobHandle dep24_2 = default;
            Unity.Jobs.JobHandle dep24_0 = default;
            dep24_0 = dependsOn;
            dep24_2 = dep24_0;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_24_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep24_0, ref dep24_2
            , ref dep24_3
            );
            
            dependsOn = dep24_3;
            // Dependencies scheme:
            // * dependsOn                        => dep24_0             START                            [ SKIPPED ]
            // * dep24_0                          => dep24_2             Build Graph System               [NOT BURST] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * Batches.Apply                    :  dep24_2 => dep24_3                                   [  SYNC   ]
            // * dep24_3                          => dep24_3             Build Path System                [  BURST  ]
            // * EXIT dependsOn = dep24_3;
            // * dep24_3                          => dependsOn       
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnDestroy_0_24_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep24_0
        , ref Unity.Jobs.JobHandle dep24_2, ref Unity.Jobs.JobHandle dep24_3) {
            {
                var input = dep24_0;
                dep24_2 = input;
                dep24_2 = Batches.Apply(dep24_2, world.state);
                var localContext24_2 = SystemContext.Create(dt, in world, dep24_2);
                ((ME.BECS.Pathfinding.BuildGraphSystem*)(systems[0]))->OnDestroy(ref localContext24_2);
                dep24_2 = localContext24_2.dependsOn;
            }
            dep24_3 = dep24_2;
            dependsOn = dep24_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_24_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-BuildGraph
            var systems = (System.IntPtr*)graphNodes24_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep24_3 = default;
            Unity.Jobs.JobHandle dep24_2 = default;
            Unity.Jobs.JobHandle dep24_0 = default;
            dep24_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnDestroy_0_24_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep24_0
            , ref dep24_2, ref dep24_3
            );
            
            dependsOn = dep24_3;
            // Dependencies scheme:
            // * dependsOn                        => dep24_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep24_0 => dep24_2                                   [  SYNC   ]
            // * dep24_2                          => dep24_2             Build Graph System               [NOT BURST]
            // * dep24_2                          => dep24_3             Build Path System                [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep24_3;
            // * dep24_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_24_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-BuildGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep24_0             START                            [ SKIPPED ]
            // * dep24_0                          => dep24_2             Build Graph System               [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep24_2                          => dep24_3             Build Path System                [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep24_3;
            // * dep24_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_24_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes24_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes27_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_27_SystemsCodeGenerator() {
            // Pathfinding-UpdateGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes27_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(2, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Pathfinding.FollowPathSystem>.sizeInt, TAlign<ME.BECS.Pathfinding.FollowPathSystem>.alignInt);
                *(ME.BECS.Pathfinding.FollowPathSystem*)item = new ME.BECS.Pathfinding.FollowPathSystem {
                    collisionForce = 15f,
                    cohesionForce = 0.5f,
                    separationForce = 1f,
                    alignmentForce = 0.5f,
                    movementForce = 5f,
                }
                ;
                TSystemGraph.Register<ME.BECS.Pathfinding.FollowPathSystem>(27, item);
                graphNodes27_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Pathfinding.UpdateGraphSystem>.sizeInt, TAlign<ME.BECS.Pathfinding.UpdateGraphSystem>.alignInt);
                *(ME.BECS.Pathfinding.UpdateGraphSystem*)item = new ME.BECS.Pathfinding.UpdateGraphSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Pathfinding.UpdateGraphSystem>(27, item);
                graphNodes27_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_27_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-UpdateGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep27_0             START                            [ SKIPPED ]
            // * dep27_0                          => dep27_3             Update Graph System              [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep27_3                          => dep27_2             Follow Path System               [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep27_2;
            // * dep27_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_27_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-UpdateGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep27_0             START                            [ SKIPPED ]
            // * dep27_0                          => dep27_3             Update Graph System              [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep27_3                          => dep27_2             Follow Path System               [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep27_2;
            // * dep27_2                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_27_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep27_0
        , ref Unity.Jobs.JobHandle dep27_3, ref Unity.Jobs.JobHandle dep27_2) {
            {
                var input = dep27_0;
                dep27_3 = input;
                dep27_3 = Batches.Apply(dep27_3, world.state);
                var localContext27_3 = SystemContext.Create(dt, in world, dep27_3);
                ((ME.BECS.Pathfinding.UpdateGraphSystem*)(systems[1]))->OnUpdate(ref localContext27_3);
                dep27_3 = localContext27_3.dependsOn;
            }
            {
                var input = dep27_3;
                dep27_2 = input;
                dep27_2 = Batches.Apply(dep27_2, world.state);
                var localContext27_2 = SystemContext.Create(dt, in world, dep27_2);
                ((ME.BECS.Pathfinding.FollowPathSystem*)(systems[0]))->OnUpdate(ref localContext27_2);
                dep27_2 = localContext27_2.dependsOn;
            }
            dependsOn = dep27_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_27_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-UpdateGraph
            var systems = (System.IntPtr*)graphNodes27_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep27_2 = default;
            Unity.Jobs.JobHandle dep27_3 = default;
            Unity.Jobs.JobHandle dep27_0 = default;
            dep27_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_27_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep27_0
            , ref dep27_3, ref dep27_2
            );
            
            dependsOn = dep27_2;
            // Dependencies scheme:
            // * dependsOn                        => dep27_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep27_0 => dep27_3                                   [  SYNC   ]
            // * dep27_3                          => dep27_3             Update Graph System              [  BURST  ]
            // * Batches.Apply                    :  dep27_3 => dep27_2                                   [  SYNC   ]
            // * dep27_2                          => dep27_2             Follow Path System               [  BURST  ]
            // * EXIT dependsOn = dep27_2;
            // * dep27_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_27_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-UpdateGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep27_0             START                            [ SKIPPED ]
            // * dep27_0                          => dep27_3             Update Graph System              [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep27_3                          => dep27_2             Follow Path System               [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep27_2;
            // * dep27_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_27_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-UpdateGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep27_0             START                            [ SKIPPED ]
            // * dep27_0                          => dep27_3             Update Graph System              [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep27_3                          => dep27_2             Follow Path System               [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep27_2;
            // * dep27_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_27_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes27_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes25_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_25_SystemsCodeGenerator() {
            // Pathfinding-Visual
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes25_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(1, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.sizeInt, TAlign<ME.BECS.Pathfinding.DrawGizmosGraphSystem>.alignInt);
                *(ME.BECS.Pathfinding.DrawGizmosGraphSystem*)item = new ME.BECS.Pathfinding.DrawGizmosGraphSystem {
                    drawGraph = true,
                    drawPath = true,
                    drawNormals = false,
                    drawNodes = false,
                }
                ;
                TSystemGraph.Register<ME.BECS.Pathfinding.DrawGizmosGraphSystem>(25, item);
                graphNodes25_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_25_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep25_0             START                            [ SKIPPED ]
            // * dep25_0                          => dep25_2             Draw Gizmos Graph System         [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep25_2;
            // * dep25_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_25_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep25_0             START                            [ SKIPPED ]
            // * dep25_0                          => dep25_2             Draw Gizmos Graph System         [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep25_2;
            // * dep25_2                          => dependsOn       
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnUpdate_0_25_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep25_0
        , ref Unity.Jobs.JobHandle dep25_2) {
            {
                var input = dep25_0;
                dep25_2 = input;
                dep25_2 = Batches.Apply(dep25_2, world.state);
                var localContext25_2 = SystemContext.Create(dt, in world, dep25_2);
                ((ME.BECS.Pathfinding.DrawGizmosGraphSystem*)(systems[0]))->OnUpdate(ref localContext25_2);
                dep25_2 = localContext25_2.dependsOn;
            }
            dependsOn = dep25_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_25_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-Visual
            var systems = (System.IntPtr*)graphNodes25_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep25_2 = default;
            Unity.Jobs.JobHandle dep25_0 = default;
            dep25_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnUpdate_0_25_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep25_0
            , ref dep25_2
            );
            
            dependsOn = dep25_2;
            // Dependencies scheme:
            // * dependsOn                        => dep25_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep25_0 => dep25_2                                   [  SYNC   ]
            // * dep25_2                          => dep25_2             Draw Gizmos Graph System         [NOT BURST]
            // * EXIT dependsOn = dep25_2;
            // * dep25_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_25_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep25_0             START                            [ SKIPPED ]
            // * dep25_0                          => dep25_2             Draw Gizmos Graph System         [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep25_2;
            // * dep25_2                          => dependsOn       
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnDrawGizmos_0_25_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep25_0
        , ref Unity.Jobs.JobHandle dep25_2) {
            {
                var input = dep25_0;
                dep25_2 = input;
                dep25_2 = Batches.Apply(dep25_2, world.state);
                var localContext25_2 = SystemContext.Create(dt, in world, dep25_2);
                ((ME.BECS.Pathfinding.DrawGizmosGraphSystem*)(systems[0]))->OnDrawGizmos(ref localContext25_2);
                dep25_2 = localContext25_2.dependsOn;
            }
            dependsOn = dep25_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_25_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Pathfinding-Visual
            var systems = (System.IntPtr*)graphNodes25_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep25_2 = default;
            Unity.Jobs.JobHandle dep25_0 = default;
            dep25_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnDrawGizmos_0_25_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep25_0
            , ref dep25_2
            );
            
            dependsOn = dep25_2;
            // Dependencies scheme:
            // * dependsOn                        => dep25_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep25_0 => dep25_2                                   [  SYNC   ]
            // * dep25_2                          => dep25_2             Draw Gizmos Graph System         [NOT BURST]
            // * EXIT dependsOn = dep25_2;
            // * dep25_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_25_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes25_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes32_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_32_SystemsCodeGenerator() {
            // Attack-AttackGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes32_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(7, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.SearchTargetSystem>.sizeInt, TAlign<ME.BECS.Attack.SearchTargetSystem>.alignInt);
                *(ME.BECS.Attack.SearchTargetSystem*)item = new ME.BECS.Attack.SearchTargetSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.SearchTargetSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.ReloadSystem>.sizeInt, TAlign<ME.BECS.Attack.ReloadSystem>.alignInt);
                *(ME.BECS.Attack.ReloadSystem*)item = new ME.BECS.Attack.ReloadSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.ReloadSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.FireSystem>.sizeInt, TAlign<ME.BECS.Attack.FireSystem>.alignInt);
                *(ME.BECS.Attack.FireSystem*)item = new ME.BECS.Attack.FireSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.FireSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.MoveToAttackerSystem>.sizeInt, TAlign<ME.BECS.Attack.MoveToAttackerSystem>.alignInt);
                *(ME.BECS.Attack.MoveToAttackerSystem*)item = new ME.BECS.Attack.MoveToAttackerSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.MoveToAttackerSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.CanFireSystem>.sizeInt, TAlign<ME.BECS.Attack.CanFireSystem>.alignInt);
                *(ME.BECS.Attack.CanFireSystem*)item = new ME.BECS.Attack.CanFireSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.CanFireSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.StopWhileAttackSystem>.sizeInt, TAlign<ME.BECS.Attack.StopWhileAttackSystem>.alignInt);
                *(ME.BECS.Attack.StopWhileAttackSystem*)item = new ME.BECS.Attack.StopWhileAttackSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.StopWhileAttackSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[5] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Attack.ResetCanFireSystem>.sizeInt, TAlign<ME.BECS.Attack.ResetCanFireSystem>.alignInt);
                *(ME.BECS.Attack.ResetCanFireSystem*)item = new ME.BECS.Attack.ResetCanFireSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Attack.ResetCanFireSystem>(32, item);
                graphNodes32_SystemsCodeGenerator[6] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_32_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Attack-AttackGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep32_0             START                            [ SKIPPED ]
            // * dep32_0                          => dep32_2             Search Target System             [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_0                          => dep32_3             Reload System                    [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_3                          => dep32_6             Can Fire System                  [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_2, dep32_6                 => dep32_4             Fire System                      [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_4                          => dep32_5             Move To Attacker System          [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_5                          => dep32_7             Stop While Attack System         [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep32_7                          => dep32_8             Reset Can Fire System            [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep32_8;
            // * dep32_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_32_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Attack-AttackGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep32_0             START                            [ SKIPPED ]
            // * dep32_0                          => dep32_2             Search Target System             [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_0                          => dep32_3             Reload System                    [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_3                          => dep32_6             Can Fire System                  [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_2, dep32_6                 => dep32_4             Fire System                      [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_4                          => dep32_5             Move To Attacker System          [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_5                          => dep32_7             Stop While Attack System         [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep32_7                          => dep32_8             Reset Can Fire System            [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep32_8;
            // * dep32_8                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_32_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep32_0
        , ref Unity.Jobs.JobHandle dep32_2, ref Unity.Jobs.JobHandle dep32_3, ref Unity.Jobs.JobHandle dep32_6, ref Unity.Jobs.JobHandle dep32_4, ref Unity.Jobs.JobHandle dep32_5, ref Unity.Jobs.JobHandle dep32_7, ref Unity.Jobs.JobHandle dep32_8) {
            {
                var input = dep32_0;
                dep32_2 = input;
                var localContext32_2 = SystemContext.Create(dt, in world, dep32_2);
                ((ME.BECS.Attack.SearchTargetSystem*)(systems[0]))->OnUpdate(ref localContext32_2);
                dep32_2 = localContext32_2.dependsOn;
            }
            {
                var input = dep32_0;
                dep32_3 = input;
                var localContext32_3 = SystemContext.Create(dt, in world, dep32_3);
                ((ME.BECS.Attack.ReloadSystem*)(systems[1]))->OnUpdate(ref localContext32_3);
                dep32_3 = localContext32_3.dependsOn;
            }
            {
                var input = dep32_3;
                dep32_6 = input;
                var localContext32_6 = SystemContext.Create(dt, in world, dep32_6);
                ((ME.BECS.Attack.CanFireSystem*)(systems[4]))->OnUpdate(ref localContext32_6);
                dep32_6 = localContext32_6.dependsOn;
            }
            {
                var input = JobsExt.CombineDependencies(dep32_2, dep32_6);
                dep32_4 = input;
                dep32_4 = Batches.Apply(dep32_4, world.state);
                var localContext32_4 = SystemContext.Create(dt, in world, dep32_4);
                ((ME.BECS.Attack.FireSystem*)(systems[2]))->OnUpdate(ref localContext32_4);
                dep32_4 = localContext32_4.dependsOn;
            }
            {
                var input = dep32_4;
                dep32_5 = input;
                dep32_5 = Batches.Apply(dep32_5, world.state);
                var localContext32_5 = SystemContext.Create(dt, in world, dep32_5);
                ((ME.BECS.Attack.MoveToAttackerSystem*)(systems[3]))->OnUpdate(ref localContext32_5);
                dep32_5 = localContext32_5.dependsOn;
            }
            {
                var input = dep32_5;
                dep32_7 = input;
                dep32_7 = Batches.Apply(dep32_7, world.state);
                var localContext32_7 = SystemContext.Create(dt, in world, dep32_7);
                ((ME.BECS.Attack.StopWhileAttackSystem*)(systems[5]))->OnUpdate(ref localContext32_7);
                dep32_7 = localContext32_7.dependsOn;
            }
            {
                var input = dep32_7;
                dep32_8 = input;
                dep32_8 = Batches.Apply(dep32_8, world.state);
                var localContext32_8 = SystemContext.Create(dt, in world, dep32_8);
                ((ME.BECS.Attack.ResetCanFireSystem*)(systems[6]))->OnUpdate(ref localContext32_8);
                dep32_8 = localContext32_8.dependsOn;
            }
            dependsOn = dep32_8;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_32_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Attack-AttackGraph
            var systems = (System.IntPtr*)graphNodes32_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep32_8 = default;
            Unity.Jobs.JobHandle dep32_7 = default;
            Unity.Jobs.JobHandle dep32_5 = default;
            Unity.Jobs.JobHandle dep32_4 = default;
            Unity.Jobs.JobHandle dep32_6 = default;
            Unity.Jobs.JobHandle dep32_3 = default;
            Unity.Jobs.JobHandle dep32_2 = default;
            Unity.Jobs.JobHandle dep32_0 = default;
            dep32_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_32_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep32_0
            , ref dep32_2, ref dep32_3, ref dep32_6, ref dep32_4, ref dep32_5, ref dep32_7, ref dep32_8
            );
            
            dependsOn = dep32_8;
            // Dependencies scheme:
            // * dependsOn                        => dep32_0             START                            [ SKIPPED ]
            // * dep32_0                          => dep32_2             Search Target System             [  BURST  ]
            // * dep32_0                          => dep32_3             Reload System                    [  BURST  ]
            // * dep32_3                          => dep32_6             Can Fire System                  [  BURST  ]
            // * Batches.Apply                    :  dep32_2, dep32_6 => dep32_4                          [  SYNC   ]
            // * dep32_4                          => dep32_4             Fire System                      [  BURST  ]
            // * Batches.Apply                    :  dep32_4 => dep32_5                                   [  SYNC   ]
            // * dep32_5                          => dep32_5             Move To Attacker System          [  BURST  ]
            // * Batches.Apply                    :  dep32_5 => dep32_7                                   [  SYNC   ]
            // * dep32_7                          => dep32_7             Stop While Attack System         [  BURST  ]
            // * Batches.Apply                    :  dep32_7 => dep32_8                                   [  SYNC   ]
            // * dep32_8                          => dep32_8             Reset Can Fire System            [  BURST  ]
            // * EXIT dependsOn = dep32_8;
            // * dep32_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_32_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Attack-AttackGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep32_0             START                            [ SKIPPED ]
            // * dep32_0                          => dep32_2             Search Target System             [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_0                          => dep32_3             Reload System                    [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_3                          => dep32_6             Can Fire System                  [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_2, dep32_6                 => dep32_4             Fire System                      [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_4                          => dep32_5             Move To Attacker System          [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_5                          => dep32_7             Stop While Attack System         [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep32_7                          => dep32_8             Reset Can Fire System            [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep32_8;
            // * dep32_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_32_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Attack-AttackGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep32_0             START                            [ SKIPPED ]
            // * dep32_0                          => dep32_2             Search Target System             [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_0                          => dep32_3             Reload System                    [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_3                          => dep32_6             Can Fire System                  [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_2, dep32_6                 => dep32_4             Fire System                      [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_4                          => dep32_5             Move To Attacker System          [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_5                          => dep32_7             Stop While Attack System         [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep32_7                          => dep32_8             Reset Can Fire System            [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep32_8;
            // * dep32_8                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_32_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes32_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes54_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_54_SystemsCodeGenerator() {
            // Bullets-BulletsGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes54_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(2, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Bullets.FlySystem>.sizeInt, TAlign<ME.BECS.Bullets.FlySystem>.alignInt);
                *(ME.BECS.Bullets.FlySystem*)item = new ME.BECS.Bullets.FlySystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Bullets.FlySystem>(54, item);
                graphNodes54_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Bullets.DestroySystem>.sizeInt, TAlign<ME.BECS.Bullets.DestroySystem>.alignInt);
                *(ME.BECS.Bullets.DestroySystem*)item = new ME.BECS.Bullets.DestroySystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Bullets.DestroySystem>(54, item);
                graphNodes54_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_54_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Bullets-BulletsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep54_0             START                            [ SKIPPED ]
            // * dep54_0                          => dep54_2             Fly System                       [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep54_2                          => dep54_3             Destroy System                   [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep54_3;
            // * dep54_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_54_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Bullets-BulletsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep54_0             START                            [ SKIPPED ]
            // * dep54_0                          => dep54_2             Fly System                       [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep54_2                          => dep54_3             Destroy System                   [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep54_3;
            // * dep54_3                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_54_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep54_0
        , ref Unity.Jobs.JobHandle dep54_2, ref Unity.Jobs.JobHandle dep54_3) {
            {
                var input = dep54_0;
                dep54_2 = input;
                dep54_2 = Batches.Apply(dep54_2, world.state);
                var localContext54_2 = SystemContext.Create(dt, in world, dep54_2);
                ((ME.BECS.Bullets.FlySystem*)(systems[0]))->OnUpdate(ref localContext54_2);
                dep54_2 = localContext54_2.dependsOn;
            }
            {
                var input = dep54_2;
                dep54_3 = input;
                dep54_3 = Batches.Apply(dep54_3, world.state);
                var localContext54_3 = SystemContext.Create(dt, in world, dep54_3);
                ((ME.BECS.Bullets.DestroySystem*)(systems[1]))->OnUpdate(ref localContext54_3);
                dep54_3 = localContext54_3.dependsOn;
            }
            dependsOn = dep54_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_54_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Bullets-BulletsGraph
            var systems = (System.IntPtr*)graphNodes54_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep54_3 = default;
            Unity.Jobs.JobHandle dep54_2 = default;
            Unity.Jobs.JobHandle dep54_0 = default;
            dep54_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_54_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep54_0
            , ref dep54_2, ref dep54_3
            );
            
            dependsOn = dep54_3;
            // Dependencies scheme:
            // * dependsOn                        => dep54_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep54_0 => dep54_2                                   [  SYNC   ]
            // * dep54_2                          => dep54_2             Fly System                       [  BURST  ]
            // * Batches.Apply                    :  dep54_2 => dep54_3                                   [  SYNC   ]
            // * dep54_3                          => dep54_3             Destroy System                   [  BURST  ]
            // * EXIT dependsOn = dep54_3;
            // * dep54_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_54_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Bullets-BulletsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep54_0             START                            [ SKIPPED ]
            // * dep54_0                          => dep54_2             Fly System                       [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep54_2                          => dep54_3             Destroy System                   [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep54_3;
            // * dep54_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_54_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Bullets-BulletsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep54_0             START                            [ SKIPPED ]
            // * dep54_0                          => dep54_2             Fly System                       [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep54_2                          => dep54_3             Destroy System                   [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep54_3;
            // * dep54_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_54_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes54_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes26_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_26_SystemsCodeGenerator() {
            // CommandsGraph-Logic
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes26_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(4, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Commands.CommandBuildSystem>.sizeInt, TAlign<ME.BECS.Commands.CommandBuildSystem>.alignInt);
                *(ME.BECS.Commands.CommandBuildSystem*)item = new ME.BECS.Commands.CommandBuildSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Commands.CommandBuildSystem>(26, item);
                graphNodes26_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Commands.CommandBuildUpdateSystem>.sizeInt, TAlign<ME.BECS.Commands.CommandBuildUpdateSystem>.alignInt);
                *(ME.BECS.Commands.CommandBuildUpdateSystem*)item = new ME.BECS.Commands.CommandBuildUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Commands.CommandBuildUpdateSystem>(26, item);
                graphNodes26_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Commands.CommandAttackSystem>.sizeInt, TAlign<ME.BECS.Commands.CommandAttackSystem>.alignInt);
                *(ME.BECS.Commands.CommandAttackSystem*)item = new ME.BECS.Commands.CommandAttackSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Commands.CommandAttackSystem>(26, item);
                graphNodes26_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Commands.CommandMoveSystem>.sizeInt, TAlign<ME.BECS.Commands.CommandMoveSystem>.alignInt);
                *(ME.BECS.Commands.CommandMoveSystem*)item = new ME.BECS.Commands.CommandMoveSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Commands.CommandMoveSystem>(26, item);
                graphNodes26_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_26_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // CommandsGraph-Logic
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep26_0             START                            [ SKIPPED ]
            // * dep26_0                          => dep26_2             Command Build System             [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep26_2                          => dep26_4             Command Attack System            [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep26_4                          => dep26_5             Command Move System              [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep26_5                          => dep26_3             Command Build Update System      [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep26_3;
            // * dep26_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_26_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // CommandsGraph-Logic
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep26_0             START                            [ SKIPPED ]
            // * dep26_0                          => dep26_2             Command Build System             [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep26_2                          => dep26_4             Command Attack System            [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep26_4                          => dep26_5             Command Move System              [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep26_5                          => dep26_3             Command Build Update System      [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep26_3;
            // * dep26_3                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_26_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep26_0
        , ref Unity.Jobs.JobHandle dep26_2, ref Unity.Jobs.JobHandle dep26_4, ref Unity.Jobs.JobHandle dep26_5, ref Unity.Jobs.JobHandle dep26_3) {
            {
                var input = dep26_0;
                dep26_2 = input;
                dep26_2 = Batches.Apply(dep26_2, world.state);
                var localContext26_2 = SystemContext.Create(dt, in world, dep26_2);
                ((ME.BECS.Commands.CommandBuildSystem*)(systems[0]))->OnUpdate(ref localContext26_2);
                dep26_2 = localContext26_2.dependsOn;
            }
            {
                var input = dep26_2;
                dep26_4 = input;
                dep26_4 = Batches.Apply(dep26_4, world.state);
                var localContext26_4 = SystemContext.Create(dt, in world, dep26_4);
                ((ME.BECS.Commands.CommandAttackSystem*)(systems[2]))->OnUpdate(ref localContext26_4);
                dep26_4 = localContext26_4.dependsOn;
            }
            {
                var input = dep26_4;
                dep26_5 = input;
                dep26_5 = Batches.Apply(dep26_5, world.state);
                var localContext26_5 = SystemContext.Create(dt, in world, dep26_5);
                ((ME.BECS.Commands.CommandMoveSystem*)(systems[3]))->OnUpdate(ref localContext26_5);
                dep26_5 = localContext26_5.dependsOn;
            }
            {
                var input = dep26_5;
                dep26_3 = input;
                dep26_3 = Batches.Apply(dep26_3, world.state);
                var localContext26_3 = SystemContext.Create(dt, in world, dep26_3);
                ((ME.BECS.Commands.CommandBuildUpdateSystem*)(systems[1]))->OnUpdate(ref localContext26_3);
                dep26_3 = localContext26_3.dependsOn;
            }
            dependsOn = dep26_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_26_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // CommandsGraph-Logic
            var systems = (System.IntPtr*)graphNodes26_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep26_3 = default;
            Unity.Jobs.JobHandle dep26_5 = default;
            Unity.Jobs.JobHandle dep26_4 = default;
            Unity.Jobs.JobHandle dep26_2 = default;
            Unity.Jobs.JobHandle dep26_0 = default;
            dep26_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_26_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep26_0
            , ref dep26_2, ref dep26_4, ref dep26_5, ref dep26_3
            );
            
            dependsOn = dep26_3;
            // Dependencies scheme:
            // * dependsOn                        => dep26_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep26_0 => dep26_2                                   [  SYNC   ]
            // * dep26_2                          => dep26_2             Command Build System             [  BURST  ]
            // * Batches.Apply                    :  dep26_2 => dep26_4                                   [  SYNC   ]
            // * dep26_4                          => dep26_4             Command Attack System            [  BURST  ]
            // * Batches.Apply                    :  dep26_4 => dep26_5                                   [  SYNC   ]
            // * dep26_5                          => dep26_5             Command Move System              [  BURST  ]
            // * Batches.Apply                    :  dep26_5 => dep26_3                                   [  SYNC   ]
            // * dep26_3                          => dep26_3             Command Build Update System      [  BURST  ]
            // * EXIT dependsOn = dep26_3;
            // * dep26_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_26_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // CommandsGraph-Logic
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep26_0             START                            [ SKIPPED ]
            // * dep26_0                          => dep26_2             Command Build System             [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep26_2                          => dep26_4             Command Attack System            [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep26_4                          => dep26_5             Command Move System              [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep26_5                          => dep26_3             Command Build Update System      [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep26_3;
            // * dep26_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_26_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // CommandsGraph-Logic
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep26_0             START                            [ SKIPPED ]
            // * dep26_0                          => dep26_2             Command Build System             [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep26_2                          => dep26_4             Command Attack System            [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep26_4                          => dep26_5             Command Move System              [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep26_5                          => dep26_3             Command Build Update System      [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep26_3;
            // * dep26_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_26_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes26_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes33_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_33_SystemsCodeGenerator() {
            // Units-UnitsGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes33_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(2, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.Units.DestroySystem>.sizeInt, TAlign<ME.BECS.Units.DestroySystem>.alignInt);
                *(ME.BECS.Units.DestroySystem*)item = new ME.BECS.Units.DestroySystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Units.DestroySystem>(33, item);
                graphNodes33_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Units.SteeringSystem>.sizeInt, TAlign<ME.BECS.Units.SteeringSystem>.alignInt);
                *(ME.BECS.Units.SteeringSystem*)item = new ME.BECS.Units.SteeringSystem {
                    calculateSeparation = true,
                    calculateCohesion = true,
                    calculateAlignment = true,
                    drawGizmos = true,
                }
                ;
                TSystemGraph.Register<ME.BECS.Units.SteeringSystem>(33, item);
                graphNodes33_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_33_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Units-UnitsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep33_0             START                            [ SKIPPED ]
            // * dep33_0                          => dep33_2             Destroy System                   [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep33_2                          => dep33_3             Steering System                  [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep33_3;
            // * dep33_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_33_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Units-UnitsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep33_0             START                            [ SKIPPED ]
            // * dep33_0                          => dep33_2             Destroy System                   [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep33_2                          => dep33_3             Steering System                  [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep33_3;
            // * dep33_3                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_33_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep33_0
        , ref Unity.Jobs.JobHandle dep33_2, ref Unity.Jobs.JobHandle dep33_3) {
            {
                var input = dep33_0;
                dep33_2 = input;
                dep33_2 = Batches.Apply(dep33_2, world.state);
                var localContext33_2 = SystemContext.Create(dt, in world, dep33_2);
                ((ME.BECS.Units.DestroySystem*)(systems[0]))->OnUpdate(ref localContext33_2);
                dep33_2 = localContext33_2.dependsOn;
            }
            {
                var input = dep33_2;
                dep33_3 = input;
                dep33_3 = Batches.Apply(dep33_3, world.state);
                var localContext33_3 = SystemContext.Create(dt, in world, dep33_3);
                ((ME.BECS.Units.SteeringSystem*)(systems[1]))->OnUpdate(ref localContext33_3);
                dep33_3 = localContext33_3.dependsOn;
            }
            dependsOn = dep33_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_33_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Units-UnitsGraph
            var systems = (System.IntPtr*)graphNodes33_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep33_3 = default;
            Unity.Jobs.JobHandle dep33_2 = default;
            Unity.Jobs.JobHandle dep33_0 = default;
            dep33_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_33_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep33_0
            , ref dep33_2, ref dep33_3
            );
            
            dependsOn = dep33_3;
            // Dependencies scheme:
            // * dependsOn                        => dep33_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep33_0 => dep33_2                                   [  SYNC   ]
            // * dep33_2                          => dep33_2             Destroy System                   [  BURST  ]
            // * Batches.Apply                    :  dep33_2 => dep33_3                                   [  SYNC   ]
            // * dep33_3                          => dep33_3             Steering System                  [  BURST  ]
            // * EXIT dependsOn = dep33_3;
            // * dep33_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_33_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Units-UnitsGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep33_0             START                            [ SKIPPED ]
            // * dep33_0                          => dep33_2             Destroy System                   [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep33_2                          => dep33_3             Steering System                  [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep33_3;
            // * dep33_3                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnDrawGizmos_0_33_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep33_0, ref Unity.Jobs.JobHandle dep33_2
        , ref Unity.Jobs.JobHandle dep33_3) {
            {
                var input = dep33_2;
                dep33_3 = input;
                dep33_3 = Batches.Apply(dep33_3, world.state);
                var localContext33_3 = SystemContext.Create(dt, in world, dep33_3);
                ((ME.BECS.Units.SteeringSystem*)(systems[1]))->OnDrawGizmos(ref localContext33_3);
                dep33_3 = localContext33_3.dependsOn;
            }
            dependsOn = dep33_3;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_33_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Units-UnitsGraph
            var systems = (System.IntPtr*)graphNodes33_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep33_3 = default;
            Unity.Jobs.JobHandle dep33_2 = default;
            Unity.Jobs.JobHandle dep33_0 = default;
            dep33_0 = dependsOn;
            dep33_2 = dep33_0;
            // BURST ENABLE CLOSE
            InnerMethodOnDrawGizmos_0_33_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep33_0, ref dep33_2
            , ref dep33_3
            );
            
            dependsOn = dep33_3;
            // Dependencies scheme:
            // * dependsOn                        => dep33_0             START                            [ SKIPPED ]
            // * dep33_0                          => dep33_2             Destroy System                   [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * Batches.Apply                    :  dep33_2 => dep33_3                                   [  SYNC   ]
            // * dep33_3                          => dep33_3             Steering System                  [  BURST  ]
            // * EXIT dependsOn = dep33_3;
            // * dep33_3                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_33_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes33_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes31_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_31_SystemsCodeGenerator() {
            // UnitsGraphHealthBars-Visual
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes31_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(1, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.sizeInt, TAlign<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>.alignInt);
                *(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem*)item = new ME.BECS.UnitsHealthBars.DrawHealthBarsSystem {
                    healthBarMaterial = new ME.BECS.ObjectReference<UnityEngine.Material> {
                        id = 3,
                    }
                    ,
                    barSettings = new ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.BarSettings {
                        sectionWidth = 6f,
                        height = 3f,
                        referenceScale = 0f,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem>(31, item);
                graphNodes31_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
        }
        // BURST DISABLE OPEN
        private static void InnerMethodOnAwake_0_31_SystemsCodeGenerator_NotBurst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep31_0
        , ref Unity.Jobs.JobHandle dep31_2) {
            {
                var input = dep31_0;
                dep31_2 = input;
                dep31_2 = Batches.Apply(dep31_2, world.state);
                var localContext31_2 = SystemContext.Create(dt, in world, dep31_2);
                ((ME.BECS.UnitsHealthBars.DrawHealthBarsSystem*)(systems[0]))->OnAwake(ref localContext31_2);
                dep31_2 = localContext31_2.dependsOn;
            }
            dependsOn = dep31_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_31_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // UnitsGraphHealthBars-Visual
            var systems = (System.IntPtr*)graphNodes31_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep31_2 = default;
            Unity.Jobs.JobHandle dep31_0 = default;
            dep31_0 = dependsOn;
            // BURST DISABLE CLOSE
            InnerMethodOnAwake_0_31_SystemsCodeGenerator_NotBurst(dt, in world, ref dependsOn,  systems, ref dep31_0
            , ref dep31_2
            );
            
            dependsOn = dep31_2;
            // Dependencies scheme:
            // * dependsOn                        => dep31_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep31_0 => dep31_2                                   [  SYNC   ]
            // * dep31_2                          => dep31_2             Draw Health Bars System          [NOT BURST]
            // * EXIT dependsOn = dep31_2;
            // * dep31_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_31_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // UnitsGraphHealthBars-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep31_0             START                            [ SKIPPED ]
            // * dep31_0                          => dep31_2             Draw Health Bars System          [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep31_2;
            // * dep31_2                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_31_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep31_0
        , ref Unity.Jobs.JobHandle dep31_2) {
            {
                var input = dep31_0;
                dep31_2 = input;
                dep31_2 = Batches.Apply(dep31_2, world.state);
                var localContext31_2 = SystemContext.Create(dt, in world, dep31_2);
                ((ME.BECS.UnitsHealthBars.DrawHealthBarsSystem*)(systems[0]))->OnUpdate(ref localContext31_2);
                dep31_2 = localContext31_2.dependsOn;
            }
            dependsOn = dep31_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_31_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // UnitsGraphHealthBars-Visual
            var systems = (System.IntPtr*)graphNodes31_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep31_2 = default;
            Unity.Jobs.JobHandle dep31_0 = default;
            dep31_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_31_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep31_0
            , ref dep31_2
            );
            
            dependsOn = dep31_2;
            // Dependencies scheme:
            // * dependsOn                        => dep31_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep31_0 => dep31_2                                   [  SYNC   ]
            // * dep31_2                          => dep31_2             Draw Health Bars System          [  BURST  ]
            // * EXIT dependsOn = dep31_2;
            // * dep31_2                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnDestroy_0_31_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep31_0
        , ref Unity.Jobs.JobHandle dep31_2) {
            {
                var input = dep31_0;
                dep31_2 = input;
                dep31_2 = Batches.Apply(dep31_2, world.state);
                var localContext31_2 = SystemContext.Create(dt, in world, dep31_2);
                ((ME.BECS.UnitsHealthBars.DrawHealthBarsSystem*)(systems[0]))->OnDestroy(ref localContext31_2);
                dep31_2 = localContext31_2.dependsOn;
            }
            dependsOn = dep31_2;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_31_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // UnitsGraphHealthBars-Visual
            var systems = (System.IntPtr*)graphNodes31_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep31_2 = default;
            Unity.Jobs.JobHandle dep31_0 = default;
            dep31_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnDestroy_0_31_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep31_0
            , ref dep31_2
            );
            
            dependsOn = dep31_2;
            // Dependencies scheme:
            // * dependsOn                        => dep31_0             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep31_0 => dep31_2                                   [  SYNC   ]
            // * dep31_2                          => dep31_2             Draw Health Bars System          [  BURST  ]
            // * EXIT dependsOn = dep31_2;
            // * dep31_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_31_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // UnitsGraphHealthBars-Visual
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep31_0             START                            [ SKIPPED ]
            // * dep31_0                          => dep31_2             Draw Health Bars System          [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep31_2;
            // * dep31_2                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_31_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes31_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes30_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_30_SystemsCodeGenerator() {
            // DefaultEndGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes30_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(3, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = new ME.BECS.DestroyWithLifetimeSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(30, item);
                graphNodes30_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = new ME.BECS.Transforms.TransformWorldMatrixUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(30, item);
                graphNodes30_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = new ME.BECS.DestroyWithTicksSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(30, item);
                graphNodes30_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnAwake_0_30_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep30_2, ref Unity.Jobs.JobHandle dep30_4, ref Unity.Jobs.JobHandle dep30_0
        , ref Unity.Jobs.JobHandle dep30_1) {
            {
                var input = dep30_0;
                dep30_1 = input;
                dep30_1 = Batches.Apply(dep30_1, world.state);
                var localContext30_1 = SystemContext.Create(dt, in world, dep30_1);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)(systems[1]))->OnAwake(ref localContext30_1);
                dep30_1 = localContext30_1.dependsOn;
            }
            dependsOn = dep30_1;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_30_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // DefaultEndGraph
            var systems = (System.IntPtr*)graphNodes30_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep30_1 = default;
            Unity.Jobs.JobHandle dep30_0 = default;
            Unity.Jobs.JobHandle dep30_4 = default;
            Unity.Jobs.JobHandle dep30_2 = default;
            dep30_2 = dependsOn;
            dep30_4 = dep30_2;
            dep30_0 = dep30_4;
            // BURST ENABLE CLOSE
            InnerMethodOnAwake_0_30_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep30_2, ref dep30_4, ref dep30_0
            , ref dep30_1
            );
            
            dependsOn = dep30_1;
            // Dependencies scheme:
            // * dependsOn                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IAwake was not found. Node skipped.
            // * Batches.Apply                    :  dep30_0 => dep30_1                                   [  SYNC   ]
            // * dep30_1                          => dep30_1             Transform World Matrix Update... [  BURST  ]
            // * EXIT dependsOn = dep30_1;
            // * dep30_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_30_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // DefaultEndGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep30_1;
            // * dep30_1                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_30_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep30_2
        , ref Unity.Jobs.JobHandle dep30_4, ref Unity.Jobs.JobHandle dep30_0, ref Unity.Jobs.JobHandle dep30_1) {
            {
                var input = dep30_2;
                dep30_4 = input;
                dep30_4 = Batches.Apply(dep30_4, world.state);
                var localContext30_4 = SystemContext.Create(dt, in world, dep30_4);
                ((ME.BECS.DestroyWithTicksSystem*)(systems[2]))->OnUpdate(ref localContext30_4);
                dep30_4 = localContext30_4.dependsOn;
            }
            {
                var input = dep30_4;
                dep30_0 = input;
                dep30_0 = Batches.Apply(dep30_0, world.state);
                var localContext30_0 = SystemContext.Create(dt, in world, dep30_0);
                ((ME.BECS.DestroyWithLifetimeSystem*)(systems[0]))->OnUpdate(ref localContext30_0);
                dep30_0 = localContext30_0.dependsOn;
            }
            {
                var input = dep30_0;
                dep30_1 = input;
                dep30_1 = Batches.Apply(dep30_1, world.state);
                var localContext30_1 = SystemContext.Create(dt, in world, dep30_1);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)(systems[1]))->OnUpdate(ref localContext30_1);
                dep30_1 = localContext30_1.dependsOn;
            }
            dependsOn = dep30_1;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_30_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // DefaultEndGraph
            var systems = (System.IntPtr*)graphNodes30_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep30_1 = default;
            Unity.Jobs.JobHandle dep30_0 = default;
            Unity.Jobs.JobHandle dep30_4 = default;
            Unity.Jobs.JobHandle dep30_2 = default;
            dep30_2 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_30_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep30_2
            , ref dep30_4, ref dep30_0, ref dep30_1
            );
            
            dependsOn = dep30_1;
            // Dependencies scheme:
            // * dependsOn                        => dep30_2             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep30_2 => dep30_4                                   [  SYNC   ]
            // * dep30_4                          => dep30_4             Destroy With Ticks System        [  BURST  ]
            // * Batches.Apply                    :  dep30_4 => dep30_0                                   [  SYNC   ]
            // * dep30_0                          => dep30_0             Destroy With Lifetime System     [  BURST  ]
            // * Batches.Apply                    :  dep30_0 => dep30_1                                   [  SYNC   ]
            // * dep30_1                          => dep30_1             Transform World Matrix Update... [  BURST  ]
            // * EXIT dependsOn = dep30_1;
            // * dep30_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_30_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // DefaultEndGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep30_1;
            // * dep30_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_30_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // DefaultEndGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep30_1;
            // * dep30_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_30_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes30_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes23_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_23_SystemsCodeGenerator() {
            // TreesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes23_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(2, allocator);
            {
                var item = allocator.Allocate(TSize<ME.BECS.QuadTreeInsertSystem>.sizeInt, TAlign<ME.BECS.QuadTreeInsertSystem>.alignInt);
                *(ME.BECS.QuadTreeInsertSystem*)item = new ME.BECS.QuadTreeInsertSystem {
                    mapPosition = new Unity.Mathematics.float3 {
                        x = 0f,
                        y = 0f,
                        z = 0f,
                    }
                    ,
                    mapSize = new Unity.Mathematics.float3 {
                        x = 200f,
                        y = 100f,
                        z = 200f,
                    }
                    ,
                }
                ;
                TSystemGraph.Register<ME.BECS.QuadTreeInsertSystem>(23, item);
                graphNodes23_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.QuadTreeQuerySystem>.sizeInt, TAlign<ME.BECS.QuadTreeQuerySystem>.alignInt);
                *(ME.BECS.QuadTreeQuerySystem*)item = new ME.BECS.QuadTreeQuerySystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.QuadTreeQuerySystem>(23, item);
                graphNodes23_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnAwake_0_23_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep23_2
        , ref Unity.Jobs.JobHandle dep23_0, ref Unity.Jobs.JobHandle dep23_1) {
            {
                var input = dep23_2;
                dep23_0 = input;
                dep23_0 = Batches.Apply(dep23_0, world.state);
                var localContext23_0 = SystemContext.Create(dt, in world, dep23_0);
                ((ME.BECS.QuadTreeInsertSystem*)(systems[0]))->OnAwake(ref localContext23_0);
                dep23_0 = localContext23_0.dependsOn;
            }
            dep23_1 = dep23_0;
            dependsOn = dep23_1;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_23_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // TreesGraph
            var systems = (System.IntPtr*)graphNodes23_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep23_1 = default;
            Unity.Jobs.JobHandle dep23_0 = default;
            Unity.Jobs.JobHandle dep23_2 = default;
            dep23_2 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnAwake_0_23_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep23_2
            , ref dep23_0, ref dep23_1
            );
            
            dependsOn = dep23_1;
            // Dependencies scheme:
            // * dependsOn                        => dep23_2             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep23_2 => dep23_0                                   [  SYNC   ]
            // * dep23_0                          => dep23_0             Quad Tree Insert System          [  BURST  ]
            // * dep23_0                          => dep23_1             Quad Tree Query System           [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * EXIT dependsOn = dep23_1;
            // * dep23_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_23_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // TreesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep23_2             START                            [ SKIPPED ]
            // * dep23_2                          => dep23_0             Quad Tree Insert System          [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep23_0                          => dep23_1             Quad Tree Query System           [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dependsOn = dep23_1;
            // * dep23_1                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_23_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep23_2
        , ref Unity.Jobs.JobHandle dep23_0, ref Unity.Jobs.JobHandle dep23_1) {
            {
                var input = dep23_2;
                dep23_0 = input;
                dep23_0 = Batches.Apply(dep23_0, world.state);
                var localContext23_0 = SystemContext.Create(dt, in world, dep23_0);
                ((ME.BECS.QuadTreeInsertSystem*)(systems[0]))->OnUpdate(ref localContext23_0);
                dep23_0 = localContext23_0.dependsOn;
            }
            {
                var input = dep23_0;
                dep23_1 = input;
                dep23_1 = Batches.Apply(dep23_1, world.state);
                var localContext23_1 = SystemContext.Create(dt, in world, dep23_1);
                ((ME.BECS.QuadTreeQuerySystem*)(systems[1]))->OnUpdate(ref localContext23_1);
                dep23_1 = localContext23_1.dependsOn;
            }
            dependsOn = dep23_1;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_23_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // TreesGraph
            var systems = (System.IntPtr*)graphNodes23_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep23_1 = default;
            Unity.Jobs.JobHandle dep23_0 = default;
            Unity.Jobs.JobHandle dep23_2 = default;
            dep23_2 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_23_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep23_2
            , ref dep23_0, ref dep23_1
            );
            
            dependsOn = dep23_1;
            // Dependencies scheme:
            // * dependsOn                        => dep23_2             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep23_2 => dep23_0                                   [  SYNC   ]
            // * dep23_0                          => dep23_0             Quad Tree Insert System          [  BURST  ]
            // * Batches.Apply                    :  dep23_0 => dep23_1                                   [  SYNC   ]
            // * dep23_1                          => dep23_1             Quad Tree Query System           [  BURST  ]
            // * EXIT dependsOn = dep23_1;
            // * dep23_1                          => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnDestroy_0_23_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep23_2
        , ref Unity.Jobs.JobHandle dep23_0, ref Unity.Jobs.JobHandle dep23_1) {
            {
                var input = dep23_2;
                dep23_0 = input;
                dep23_0 = Batches.Apply(dep23_0, world.state);
                var localContext23_0 = SystemContext.Create(dt, in world, dep23_0);
                ((ME.BECS.QuadTreeInsertSystem*)(systems[0]))->OnDestroy(ref localContext23_0);
                dep23_0 = localContext23_0.dependsOn;
            }
            dep23_1 = dep23_0;
            dependsOn = dep23_1;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_23_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // TreesGraph
            var systems = (System.IntPtr*)graphNodes23_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep23_1 = default;
            Unity.Jobs.JobHandle dep23_0 = default;
            Unity.Jobs.JobHandle dep23_2 = default;
            dep23_2 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnDestroy_0_23_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep23_2
            , ref dep23_0, ref dep23_1
            );
            
            dependsOn = dep23_1;
            // Dependencies scheme:
            // * dependsOn                        => dep23_2             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep23_2 => dep23_0                                   [  SYNC   ]
            // * dep23_0                          => dep23_0             Quad Tree Insert System          [  BURST  ]
            // * dep23_0                          => dep23_1             Quad Tree Query System           [  BURST  ] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dependsOn = dep23_1;
            // * dep23_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_23_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // TreesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep23_2             START                            [ SKIPPED ]
            // * dep23_2                          => dep23_0             Quad Tree Insert System          [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep23_0                          => dep23_1             Quad Tree Query System           [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dependsOn = dep23_1;
            // * dep23_1                          => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_23_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes23_SystemsCodeGenerator[index];
        }
        private static NativeArray<System.IntPtr> graphNodes1001_SystemsCodeGenerator;
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.InitializeGraph))]
        public static void GraphInitialize_1001_SystemsCodeGenerator() {
            // Sample-FeaturesGraph
            var allocator = (AllocatorManager.AllocatorHandle)Constants.ALLOCATOR_DOMAIN;
            graphNodes1001_SystemsCodeGenerator = CollectionHelper.CreateNativeArray<System.IntPtr>(5, allocator);
            {
                var item = allocator.Allocate(TSize<Sample.SpawnEntitiesSystem>.sizeInt, TAlign<Sample.SpawnEntitiesSystem>.alignInt);
                *(Sample.SpawnEntitiesSystem*)item = new Sample.SpawnEntitiesSystem {
                    testConfig = new ME.BECS.Config {
                        sourceId = 6,
                    }
                    ,
                    count = 10000,
                }
                ;
                TSystemGraph.Register<Sample.SpawnEntitiesSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[0] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<Sample.FilterEntitiesSystem>.sizeInt, TAlign<Sample.FilterEntitiesSystem>.alignInt);
                *(Sample.FilterEntitiesSystem*)item = new Sample.FilterEntitiesSystem {
                }
                ;
                TSystemGraph.Register<Sample.FilterEntitiesSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[1] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithLifetimeSystem>.sizeInt, TAlign<ME.BECS.DestroyWithLifetimeSystem>.alignInt);
                *(ME.BECS.DestroyWithLifetimeSystem*)item = new ME.BECS.DestroyWithLifetimeSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithLifetimeSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[2] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.sizeInt, TAlign<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>.alignInt);
                *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)item = new ME.BECS.Transforms.TransformWorldMatrixUpdateSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[3] = (System.IntPtr)item;
            }
            {
                var item = allocator.Allocate(TSize<ME.BECS.DestroyWithTicksSystem>.sizeInt, TAlign<ME.BECS.DestroyWithTicksSystem>.alignInt);
                *(ME.BECS.DestroyWithTicksSystem*)item = new ME.BECS.DestroyWithTicksSystem {
                }
                ;
                TSystemGraph.Register<ME.BECS.DestroyWithTicksSystem>(1001, item);
                graphNodes1001_SystemsCodeGenerator[4] = (System.IntPtr)item;
            }
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnAwake_0_1001_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep1001_0
        , ref Unity.Jobs.JobHandle dep1001_2, ref Unity.Jobs.JobHandle dep1001_3, ref Unity.Jobs.JobHandle dep30_2, ref Unity.Jobs.JobHandle dep1001_4, ref Unity.Jobs.JobHandle dep30_4, ref Unity.Jobs.JobHandle dep30_0, ref Unity.Jobs.JobHandle dep30_1) {
            {
                var input = dep1001_0;
                dep1001_2 = input;
                dep1001_2 = Batches.Apply(dep1001_2, world.state);
                var localContext1001_2 = SystemContext.Create(dt, in world, dep1001_2);
                ((Sample.SpawnEntitiesSystem*)(systems[0]))->OnAwake(ref localContext1001_2);
                dep1001_2 = localContext1001_2.dependsOn;
            }
            dep1001_3 = dep1001_2;
            dep30_2 = dep1001_3;
            dep30_4 = dep30_2;
            dep30_0 = dep30_4;
            {
                var input = dep30_0;
                dep30_1 = input;
                dep30_1 = Batches.Apply(dep30_1, world.state);
                var localContext30_1 = SystemContext.Create(dt, in world, dep30_1);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)(systems[3]))->OnAwake(ref localContext30_1);
                dep30_1 = localContext30_1.dependsOn;
            }
            dep1001_4 = dep30_1;
            dependsOn = dep1001_4;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnAwake))]
        public static void GraphOnAwake_1001_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Sample-FeaturesGraph
            var systems = (System.IntPtr*)graphNodes1001_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep30_1 = default;
            Unity.Jobs.JobHandle dep30_0 = default;
            Unity.Jobs.JobHandle dep30_4 = default;
            Unity.Jobs.JobHandle dep1001_4 = default;
            Unity.Jobs.JobHandle dep30_2 = default;
            Unity.Jobs.JobHandle dep1001_3 = default;
            Unity.Jobs.JobHandle dep1001_2 = default;
            Unity.Jobs.JobHandle dep1001_0 = default;
            dep1001_0 = dependsOn;
            // BURST ENABLE CLOSE
            InnerMethodOnAwake_0_1001_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep1001_0
            , ref dep1001_2, ref dep1001_3, ref dep30_2, ref dep1001_4, ref dep30_4, ref dep30_0, ref dep30_1
            );
            
            dependsOn = dep1001_4;
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0           START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep1001_0 => dep1001_2                               [  SYNC   ]
            // * dep1001_2                        => dep1001_2           Spawn Entities System            [  BURST  ]
            // * dep1001_2                        => dep1001_3           Filter Entities System           [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep1001_3                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [  BURST  ] - Method ME.BECS.IAwake was not found. Node skipped.
            // * Batches.Apply                    :  dep30_0 => dep30_1                                   [  SYNC   ]
            // * dep30_1                          => dep30_1             Transform World Matrix Update... [  BURST  ]
            // * EXIT dep1001_4 = dep30_1;
            // * EXIT dependsOn = dep1001_4;
            // * dep1001_4                        => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnStart))]
        public static void GraphOnStart_1001_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Sample-FeaturesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0           START                            [ SKIPPED ]
            // * dep1001_0                        => dep1001_2           Spawn Entities System            [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep1001_2                        => dep1001_3           Filter Entities System           [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep1001_3                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IStart was not found. Node skipped.
            // * EXIT dep1001_4 = dep30_1;
            // * EXIT dependsOn = dep1001_4;
            // * dep1001_4                        => dependsOn       
        }
        // BURST ENABLE OPEN
        [BURST] private static void InnerMethodOnUpdate_0_1001_SystemsCodeGenerator_Burst(float dt, in World world, ref Unity.Jobs.JobHandle dependsOn, System.IntPtr* systems, ref Unity.Jobs.JobHandle dep1001_0, ref Unity.Jobs.JobHandle dep1001_2
        , ref Unity.Jobs.JobHandle dep1001_3, ref Unity.Jobs.JobHandle dep30_2, ref Unity.Jobs.JobHandle dep1001_4, ref Unity.Jobs.JobHandle dep30_4, ref Unity.Jobs.JobHandle dep30_0, ref Unity.Jobs.JobHandle dep30_1) {
            {
                var input = dep1001_2;
                dep1001_3 = input;
                dep1001_3 = Batches.Apply(dep1001_3, world.state);
                var localContext1001_3 = SystemContext.Create(dt, in world, dep1001_3);
                ((Sample.FilterEntitiesSystem*)(systems[1]))->OnUpdate(ref localContext1001_3);
                dep1001_3 = localContext1001_3.dependsOn;
            }
            dep30_2 = dep1001_3;
            {
                var input = dep30_2;
                dep30_4 = input;
                dep30_4 = Batches.Apply(dep30_4, world.state);
                var localContext30_4 = SystemContext.Create(dt, in world, dep30_4);
                ((ME.BECS.DestroyWithTicksSystem*)(systems[4]))->OnUpdate(ref localContext30_4);
                dep30_4 = localContext30_4.dependsOn;
            }
            {
                var input = dep30_4;
                dep30_0 = input;
                dep30_0 = Batches.Apply(dep30_0, world.state);
                var localContext30_0 = SystemContext.Create(dt, in world, dep30_0);
                ((ME.BECS.DestroyWithLifetimeSystem*)(systems[2]))->OnUpdate(ref localContext30_0);
                dep30_0 = localContext30_0.dependsOn;
            }
            {
                var input = dep30_0;
                dep30_1 = input;
                dep30_1 = Batches.Apply(dep30_1, world.state);
                var localContext30_1 = SystemContext.Create(dt, in world, dep30_1);
                ((ME.BECS.Transforms.TransformWorldMatrixUpdateSystem*)(systems[3]))->OnUpdate(ref localContext30_1);
                dep30_1 = localContext30_1.dependsOn;
            }
            dep1001_4 = dep30_1;
            dependsOn = dep1001_4;
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnUpdate))]
        public static void GraphOnUpdate_1001_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Sample-FeaturesGraph
            var systems = (System.IntPtr*)graphNodes1001_SystemsCodeGenerator.GetUnsafePtr();
            Unity.Jobs.JobHandle dep30_1 = default;
            Unity.Jobs.JobHandle dep30_0 = default;
            Unity.Jobs.JobHandle dep30_4 = default;
            Unity.Jobs.JobHandle dep1001_4 = default;
            Unity.Jobs.JobHandle dep30_2 = default;
            Unity.Jobs.JobHandle dep1001_3 = default;
            Unity.Jobs.JobHandle dep1001_2 = default;
            Unity.Jobs.JobHandle dep1001_0 = default;
            dep1001_0 = dependsOn;
            dep1001_2 = dep1001_0;
            // BURST ENABLE CLOSE
            InnerMethodOnUpdate_0_1001_SystemsCodeGenerator_Burst(dt, in world, ref dependsOn,  systems, ref dep1001_0, ref dep1001_2
            , ref dep1001_3, ref dep30_2, ref dep1001_4, ref dep30_4, ref dep30_0, ref dep30_1
            );
            
            dependsOn = dep1001_4;
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0           START                            [ SKIPPED ]
            // * dep1001_0                        => dep1001_2           Spawn Entities System            [NOT BURST] - Method ME.BECS.IUpdate was not found. Node skipped.
            // * Batches.Apply                    :  dep1001_2 => dep1001_3                               [  SYNC   ]
            // * dep1001_3                        => dep1001_3           Filter Entities System           [  BURST  ]
            // * dep1001_3                        => dep30_2             START                            [ SKIPPED ]
            // * Batches.Apply                    :  dep30_2 => dep30_4                                   [  SYNC   ]
            // * dep30_4                          => dep30_4             Destroy With Ticks System        [  BURST  ]
            // * Batches.Apply                    :  dep30_4 => dep30_0                                   [  SYNC   ]
            // * dep30_0                          => dep30_0             Destroy With Lifetime System     [  BURST  ]
            // * Batches.Apply                    :  dep30_0 => dep30_1                                   [  SYNC   ]
            // * dep30_1                          => dep30_1             Transform World Matrix Update... [  BURST  ]
            // * EXIT dep1001_4 = dep30_1;
            // * EXIT dependsOn = dep1001_4;
            // * dep1001_4                        => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDestroy))]
        public static void GraphOnDestroy_1001_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Sample-FeaturesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0           START                            [ SKIPPED ]
            // * dep1001_0                        => dep1001_2           Spawn Entities System            [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep1001_2                        => dep1001_3           Filter Entities System           [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep1001_3                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IDestroy was not found. Node skipped.
            // * EXIT dep1001_4 = dep30_1;
            // * EXIT dependsOn = dep1001_4;
            // * dep1001_4                        => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.OnDrawGizmos))]
        public static void GraphOnDrawGizmos_1001_SystemsCodeGenerator(float dt, ref World world, ref Unity.Jobs.JobHandle dependsOn) {
            // Sample-FeaturesGraph
            // All graph's nodes were skipped
            // Dependencies scheme:
            // * dependsOn                        => dep1001_0           START                            [ SKIPPED ]
            // * dep1001_0                        => dep1001_2           Spawn Entities System            [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep1001_2                        => dep1001_3           Filter Entities System           [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep1001_3                        => dep30_2             START                            [ SKIPPED ]
            // * dep30_2                          => dep30_4             Destroy With Ticks System        [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_4                          => dep30_0             Destroy With Lifetime System     [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * dep30_0                          => dep30_1             Transform World Matrix Update... [NOT BURST] - Method ME.BECS.IDrawGizmos was not found. Node skipped.
            // * EXIT dep1001_4 = dep30_1;
            // * EXIT dependsOn = dep1001_4;
            // * dep1001_4                        => dependsOn       
        }
        [AOT.MonoPInvokeCallback(typeof(SystemsStatic.GetSystem))]
        public static void GraphGetSystem_1001_SystemsCodeGenerator(int index, out void* ptr) {
            ptr = (void*)graphNodes1001_SystemsCodeGenerator[index];
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType.BeforeSplashScreen)]
        public static void Initialize() {
            CustomModules.RegisterFirstPass(SystemsLoad);
        }
        [UnityEngine.Scripting.PreserveAttribute]
        public static void SystemsLoad() {
            // Graph: FogOfWarGraph-Logic
            {
                SystemsStatic.RegisterMethod(GraphInitialize_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_28_SystemsCodeGenerator, 28, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_28_SystemsCodeGenerator, 28, false);
            }
            // Graph: FogOfWarGraph-Visual
            {
                SystemsStatic.RegisterMethod(GraphInitialize_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_29_SystemsCodeGenerator, 29, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_29_SystemsCodeGenerator, 29, false);
            }
            // Graph: Pathfinding-BuildGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_24_SystemsCodeGenerator, 24, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_24_SystemsCodeGenerator, 24, false);
            }
            // Graph: Pathfinding-UpdateGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_27_SystemsCodeGenerator, 27, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_27_SystemsCodeGenerator, 27, false);
            }
            // Graph: Pathfinding-Visual
            {
                SystemsStatic.RegisterMethod(GraphInitialize_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_25_SystemsCodeGenerator, 25, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_25_SystemsCodeGenerator, 25, false);
            }
            // Graph: Attack-AttackGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_32_SystemsCodeGenerator, 32, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_32_SystemsCodeGenerator, 32, false);
            }
            // Graph: Bullets-BulletsGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_54_SystemsCodeGenerator, 54, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_54_SystemsCodeGenerator, 54, false);
            }
            // Graph: CommandsGraph-Logic
            {
                SystemsStatic.RegisterMethod(GraphInitialize_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_26_SystemsCodeGenerator, 26, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_26_SystemsCodeGenerator, 26, false);
            }
            // Graph: Units-UnitsGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_33_SystemsCodeGenerator, 33, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_33_SystemsCodeGenerator, 33, false);
            }
            // Graph: UnitsGraphHealthBars-Visual
            {
                SystemsStatic.RegisterMethod(GraphInitialize_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_31_SystemsCodeGenerator, 31, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_31_SystemsCodeGenerator, 31, false);
            }
            // Graph: DefaultEndGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_30_SystemsCodeGenerator, 30, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_30_SystemsCodeGenerator, 30, false);
            }
            // Graph: TreesGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_23_SystemsCodeGenerator, 23, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_23_SystemsCodeGenerator, 23, false);
            }
            // Graph: Sample-FeaturesGraph
            {
                SystemsStatic.RegisterMethod(GraphInitialize_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterAwakeMethod(GraphOnAwake_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterStartMethod(GraphOnStart_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterUpdateMethod(GraphOnUpdate_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterDrawGizmosMethod(GraphOnDrawGizmos_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterDestroyMethod(GraphOnDestroy_1001_SystemsCodeGenerator, 1001, false);
                SystemsStatic.RegisterGetSystemMethod(GraphGetSystem_1001_SystemsCodeGenerator, 1001, false);
            }
        }
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1 { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData2 { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData3 { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData4 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public RefRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData5 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData6 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData7 { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            public RefRW<ME.BECS.Players.OwnerComponent> c2;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData8 { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            public RefRW<ME.BECS.Players.OwnerComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData9 { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopySystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData10 { // Sample.FilterEntitiesSystem+JobSetTest
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public Sample.FilterEntitiesSystem.JobSetTest jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<Sample.TestComponent> c0;
            public SafetyComponentContainerWO<Sample.TestComponent> Sample_TestComponent;
        }
        public struct JobDebugData11 { // ME.BECS.Units.HitSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.HitSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Units.DamageTookComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData12 { // ME.BECS.Views.Jobs+JobAddToScene
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAddToScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.IsViewRequested> c0;
            public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData13 { // ME.BECS.Views.Jobs+JobAssignViews
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAssignViews jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.AssignViewComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent> ME_BECS_Views_AssignViewComponent;
            public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData14 { // ME.BECS.Views.Jobs+JobRemoveFromScene
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobRemoveFromScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Views.ViewComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData15 { // ME.BECS.DestroyWithTicksSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithTicksSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.DestroyWithTicks> c0;
            public SafetyComponentContainerRO<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData16 { // ME.BECS.DestroyWithLifetimeSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.DestroyWithLifetime> c0;
            public SafetyComponentContainerRO<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData17 { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.TargetPathComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData18 { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.TargetComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData19 { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Pathfinding.GraphMaskComponent> c0;
            public RefRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> ME_BECS_Pathfinding_GraphMaskRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent> ME_BECS_Pathfinding_IsGraphMaskDirtyComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData20 { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Commands.BuildingInProgress> c0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
        }
        public struct JobDebugData21 { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Commands.BuildInProgress> c0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData22 { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            public SafetyComponentContainerRO<ME.BECS.Views.CameraComponent> ME_BECS_Views_CameraComponent;
        }
        public struct JobDebugData23 { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Players.TeamAspect a0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData24 { // ME.BECS.FogOfWar.CreateSystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Players.TeamAspect a0;
            public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData25 { // Sample.FilterEntitiesSystem+JobMove
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public Sample.FilterEntitiesSystem.JobMove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData26 { // ME.BECS.QuadTreeQuerySystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeQuerySystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeQueryAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData27 { // ME.BECS.QuadTreeInsertSystem+CollectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData28 { // ME.BECS.Units.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent> ME_BECS_Units_SelectionGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent> ME_BECS_Units_UnitEffectOnDestroyComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent> ME_BECS_Units_UnitSelectionGroupComponent;
        }
        public struct JobDebugData29 { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringWithAvoidanceSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData30 { // ME.BECS.Units.SteeringSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData31 { // ME.BECS.Bullets.FlySystem+FlyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.FlySystem.FlyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Bullets.BulletAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent> ME_BECS_Bullets_TargetReachedComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData32 { // ME.BECS.Bullets.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Bullets.BulletAspect a0;
            public ME.BECS.QuadTreeQueryAspect a1;
            public ME.BECS.Transforms.TransformAspect a2;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy> ME_BECS_Bullets_BulletEffectOnDestroy;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent> ME_BECS_Units_UnitEffectOnHitComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData33 { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData34 { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData35 { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData36 { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData37 { // ME.BECS.Pathfinding.LookAtSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.LookAtSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public ME.BECS.Units.UnitAspect a1;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        public struct JobDebugData38 { // ME.BECS.Commands.CommandMoveSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandMoveSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData39 { // ME.BECS.Commands.CommandAttackSystem+MoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.MoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
        }
        public struct JobDebugData40 { // ME.BECS.Commands.CommandBuildSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitCommandGroupAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild> ME_BECS_Commands_CommandBuild;
            public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData41 { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData42 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData43 { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.IdleJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        public struct JobDebugData44 { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRemove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData45 { // ME.BECS.Attack.StopWhileAttackSystem+JobRotate
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRotate jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
        }
        public struct JobDebugData46 { // ME.BECS.Attack.ReloadSystem+ReloadJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ReloadSystem.ReloadJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        public struct JobDebugData47 { // ME.BECS.Attack.FireSystem+FireJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public ME.BECS.QuadTreeQueryAspect a2;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData48 { // ME.BECS.Attack.ResetCanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ResetCanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
        }
        public struct JobDebugData49 { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.QuadTreeQueryAspect a1;
            public ME.BECS.Transforms.TransformAspect a2;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData50 { // ME.BECS.Attack.CanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.CanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        public struct JobDebugData51 { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent> ME_BECS_Attack_RotateAttackSensorComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData52 { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.QuadTreeQueryAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public RefRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> c0;
            public SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData53 { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Transforms.TransformAspect a0;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public RefRW<ME.BECS.Transforms.IsFirstLevelComponent> c1;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData54 { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public ME.BECS.Transforms.TransformAspect a1;
            public RefRW<ME.BECS.Units.DamageTookEvent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        public struct JobDebugData55 { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobSet jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Attack.AttackAspect a0;
            public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData56 { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Units.UnitAspect a0;
            public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        #endif
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData2Unsafe { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData3Unsafe { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent> ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag> ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
        }
        public struct JobDebugData4Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData5Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData6Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData7Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> c1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent> ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent> ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData8Unsafe { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.UpdateSystem.RevealRectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Players.OwnerComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent> ME_BECS_FogOfWar_FogOfWarRevealerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData9Unsafe { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.ShadowCopySystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData10Unsafe { // Sample.FilterEntitiesSystem+JobSetTest
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public Sample.FilterEntitiesSystem.JobSetTest jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<Sample.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerWO<Sample.TestComponent> Sample_TestComponent;
        }
        public struct JobDebugData11Unsafe { // ME.BECS.Units.HitSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.HitSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Units.DamageTookComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData12Unsafe { // ME.BECS.Views.Jobs+JobAddToScene
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAddToScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.IsViewRequested> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData13Unsafe { // ME.BECS.Views.Jobs+JobAssignViews
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobAssignViews jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.AssignViewComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent> ME_BECS_Views_AssignViewComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData14Unsafe { // ME.BECS.Views.Jobs+JobRemoveFromScene
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Views.Jobs.JobRemoveFromScene jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Views.ViewComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData15Unsafe { // ME.BECS.DestroyWithTicksSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithTicksSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.DestroyWithTicks> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData16Unsafe { // ME.BECS.DestroyWithLifetimeSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.DestroyWithLifetimeSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.DestroyWithLifetime> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData17Unsafe { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.TargetPathComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData18Unsafe { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.TargetComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
        }
        public struct JobDebugData19Unsafe { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.GraphMaskComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent> ME_BECS_Pathfinding_GraphMaskRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent> ME_BECS_Pathfinding_IsGraphMaskDirtyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData20Unsafe { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.BuildingInProgress> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
        }
        public struct JobDebugData21Unsafe { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.BuildInProgress> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData22Unsafe { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent> ME_BECS_FogOfWar_FogOfWarStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Views.CameraComponent> ME_BECS_Views_CameraComponent;
        }
        public struct JobDebugData23Unsafe { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Players.TeamAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData24Unsafe { // ME.BECS.FogOfWar.CreateSystem+CreateJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.CreateSystem.CreateJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Players.TeamAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent> ME_BECS_FogOfWar_FogOfWarComponent;
        }
        public struct JobDebugData25Unsafe { // Sample.FilterEntitiesSystem+JobMove
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public Sample.FilterEntitiesSystem.JobMove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
        }
        public struct JobDebugData26Unsafe { // ME.BECS.QuadTreeQuerySystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeQuerySystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData27Unsafe { // ME.BECS.QuadTreeInsertSystem+CollectJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.QuadTreeInsertSystem.CollectJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeElement> ME_BECS_QuadTreeElement;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData28Unsafe { // ME.BECS.Units.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent> ME_BECS_Units_SelectionGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent> ME_BECS_Units_UnitEffectOnDestroyComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent> ME_BECS_Units_UnitSelectionGroupComponent;
        }
        public struct JobDebugData29Unsafe { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringWithAvoidanceSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData30Unsafe { // ME.BECS.Units.SteeringSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Units.SteeringSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData31Unsafe { // ME.BECS.Bullets.FlySystem+FlyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.FlySystem.FlyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Bullets.BulletAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent> ME_BECS_Bullets_TargetReachedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData32Unsafe { // ME.BECS.Bullets.DestroySystem+DestroyJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Bullets.DestroySystem.DestroyJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Bullets.BulletAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy> ME_BECS_Bullets_BulletEffectOnDestroy;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithTicks> ME_BECS_DestroyWithTicks;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent> ME_BECS_Units_DamageTookComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent> ME_BECS_Units_UnitEffectOnHitComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData33Unsafe { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData34Unsafe { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData35Unsafe { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
        }
        public struct JobDebugData36Unsafe { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent> ME_BECS_Pathfinding_AgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent> ME_BECS_Units_NavAgentRuntimeSpeedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData37Unsafe { // ME.BECS.Pathfinding.LookAtSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Pathfinding.LookAtSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        public struct JobDebugData38Unsafe { // ME.BECS.Commands.CommandMoveSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandMoveSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData39Unsafe { // ME.BECS.Commands.CommandAttackSystem+MoveJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.MoveJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
        }
        public struct JobDebugData40Unsafe { // ME.BECS.Commands.CommandBuildSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandBuildSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitCommandGroupAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress> ME_BECS_Commands_BuildingInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress> ME_BECS_Commands_BuildInProgress;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild> ME_BECS_Commands_CommandBuild;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.IsInactive> ME_BECS_IsInactive;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent> ME_BECS_Pathfinding_GraphMaskComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
        }
        public struct JobDebugData41Unsafe { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Commands.CommandAttackSystem.CleanUpJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack> ME_BECS_Commands_CommandAttack;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData42Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData43Unsafe { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.IdleJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
        }
        public struct JobDebugData44Unsafe { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRemove jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData45Unsafe { // ME.BECS.Attack.StopWhileAttackSystem+JobRotate
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobRotate jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
        }
        public struct JobDebugData46Unsafe { // ME.BECS.Attack.ReloadSystem+ReloadJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ReloadSystem.ReloadJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        public struct JobDebugData47Unsafe { // ME.BECS.Attack.FireSystem+FireJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.FireSystem.FireJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent> ME_BECS_Bullets_BulletConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent> ME_BECS_Bullets_BulletRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Bullets.FirePointComponent> ME_BECS_Bullets_FirePointComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime> ME_BECS_DestroyWithLifetime;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.EntityConfigComponent> ME_BECS_EntityConfigComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent> ME_BECS_Players_OwnerChangedEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent> ME_BECS_Players_OwnerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent> ME_BECS_Players_PlayerComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent> ME_BECS_Units_UnitQuadSizeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested> ME_BECS_Views_IsViewRequested;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Views.ViewComponent> ME_BECS_Views_ViewComponent;
        }
        public struct JobDebugData48Unsafe { // ME.BECS.Attack.ResetCanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.ResetCanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
        }
        public struct JobDebugData49Unsafe { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.SearchTargetSystem.SearchTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a1;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a2;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent> ME_BECS_Units_UnitHealthComponent;
        }
        public struct JobDebugData50Unsafe { // ME.BECS.Attack.CanFireSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.CanFireSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent> ME_BECS_Attack_AttackRuntimeFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent> ME_BECS_Attack_AttackRuntimeReloadComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent> ME_BECS_Attack_CanFireComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent> ME_BECS_Attack_FireUsedComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent> ME_BECS_Attack_ReloadedComponent;
        }
        public struct JobDebugData51Unsafe { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent> ME_BECS_Attack_RotateAttackSensorComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData52Unsafe { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.QuadTreeQueryAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter> ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeQuery> ME_BECS_QuadTreeQuery;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.QuadTreeResult> ME_BECS_QuadTreeResult;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData53Unsafe { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.IsFirstLevelComponent> c1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
        }
        public struct JobDebugData54Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Transforms.TransformAspect a1;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Units.DamageTookEvent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Commands.CommandMove> ME_BECS_Commands_CommandMove;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent> ME_BECS_Units_DamageTookEvent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty> ME_BECS_Units_IsCommandGroupDirty;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        public struct JobDebugData55Unsafe { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.StopWhileAttackSystem.JobSet jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Attack.AttackAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Transforms.ParentComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent> ME_BECS_Attack_AttackTargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent> ME_BECS_Units_UnitHoldComponent;
        }
        public struct JobDebugData56Unsafe { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleMode scheduleMode;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Units.UnitAspect a0;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Commands.UnitAttackCommandComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent> ME_BECS_Attack_AttackComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent> ME_BECS_Attack_AttackFilterComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent> ME_BECS_Commands_UnitAttackCommandComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent> ME_BECS_Pathfinding_RootGraphComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent> ME_BECS_Pathfinding_TargetComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent> ME_BECS_Pathfinding_TargetInfoComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent> ME_BECS_Pathfinding_TargetPathComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent> ME_BECS_Transforms_ChildrenComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent> ME_BECS_Transforms_IsFirstLevelComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent> ME_BECS_Transforms_LocalPositionComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent> ME_BECS_Transforms_LocalRotationComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent> ME_BECS_Transforms_LocalScaleComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent> ME_BECS_Transforms_ParentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent> ME_BECS_Transforms_WorldMatrixComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent> ME_BECS_Units_CommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent> ME_BECS_Units_IsUnitStaticComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent> ME_BECS_Units_NavAgentComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent> ME_BECS_Units_NavAgentRuntimeComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent> ME_BECS_Units_PathFollowComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent> ME_BECS_Units_UnitBelongsToComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent> ME_BECS_Units_UnitCommandGroupComponent;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent> ME_BECS_Units_UnitLookAtComponent;
        }
        #endif
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        private struct CacheJobDebugData1 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData1>();
        }
        private struct CacheJobDebugData2 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData2>();
        }
        private struct CacheJobDebugData3 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData3>();
        }
        private struct CacheJobDebugData4 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData4>();
        }
        private struct CacheJobDebugData5 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData5>();
        }
        private struct CacheJobDebugData6 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData6>();
        }
        private struct CacheJobDebugData7 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData7>();
        }
        private struct CacheJobDebugData8 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData8>();
        }
        private struct CacheJobDebugData9 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData9>();
        }
        private struct CacheJobDebugData10 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData10>();
        }
        private struct CacheJobDebugData11 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData11>();
        }
        private struct CacheJobDebugData12 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData12>();
        }
        private struct CacheJobDebugData13 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData13>();
        }
        private struct CacheJobDebugData14 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData14>();
        }
        private struct CacheJobDebugData15 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData15>();
        }
        private struct CacheJobDebugData16 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData16>();
        }
        private struct CacheJobDebugData17 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData17>();
        }
        private struct CacheJobDebugData18 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData18>();
        }
        private struct CacheJobDebugData19 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData19>();
        }
        private struct CacheJobDebugData20 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData20>();
        }
        private struct CacheJobDebugData21 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData21>();
        }
        private struct CacheJobDebugData22 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData22>();
        }
        private struct CacheJobDebugData23 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData23>();
        }
        private struct CacheJobDebugData24 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData24>();
        }
        private struct CacheJobDebugData25 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData25>();
        }
        private struct CacheJobDebugData26 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData26>();
        }
        private struct CacheJobDebugData27 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData27>();
        }
        private struct CacheJobDebugData28 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData28>();
        }
        private struct CacheJobDebugData29 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData29>();
        }
        private struct CacheJobDebugData30 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData30>();
        }
        private struct CacheJobDebugData31 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData31>();
        }
        private struct CacheJobDebugData32 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData32>();
        }
        private struct CacheJobDebugData33 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData33>();
        }
        private struct CacheJobDebugData34 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData34>();
        }
        private struct CacheJobDebugData35 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData35>();
        }
        private struct CacheJobDebugData36 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData36>();
        }
        private struct CacheJobDebugData37 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData37>();
        }
        private struct CacheJobDebugData38 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData38>();
        }
        private struct CacheJobDebugData39 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData39>();
        }
        private struct CacheJobDebugData40 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData40>();
        }
        private struct CacheJobDebugData41 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData41>();
        }
        private struct CacheJobDebugData42 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData42>();
        }
        private struct CacheJobDebugData43 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData43>();
        }
        private struct CacheJobDebugData44 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData44>();
        }
        private struct CacheJobDebugData45 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData45>();
        }
        private struct CacheJobDebugData46 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData46>();
        }
        private struct CacheJobDebugData47 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData47>();
        }
        private struct CacheJobDebugData48 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData48>();
        }
        private struct CacheJobDebugData49 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData49>();
        }
        private struct CacheJobDebugData50 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData50>();
        }
        private struct CacheJobDebugData51 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData51>();
        }
        private struct CacheJobDebugData52 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData52>();
        }
        private struct CacheJobDebugData53 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData53>();
        }
        private struct CacheJobDebugData54 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData54>();
        }
        private struct CacheJobDebugData55 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData55>();
        }
        private struct CacheJobDebugData56 {
            public static readonly SharedStatic<System.IntPtr> cache = SharedStatic<System.IntPtr>.GetOrCreate<CacheJobDebugData56>();
        }
        #endif
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public static void InitializeJobsDebug() {
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRectPartialJob
                CacheJobDebugData1.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData1* data = (JobDebugData1*)CacheJobDebugData1.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData1*)_make(new JobDebugData1Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData1*)_make(new JobDebugData1(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData1.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRectPartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData1Unsafe) : typeof(JobDebugData1));
            }
            { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdatePointsJob
                CacheJobDebugData2.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData2* data = (JobDebugData2*)CacheJobDebugData2.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData2*)_make(new JobDebugData2Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData2*)_make(new JobDebugData2(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData2.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdatePointsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData2Unsafe) : typeof(JobDebugData2));
            }
            { // ME.BECS.FogOfWar.ShadowCopyUpdateSystem+UpdateRectJob
                CacheJobDebugData3.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData3* data = (JobDebugData3*)CacheJobDebugData3.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData3*)_make(new JobDebugData3Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData3*)_make(new JobDebugData3(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData3.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyPointsComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarShadowCopyPointsComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleAnytimeTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleAnytimeTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarShadowCopyWasVisibleTag = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarShadowCopyWasVisibleTag>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopyUpdateSystem.UpdateRectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData3Unsafe) : typeof(JobDebugData3));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorJob
                CacheJobDebugData4.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData4* data = (JobDebugData4*)CacheJobDebugData4.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData4*)_make(new JobDebugData4Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData4*)_make(new JobDebugData4(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData4.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData4Unsafe) : typeof(JobDebugData4));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangePartialJob
                CacheJobDebugData5.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData5* data = (JobDebugData5*)CacheJobDebugData5.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData5*)_make(new JobDebugData5Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData5*)_make(new JobDebugData5(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData5.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangePartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData5Unsafe) : typeof(JobDebugData5));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeJob
                CacheJobDebugData6.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData6* data = (JobDebugData6*)CacheJobDebugData6.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData6*)_make(new JobDebugData6Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData6*)_make(new JobDebugData6(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData6.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData6Unsafe) : typeof(JobDebugData6));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRangeSectorPartialJob
                CacheJobDebugData7.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData7* data = (JobDebugData7*)CacheJobDebugData7.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData7*)_make(new JobDebugData7Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData7*)_make(new JobDebugData7(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData7.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->c2 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerPartialComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerPartialComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarSectorRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarSectorRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRangeSectorPartialJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData7Unsafe) : typeof(JobDebugData7));
            }
            { // ME.BECS.FogOfWar.UpdateSystem+RevealRectJob
                CacheJobDebugData8.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData8* data = (JobDebugData8*)CacheJobDebugData8.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData8*)_make(new JobDebugData8Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData8*)_make(new JobDebugData8(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData8.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.UpdateSystem.RevealRectJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarRevealerComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarRevealerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.UpdateSystem.RevealRectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData8Unsafe) : typeof(JobDebugData8));
            }
            { // ME.BECS.FogOfWar.ShadowCopySystem+CreateJob
                CacheJobDebugData9.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData9* data = (JobDebugData9*)CacheJobDebugData9.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData9*)_make(new JobDebugData9Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData9*)_make(new JobDebugData9(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData9.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.ShadowCopySystem.CreateJob*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.ShadowCopySystem.CreateJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData9Unsafe) : typeof(JobDebugData9));
            }
            { // Sample.FilterEntitiesSystem+JobSetTest
                CacheJobDebugData10.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData10* data = (JobDebugData10*)CacheJobDebugData10.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData10*)_make(new JobDebugData10Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData10*)_make(new JobDebugData10(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData10.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(Sample.FilterEntitiesSystem.JobSetTest*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<Sample.TestComponent>(buffer->state, buffer->worldId);
                    data->Sample_TestComponent = new SafetyComponentContainerWO<Sample.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<Sample.FilterEntitiesSystem.JobSetTest>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData10Unsafe) : typeof(JobDebugData10));
            }
            { // ME.BECS.Units.HitSystem+Job
                CacheJobDebugData11.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData11* data = (JobDebugData11*)CacheJobDebugData11.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData11*)_make(new JobDebugData11Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData11*)_make(new JobDebugData11(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData11.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Units.HitSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookComponent = new SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.HitSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData11Unsafe) : typeof(JobDebugData11));
            }
            { // ME.BECS.Views.Jobs+JobAddToScene
                CacheJobDebugData12.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData12* data = (JobDebugData12*)CacheJobDebugData12.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData12*)_make(new JobDebugData12Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData12*)_make(new JobDebugData12(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData12.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Views.Jobs.JobAddToScene*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRO<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobAddToScene>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData12Unsafe) : typeof(JobDebugData12));
            }
            { // ME.BECS.Views.Jobs+JobAssignViews
                CacheJobDebugData13.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData13* data = (JobDebugData13*)CacheJobDebugData13.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData13*)_make(new JobDebugData13Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData13*)_make(new JobDebugData13(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData13.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Views.Jobs.JobAssignViews*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.AssignViewComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_AssignViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.AssignViewComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRO<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobAssignViews>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData13Unsafe) : typeof(JobDebugData13));
            }
            { // ME.BECS.Views.Jobs+JobRemoveFromScene
                CacheJobDebugData14.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData14* data = (JobDebugData14*)CacheJobDebugData14.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData14*)_make(new JobDebugData14Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData14*)_make(new JobDebugData14(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData14.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Views.Jobs.JobRemoveFromScene*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Views.Jobs.JobRemoveFromScene>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData14Unsafe) : typeof(JobDebugData14));
            }
            { // ME.BECS.DestroyWithTicksSystem+Job
                CacheJobDebugData15.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData15* data = (JobDebugData15*)CacheJobDebugData15.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData15*)_make(new JobDebugData15Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData15*)_make(new JobDebugData15(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData15.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.DestroyWithTicksSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithTicks = new SafetyComponentContainerRO<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.DestroyWithTicksSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData15Unsafe) : typeof(JobDebugData15));
            }
            { // ME.BECS.DestroyWithLifetimeSystem+Job
                CacheJobDebugData16.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData16* data = (JobDebugData16*)CacheJobDebugData16.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData16*)_make(new JobDebugData16Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData16*)_make(new JobDebugData16(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData16.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.DestroyWithLifetimeSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRO<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.DestroyWithLifetimeSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData16Unsafe) : typeof(JobDebugData16));
            }
            { // ME.BECS.Pathfinding.UpdateGraphSystem+ResetPathJob
                CacheJobDebugData17.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData17* data = (JobDebugData17*)CacheJobDebugData17.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData17*)_make(new JobDebugData17Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData17*)_make(new JobDebugData17(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData17.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.UpdateGraphSystem.ResetPathJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData17Unsafe) : typeof(JobDebugData17));
            }
            { // ME.BECS.Pathfinding.BuildPathSystem+UpdatePathJob
                CacheJobDebugData18.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData18* data = (JobDebugData18*)CacheJobDebugData18.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData18*)_make(new JobDebugData18Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData18*)_make(new JobDebugData18(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData18.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.BuildPathSystem.UpdatePathJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData18Unsafe) : typeof(JobDebugData18));
            }
            { // ME.BECS.Pathfinding.UpdateGraphSystem+UpdateGraphMaskJob
                CacheJobDebugData19.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData19* data = (JobDebugData19*)CacheJobDebugData19.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData19*)_make(new JobDebugData19Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData19*)_make(new JobDebugData19(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData19.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_IsGraphMaskDirtyComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.IsGraphMaskDirtyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.UpdateGraphSystem.UpdateGraphMaskJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData19Unsafe) : typeof(JobDebugData19));
            }
            { // ME.BECS.Commands.CommandBuildUpdateSystem+CompleteJob
                CacheJobDebugData20.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData20* data = (JobDebugData20*)CacheJobDebugData20.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData20*)_make(new JobDebugData20Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData20*)_make(new JobDebugData20(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData20.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildUpdateSystem.CompleteJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData20Unsafe) : typeof(JobDebugData20));
            }
            { // ME.BECS.Commands.CommandBuildUpdateSystem+UpdateProgressJob
                CacheJobDebugData21.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData21* data = (JobDebugData21*)CacheJobDebugData21.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData21*)_make(new JobDebugData21Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData21*)_make(new JobDebugData21(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData21.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildUpdateSystem.UpdateProgressJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData21Unsafe) : typeof(JobDebugData21));
            }
            { // ME.BECS.UnitsHealthBars.DrawHealthBarsSystem+Job
                CacheJobDebugData22.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData22* data = (JobDebugData22*)CacheJobDebugData22.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData22*)_make(new JobDebugData22Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData22*)_make(new JobDebugData22(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData22.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_FogOfWarStaticComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_CameraComponent = new SafetyComponentContainerRO<ME.BECS.Views.CameraComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.UnitsHealthBars.DrawHealthBarsSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData22Unsafe) : typeof(JobDebugData22));
            }
            { // ME.BECS.FogOfWar.CreateSystem+CleanUpJob
                CacheJobDebugData23.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData23* data = (JobDebugData23*)CacheJobDebugData23.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData23*)_make(new JobDebugData23Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData23*)_make(new JobDebugData23(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData23.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.CreateSystem.CleanUpJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Players.TeamAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRO<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.CreateSystem.CleanUpJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData23Unsafe) : typeof(JobDebugData23));
            }
            { // ME.BECS.FogOfWar.CreateSystem+CreateJob
                CacheJobDebugData24.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData24* data = (JobDebugData24*)CacheJobDebugData24.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData24*)_make(new JobDebugData24Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData24*)_make(new JobDebugData24(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData24.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.CreateSystem.CreateJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Players.TeamAspect>(buffer->state);
                    data->ME_BECS_FogOfWar_FogOfWarComponent = new SafetyComponentContainerRW<ME.BECS.FogOfWar.FogOfWarComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.CreateSystem.CreateJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData24Unsafe) : typeof(JobDebugData24));
            }
            { // Sample.FilterEntitiesSystem+JobMove
                CacheJobDebugData25.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData25* data = (JobDebugData25*)CacheJobDebugData25.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData25*)_make(new JobDebugData25Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData25*)_make(new JobDebugData25(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData25.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(Sample.FilterEntitiesSystem.JobMove*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<Sample.FilterEntitiesSystem.JobMove>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData25Unsafe) : typeof(JobDebugData25));
            }
            { // ME.BECS.QuadTreeQuerySystem+Job
                CacheJobDebugData26.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData26* data = (JobDebugData26*)CacheJobDebugData26.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData26*)_make(new JobDebugData26Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData26*)_make(new JobDebugData26(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData26.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.QuadTreeQuerySystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.QuadTreeQuerySystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData26Unsafe) : typeof(JobDebugData26));
            }
            { // ME.BECS.QuadTreeInsertSystem+CollectJob
                CacheJobDebugData27.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData27* data = (JobDebugData27*)CacheJobDebugData27.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData27*)_make(new JobDebugData27Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData27*)_make(new JobDebugData27(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData27.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.QuadTreeInsertSystem.CollectJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_QuadTreeElement = new SafetyComponentContainerRW<ME.BECS.QuadTreeElement>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.QuadTreeInsertSystem.CollectJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData27Unsafe) : typeof(JobDebugData27));
            }
            { // ME.BECS.Units.DestroySystem+DestroyJob
                CacheJobDebugData28.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData28* data = (JobDebugData28*)CacheJobDebugData28.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData28*)_make(new JobDebugData28Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData28*)_make(new JobDebugData28(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData28.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Units.DestroySystem.DestroyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_SelectionGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.SelectionGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitEffectOnDestroyComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnDestroyComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitSelectionGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitSelectionGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.DestroySystem.DestroyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData28Unsafe) : typeof(JobDebugData28));
            }
            { // ME.BECS.Units.SteeringWithAvoidanceSystem+Job
                CacheJobDebugData29.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData29* data = (JobDebugData29*)CacheJobDebugData29.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData29*)_make(new JobDebugData29Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData29*)_make(new JobDebugData29(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData29.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Units.SteeringWithAvoidanceSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.SteeringWithAvoidanceSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData29Unsafe) : typeof(JobDebugData29));
            }
            { // ME.BECS.Units.SteeringSystem+Job
                CacheJobDebugData30.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData30* data = (JobDebugData30*)CacheJobDebugData30.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData30*)_make(new JobDebugData30Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData30*)_make(new JobDebugData30(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData30.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Units.SteeringSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Units.SteeringSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData30Unsafe) : typeof(JobDebugData30));
            }
            { // ME.BECS.Bullets.FlySystem+FlyJob
                CacheJobDebugData31.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData31* data = (JobDebugData31*)CacheJobDebugData31.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData31*)_make(new JobDebugData31Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData31*)_make(new JobDebugData31(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData31.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Bullets.FlySystem.FlyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Bullets.BulletAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_TargetReachedComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.TargetReachedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Bullets.FlySystem.FlyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData31Unsafe) : typeof(JobDebugData31));
            }
            { // ME.BECS.Bullets.DestroySystem+DestroyJob
                CacheJobDebugData32.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData32* data = (JobDebugData32*)CacheJobDebugData32.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData32*)_make(new JobDebugData32Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData32*)_make(new JobDebugData32(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData32.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Bullets.DestroySystem.DestroyJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Bullets.BulletAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletEffectOnDestroy = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletEffectOnDestroy>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithTicks = new SafetyComponentContainerRW<ME.BECS.DestroyWithTicks>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookComponent = new SafetyComponentContainerRW<ME.BECS.Units.DamageTookComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookEvent = new SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitEffectOnHitComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitEffectOnHitComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Bullets.DestroySystem.DestroyJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData32Unsafe) : typeof(JobDebugData32));
            }
            { // ME.BECS.Pathfinding.FollowPathSystem+SpeedDownOnHoldJob
                CacheJobDebugData33.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData33* data = (JobDebugData33*)CacheJobDebugData33.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData33*)_make(new JobDebugData33Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData33*)_make(new JobDebugData33(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData33.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathSystem.SpeedDownOnHoldJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData33Unsafe) : typeof(JobDebugData33));
            }
            { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+PathFollowJob
                CacheJobDebugData34.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData34* data = (JobDebugData34*)CacheJobDebugData34.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData34*)_make(new JobDebugData34Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData34*)_make(new JobDebugData34(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData34.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Pathfinding_AgentComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.PathFollowJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData34Unsafe) : typeof(JobDebugData34));
            }
            { // ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem+SpeedDownOnHoldJob
                CacheJobDebugData35.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData35* data = (JobDebugData35*)CacheJobDebugData35.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData35*)_make(new JobDebugData35Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData35*)_make(new JobDebugData35(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData35.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathWithAvoidanceSystem.SpeedDownOnHoldJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData35Unsafe) : typeof(JobDebugData35));
            }
            { // ME.BECS.Pathfinding.FollowPathSystem+PathFollowJob
                CacheJobDebugData36.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData36* data = (JobDebugData36*)CacheJobDebugData36.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData36*)_make(new JobDebugData36Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData36*)_make(new JobDebugData36(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData36.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Pathfinding_AgentComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.AgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeSpeedComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.FollowPathSystem.PathFollowJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData36Unsafe) : typeof(JobDebugData36));
            }
            { // ME.BECS.Pathfinding.LookAtSystem+Job
                CacheJobDebugData37.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData37* data = (JobDebugData37*)CacheJobDebugData37.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData37*)_make(new JobDebugData37Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData37*)_make(new JobDebugData37(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData37.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Pathfinding.LookAtSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Pathfinding.LookAtSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData37Unsafe) : typeof(JobDebugData37));
            }
            { // ME.BECS.Commands.CommandMoveSystem+Job
                CacheJobDebugData38.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData38* data = (JobDebugData38*)CacheJobDebugData38.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData38*)_make(new JobDebugData38Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData38*)_make(new JobDebugData38(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData38.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandMoveSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandMove = new SafetyComponentContainerRO<ME.BECS.Commands.CommandMove>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandMoveSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData38Unsafe) : typeof(JobDebugData38));
            }
            { // ME.BECS.Commands.CommandAttackSystem+MoveJob
                CacheJobDebugData39.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData39* data = (JobDebugData39*)CacheJobDebugData39.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData39*)_make(new JobDebugData39Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData39*)_make(new JobDebugData39(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData39.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandAttackSystem.MoveJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandAttackSystem.MoveJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData39Unsafe) : typeof(JobDebugData39));
            }
            { // ME.BECS.Commands.CommandBuildSystem+Job
                CacheJobDebugData40.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData40* data = (JobDebugData40*)CacheJobDebugData40.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData40*)_make(new JobDebugData40Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData40*)_make(new JobDebugData40(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData40.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandBuildSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitCommandGroupAspect>(buffer->state);
                    data->ME_BECS_Commands_BuildingInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildingInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_BuildInProgress = new SafetyComponentContainerRW<ME.BECS.Commands.BuildInProgress>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandBuild = new SafetyComponentContainerRO<ME.BECS.Commands.CommandBuild>(buffer->state, buffer->worldId);
                    data->ME_BECS_IsInactive = new SafetyComponentContainerRW<ME.BECS.IsInactive>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_GraphMaskComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.GraphMaskComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandBuildSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData40Unsafe) : typeof(JobDebugData40));
            }
            { // ME.BECS.Commands.CommandAttackSystem+CleanUpJob
                CacheJobDebugData41.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData41* data = (JobDebugData41*)CacheJobDebugData41.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData41*)_make(new JobDebugData41Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData41*)_make(new JobDebugData41(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData41.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Commands.CommandAttackSystem.CleanUpJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->ME_BECS_Commands_CommandAttack = new SafetyComponentContainerRO<ME.BECS.Commands.CommandAttack>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Commands.CommandAttackSystem.CleanUpJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData41Unsafe) : typeof(JobDebugData41));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsJob
                CacheJobDebugData42.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData42* data = (JobDebugData42*)CacheJobDebugData42.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData42*)_make(new JobDebugData42Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData42*)_make(new JobDebugData42(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData42.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData42Unsafe) : typeof(JobDebugData42));
            }
            { // ME.BECS.Attack.RotateWhileAttackSystem+IdleJob
                CacheJobDebugData43.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData43* data = (JobDebugData43*)CacheJobDebugData43.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData43*)_make(new JobDebugData43Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData43*)_make(new JobDebugData43(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData43.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.RotateWhileAttackSystem.IdleJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.RotateWhileAttackSystem.IdleJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData43Unsafe) : typeof(JobDebugData43));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobRemove
                CacheJobDebugData44.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData44* data = (JobDebugData44*)CacheJobDebugData44.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData44*)_make(new JobDebugData44Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData44*)_make(new JobDebugData44(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData44.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobRemove*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobRemove>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData44Unsafe) : typeof(JobDebugData44));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobRotate
                CacheJobDebugData45.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData45* data = (JobDebugData45*)CacheJobDebugData45.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData45*)_make(new JobDebugData45Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData45*)_make(new JobDebugData45(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData45.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobRotate*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRO<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobRotate>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData45Unsafe) : typeof(JobDebugData45));
            }
            { // ME.BECS.Attack.ReloadSystem+ReloadJob
                CacheJobDebugData46.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData46* data = (JobDebugData46*)CacheJobDebugData46.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData46*)_make(new JobDebugData46Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData46*)_make(new JobDebugData46(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData46.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.ReloadSystem.ReloadJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeReloadComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ReloadedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ReloadSystem.ReloadJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData46Unsafe) : typeof(JobDebugData46));
            }
            { // ME.BECS.Attack.FireSystem+FireJob
                CacheJobDebugData47.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData47* data = (JobDebugData47*)CacheJobDebugData47.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData47*)_make(new JobDebugData47Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData47*)_make(new JobDebugData47(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData47.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.FireSystem.FireJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletConfigComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.BulletConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_BulletRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Bullets.BulletRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Bullets_FirePointComponent = new SafetyComponentContainerRO<ME.BECS.Bullets.FirePointComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_DestroyWithLifetime = new SafetyComponentContainerRW<ME.BECS.DestroyWithLifetime>(buffer->state, buffer->worldId);
                    data->ME_BECS_EntityConfigComponent = new SafetyComponentContainerRW<ME.BECS.EntityConfigComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerChangedEvent = new SafetyComponentContainerRO<ME.BECS.Players.OwnerChangedEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_OwnerComponent = new SafetyComponentContainerRW<ME.BECS.Players.OwnerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Players_PlayerComponent = new SafetyComponentContainerRO<ME.BECS.Players.PlayerComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitQuadSizeComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitQuadSizeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_IsViewRequested = new SafetyComponentContainerRW<ME.BECS.Views.IsViewRequested>(buffer->state, buffer->worldId);
                    data->ME_BECS_Views_ViewComponent = new SafetyComponentContainerRW<ME.BECS.Views.ViewComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.FireSystem.FireJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData47Unsafe) : typeof(JobDebugData47));
            }
            { // ME.BECS.Attack.ResetCanFireSystem+Job
                CacheJobDebugData48.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData48* data = (JobDebugData48*)CacheJobDebugData48.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData48*)_make(new JobDebugData48Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData48*)_make(new JobDebugData48(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData48.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.ResetCanFireSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.ResetCanFireSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData48Unsafe) : typeof(JobDebugData48));
            }
            { // ME.BECS.Attack.SearchTargetSystem+SearchTargetJob
                CacheJobDebugData49.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData49* data = (JobDebugData49*)CacheJobDebugData49.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData49*)_make(new JobDebugData49Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData49*)_make(new JobDebugData49(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData49.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.SearchTargetSystem.SearchTargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a2 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHealthComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitHealthComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.SearchTargetSystem.SearchTargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData49Unsafe) : typeof(JobDebugData49));
            }
            { // ME.BECS.Attack.CanFireSystem+Job
                CacheJobDebugData50.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData50* data = (JobDebugData50*)CacheJobDebugData50.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData50*)_make(new JobDebugData50Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData50*)_make(new JobDebugData50(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData50.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.CanFireSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackRuntimeReloadComponent = new SafetyComponentContainerRW<ME.BECS.Attack.AttackRuntimeReloadComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_CanFireComponent = new SafetyComponentContainerRW<ME.BECS.Attack.CanFireComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_FireUsedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.FireUsedComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_ReloadedComponent = new SafetyComponentContainerRW<ME.BECS.Attack.ReloadedComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.CanFireSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData50Unsafe) : typeof(JobDebugData50));
            }
            { // ME.BECS.Attack.RotateWhileAttackSystem+RotateAttackSensorJob
                CacheJobDebugData51.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData51* data = (JobDebugData51*)CacheJobDebugData51.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData51*)_make(new JobDebugData51Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData51*)_make(new JobDebugData51(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData51.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_RotateAttackSensorComponent = new SafetyComponentContainerRO<ME.BECS.Attack.RotateAttackSensorComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.RotateWhileAttackSystem.RotateAttackSensorJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData51Unsafe) : typeof(JobDebugData51));
            }
            { // ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem+Job
                CacheJobDebugData52.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData52* data = (JobDebugData52*)CacheJobDebugData52.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData52*)_make(new JobDebugData52Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData52*)_make(new JobDebugData52(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData52.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.QuadTreeQueryAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>(buffer->state, buffer->worldId);
                    data->ME_BECS_FogOfWar_QuadTreeQueryFogOfWarFilter = new SafetyComponentContainerRO<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarFilter>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeQuery = new SafetyComponentContainerRW<ME.BECS.QuadTreeQuery>(buffer->state, buffer->worldId);
                    data->ME_BECS_QuadTreeResult = new SafetyComponentContainerRW<ME.BECS.QuadTreeResult>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.FogOfWar.QuadTreeQueryFogOfWarSystem.Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData52Unsafe) : typeof(JobDebugData52));
            }
            { // ME.BECS.Transforms.TransformWorldMatrixUpdateSystem+CalculateRootsWithChildrenJob
                CacheJobDebugData53.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData53* data = (JobDebugData53*)CacheJobDebugData53.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData53*)_make(new JobDebugData53Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData53*)_make(new JobDebugData53(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData53.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->c1 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Transforms.TransformWorldMatrixUpdateSystem.CalculateRootsWithChildrenJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData53Unsafe) : typeof(JobDebugData53));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+MoveToAttackerJob
                CacheJobDebugData54.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData54* data = (JobDebugData54*)CacheJobDebugData54.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData54*)_make(new JobDebugData54Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData54*)_make(new JobDebugData54(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData54.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->a1 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Transforms.TransformAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackFilterComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_CommandMove = new SafetyComponentContainerRW<ME.BECS.Commands.CommandMove>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_DamageTookEvent = new SafetyComponentContainerRO<ME.BECS.Units.DamageTookEvent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsCommandGroupDirty = new SafetyComponentContainerRW<ME.BECS.Units.IsCommandGroupDirty>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitBelongsToComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.MoveToAttackerJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData54Unsafe) : typeof(JobDebugData54));
            }
            { // ME.BECS.Attack.StopWhileAttackSystem+JobSet
                CacheJobDebugData55.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData55* data = (JobDebugData55*)CacheJobDebugData55.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData55*)_make(new JobDebugData55Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData55*)_make(new JobDebugData55(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData55.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.StopWhileAttackSystem.JobSet*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Attack.AttackAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackTargetComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitHoldComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitHoldComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.StopWhileAttackSystem.JobSet>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData55Unsafe) : typeof(JobDebugData55));
            }
            { // ME.BECS.Attack.MoveToAttackerSystem+StopOnTargetJob
                CacheJobDebugData56.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleMode scheduleMode) {
                    JobDebugData56* data = (JobDebugData56*)CacheJobDebugData56.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData56*)_make(new JobDebugData56Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData56*)_make(new JobDebugData56(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData56.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleMode = scheduleMode;
                    data->jobData = *(ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Units.UnitAspect>(buffer->state);
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Attack_AttackFilterComponent = new SafetyComponentContainerRO<ME.BECS.Attack.AttackFilterComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Commands_UnitAttackCommandComponent = new SafetyComponentContainerRO<ME.BECS.Commands.UnitAttackCommandComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_RootGraphComponent = new SafetyComponentContainerRO<ME.BECS.Pathfinding.RootGraphComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetInfoComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetInfoComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Pathfinding_TargetPathComponent = new SafetyComponentContainerRW<ME.BECS.Pathfinding.TargetPathComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ChildrenComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ChildrenComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_IsFirstLevelComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.IsFirstLevelComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalPositionComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalPositionComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalRotationComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.LocalRotationComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_LocalScaleComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.LocalScaleComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_ParentComponent = new SafetyComponentContainerRW<ME.BECS.Transforms.ParentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Transforms_WorldMatrixComponent = new SafetyComponentContainerRO<ME.BECS.Transforms.WorldMatrixComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_CommandGroupComponent = new SafetyComponentContainerRW<ME.BECS.Units.CommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_IsUnitStaticComponent = new SafetyComponentContainerRO<ME.BECS.Units.IsUnitStaticComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentComponent = new SafetyComponentContainerRO<ME.BECS.Units.NavAgentComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_NavAgentRuntimeComponent = new SafetyComponentContainerRW<ME.BECS.Units.NavAgentRuntimeComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_PathFollowComponent = new SafetyComponentContainerRW<ME.BECS.Units.PathFollowComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitBelongsToComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitBelongsToComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitCommandGroupComponent = new SafetyComponentContainerRO<ME.BECS.Units.UnitCommandGroupComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Units_UnitLookAtComponent = new SafetyComponentContainerRW<ME.BECS.Units.UnitLookAtComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Attack.MoveToAttackerSystem.StopOnTargetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData56Unsafe) : typeof(JobDebugData56));
            }
        }
        #endif
        
        
        public static unsafe void NetworkLoad(ref ME.BECS.Network.UnsafeNetworkModule.MethodsStorage methods) {
        }
        public static unsafe void ViewsLoad(ref ME.BECS.Views.ViewsModuleData viewsModule) {
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.FogOfWar.FogOfWarView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)33,
            });
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.Views.DefaultView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)0,
            });
            ME.BECS.Views.ViewsTypeInfo.RegisterType<ME.BECS.Pathfinding.Views.GridView>(new ME.BECS.Views.ViewTypeInfo() {
                flags = (ME.BECS.Views.TypeFlags)49,
            });
        }
        public static unsafe void AspectsConstruct(ref World world) {
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.QuadTreeAspect>();
                aspect.quadTreeElementPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeElement>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.QuadTreeQueryAspect>();
                aspect.queryPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeQuery>(in world);
                aspect.resultPtr = new ME.BECS.AspectDataPtr<ME.BECS.QuadTreeResult>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitAspect>();
                aspect.ownerDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.OwnerComponent>(in world);
                aspect.navAgentDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentComponent>(in world);
                aspect.navAgentRuntimeDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentRuntimeComponent>(in world);
                aspect.navAgentRuntimeSpeedDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.NavAgentRuntimeSpeedComponent>(in world);
                aspect.unitCommandGroupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitCommandGroupComponent>(in world);
                aspect.healthDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitHealthComponent>(in world);
                aspect.unitSelectionGroupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.UnitSelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitCommandGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.CommandGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitSelectionGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.SelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Units.UnitSelectionTempGroupAspect>();
                aspect.groupDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Units.SelectionGroupComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Views.CameraAspect>();
                aspect.cameraDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Views.CameraComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Players.TeamAspect>();
                aspect.teamDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.TeamComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Players.PlayerAspect>();
                aspect.playerDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.PlayerComponent>(in world);
                aspect.playerCurrentSelectionDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Players.PlayerCurrentSelection>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Effects.EffectAspect>();
                aspect.effectDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Effects.EffectComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Bullets.BulletAspect>();
                aspect.bulletConfigDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Bullets.BulletConfigComponent>(in world);
                aspect.bulletRuntimeDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Bullets.BulletRuntimeComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Transforms.TransformAspect>();
                aspect.childrenData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.ChildrenComponent>(in world);
                aspect.localPositionData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalPositionComponent>(in world);
                aspect.localRotationData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalRotationComponent>(in world);
                aspect.localScaleData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.LocalScaleComponent>(in world);
                aspect.parentData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.ParentComponent>(in world);
                aspect.worldMatrixData = new ME.BECS.AspectDataPtr<ME.BECS.Transforms.WorldMatrixComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Attack.AttackAspect>();
                aspect.attackDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackComponent>(in world);
                aspect.attackRuntimeFireDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackRuntimeFireComponent>(in world);
                aspect.attackRuntimeReloadDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackRuntimeReloadComponent>(in world);
                aspect.targetDataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Attack.AttackTargetComponent>(in world);
            }
        }
    }
}
