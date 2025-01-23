namespace ME.BECS.Editor {
    using BURST = Unity.Burst.BurstCompileAttribute;
    using Unity.Collections;
    using Unity.Collections.LowLevel.Unsafe;
    using UnityEngine.Scripting;
    using Unity.Burst;
    using Unity.Jobs.LowLevel.Unsafe;
    using ME.BECS.Jobs;
    using static Cuts;
    using UnityEditor;
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
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.Validate();
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.Validate();
            BurstCompileOnAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileOnDestroyNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            BurstCompileMethod.MakeDestroy<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.Validate();
            BurstCompileOnAwakeNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.MakeMethod(null);
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.MakeMethod(null);
            BurstCompileMethod.MakeAwake<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>(default);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>(default);
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.Validate();
            BurstCompileOnUpdateNoBurst<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.MakeMethod(null);
            BurstCompileMethod.MakeUpdate<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>(default);
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
            StaticTypes<ME.BECS.Tests.T1>.AOT();
            StaticTypes<ME.BECS.Tests.T2>.AOT();
            StaticTypes<ME.BECS.Tests.Test1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test2Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test3Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test4Component>.AOT();
            StaticTypes<ME.BECS.Tests.Test5Component>.AOT();
            StaticTypes<ME.BECS.Tests.TestComponent>.AOT();
            StaticTypes<ME.BECS.Tests.TestComponentTag>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.AOT();
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.AOT();
            StaticTypes<ME.BECS.Tests.TestTargetComponent>.AOT();
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
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.AOT();
            StaticTypesShared<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletEffectOnDestroy>.AOT();
            StaticTypesStatic<ME.BECS.Bullets.BulletViewPoint>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestConfig1StaticComponent>.AOT();
            StaticTypesStatic<ME.BECS.Tests.Tests_EntityConfig.TestConfig2StaticComponent>.AOT();
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
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestCurrentTickSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Components_OneShot.TestNextTickSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_GlobalEvents.TestSystem>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystem4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Queries_Static.TestSystemDefer1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem1_4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_3>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem2_4>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestGraphSystem3_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_1>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem2_2>.Validate();
            StaticSystemTypes<ME.BECS.Tests.Tests_Systems_Graph.TestSystem3>.Validate();
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
            StaticTypes<ME.BECS.Tests.TestComponent>.ApplyGroup(typeof(ME.BECS.Tests.TestGroup));
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
            StaticTypes<ME.BECS.Tests.T1>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.T2>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test2Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test3Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test4Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Test5Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestComponentTag>.Validate(isTag: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.Validate(isTag: false);
            StaticTypes<ME.BECS.Tests.TestTargetComponent>.Validate(isTag: false);
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
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom1SharedComponent>.ValidateShared(isTag: false, hasCustomHash: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestCustom2SharedComponent>.ValidateShared(isTag: false, hasCustomHash: true);
            StaticTypes<ME.BECS.Tests.Tests_Components_Shared.TestSharedComponent>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfigShared1Component>.ValidateShared(isTag: false, hasCustomHash: false);
            StaticTypes<ME.BECS.Bullets.BulletEffectOnDestroy>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Bullets.BulletViewPoint>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig1StaticComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestConfig2StaticComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnDestroyComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Units.UnitEffectOnHitComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Attack.AttackComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Pathfinding.GraphMaskComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateAvatarViewComponent>.ValidateStatic(isTag: false);
            StaticTypes<ME.BECS.Views.InstantiateViewComponent>.ValidateStatic(isTag: false);
            AspectTypeInfo<ME.BECS.Tests.Aspect1>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.Test1Component>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect1>.typeId).Get(1) = StaticTypes<ME.BECS.Tests.Test2Component>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Aspect2>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Resize(2);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.Test3Component>.typeId;
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.Aspect2>.typeId).Get(1) = StaticTypes<ME.BECS.Tests.Test4Component>.typeId;
            AspectTypeInfo<ME.BECS.Tests.TestAspect>.Validate();
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.TestAspect>.typeId).Resize(1);
            AspectTypeInfo.with.Get(AspectTypeInfo<ME.BECS.Tests.TestAspect>.typeId).Get(0) = StaticTypes<ME.BECS.Tests.TestComponent>.typeId;
            AspectTypeInfo<ME.BECS.Tests.Test2Aspect>.Validate();
            AspectTypeInfo<ME.BECS.Tests.Tests_Aspects.TestAspect>.Validate();
            #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
            StaticMethods.InitializeJobsDebug();
            #endif
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job1>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job2>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job2Unsafe, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.JobComponents, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Queries.Job1Unsafe, ME.BECS.Tests.TestComponent>();
            EarlyInit.DoComponents<ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor, ME.BECS.Tests.TestTargetComponent>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Aspects.TestSetJob, ME.BECS.Tests.Test2Aspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Queries.TestA2Job, ME.BECS.Tests.TestAspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Queries.TestA1Job, ME.BECS.Tests.TestAspect>();
            EarlyInit.DoAspect<ME.BECS.Tests.Tests_Aspects.TestJobFor, ME.BECS.Tests.Test2Aspect>();
            StaticTypes.collectionsCount.Resize(StaticTypes.counter + 1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>.SetCollectionsCount(1u);
            StaticTypes<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>.SetCollectionsCount(1u);
        }
    }
    [UnityEngine.Scripting.PreserveAttribute]
    [UnityEngine.DefaultExecutionOrder(-100_000)]
    [BURST]
    public static unsafe class StaticMethods {
        [UnityEngine.Scripting.PreserveAttribute]
        public static void Load() {
            Worlds.Initialize();
            SystemsStatic.Initialize();
            StaticTypesInitializer.Load();
            GlobalEvents.Initialize();
            CustomModules.InvokeResetPass();
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Network.UnsafeNetworkModule.MethodsStorage>(NetworkLoad);
            WorldStaticCallbacks.RegisterCallback<ME.BECS.Views.ViewsModuleData>(ViewsLoad);
            WorldStaticCallbacks.RegisterCallback<World>(AspectsConstruct);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponent);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestListComponent>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestListComponent);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentStatic);
            WorldStaticCallbacks.RegisterConfigComponentCallback<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared>(EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentShared);
            EntityConfigRegistry.Initialize();
            EntityConfigsRegistry.Initialize(true);
            CustomModules.InvokeFirstPass();
            CustomModules.InvokeSecondPass();
        }
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1 { // ME.BECS.Tests.Tests_Queries+Job1
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData2 { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData3 { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
        }
        public struct JobDebugData4 { // ME.BECS.Tests.Tests_Queries+Job2
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData5 { // ME.BECS.Tests.Tests_Queries+JobComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.JobComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData6 { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestComponent> c0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData7 { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public RefRW<ME.BECS.Tests.TestTargetComponent> c0;
            public SafetyComponentContainerRO<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerRO<ME.BECS.Tests.TestTargetComponent> ME_BECS_Tests_TestTargetComponent;
        }
        public struct JobDebugData8 { // ME.BECS.Tests.Tests_Aspects+TestSetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestSetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.Test2Aspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        public struct JobDebugData9 { // ME.BECS.Tests.Tests_Queries+TestA2Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA2Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.TestAspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData10 { // ME.BECS.Tests.Tests_Queries+TestA1Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA1Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.TestAspect a0;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test5Component> ME_BECS_Tests_Test5Component;
            public SafetyComponentContainerRW<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData11 { // ME.BECS.Tests.Tests_Aspects+TestJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            public ME.BECS.Tests.Test2Aspect a0;
            public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            public SafetyComponentContainerRO<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        #endif
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public struct JobDebugData1Unsafe { // ME.BECS.Tests.Tests_Queries+Job1
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData2Unsafe { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData3Unsafe { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
        }
        public struct JobDebugData4Unsafe { // ME.BECS.Tests.Tests_Queries+Job2
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job2 jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
        }
        public struct JobDebugData5Unsafe { // ME.BECS.Tests.Tests_Queries+JobComponents
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.JobComponents jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData6Unsafe { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.Job1Unsafe jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData7Unsafe { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public RefRW<ME.BECS.Tests.TestTargetComponent> c0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.TestTargetComponent> ME_BECS_Tests_TestTargetComponent;
        }
        public struct JobDebugData8Unsafe { // ME.BECS.Tests.Tests_Aspects+TestSetJob
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestSetJob jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.Test2Aspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
        }
        public struct JobDebugData9Unsafe { // ME.BECS.Tests.Tests_Queries+TestA2Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA2Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.TestAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.Test2Component> ME_BECS_Tests_Test2Component;
        }
        public struct JobDebugData10Unsafe { // ME.BECS.Tests.Tests_Queries+TestA1Job
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Queries.TestA1Job jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.TestAspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test5Component> ME_BECS_Tests_Test5Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.TestComponent> ME_BECS_Tests_TestComponent;
        }
        public struct JobDebugData11Unsafe { // ME.BECS.Tests.Tests_Aspects+TestJobFor
            [NativeDisableUnsafePtrRestriction] public ScheduleFlags scheduleFlags;
            [NativeDisableUnsafePtrRestriction] public ME.BECS.Tests.Tests_Aspects.TestJobFor jobData;
            [NativeDisableUnsafePtrRestriction] public CommandBuffer* buffer;
            [NativeDisableContainerSafetyRestriction] public ME.BECS.Tests.Test2Aspect a0;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRW<ME.BECS.Tests.T1> ME_BECS_Tests_T1;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test3Component> ME_BECS_Tests_Test3Component;
            [NativeDisableContainerSafetyRestriction] public SafetyComponentContainerRO<ME.BECS.Tests.Test4Component> ME_BECS_Tests_Test4Component;
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
        #endif
        
        #if ENABLE_UNITY_COLLECTIONS_CHECKS && ENABLE_BECS_COLLECTIONS_CHECKS
        public static void InitializeJobsDebug() {
            { // ME.BECS.Tests.Tests_Queries+Job1
                CacheJobDebugData1.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData1* data = (JobDebugData1*)CacheJobDebugData1.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData1*)_make(new JobDebugData1Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData1*)_make(new JobDebugData1(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData1.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job1*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job1>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData1Unsafe) : typeof(JobDebugData1));
            }
            { // ME.BECS.Tests.Tests_Queries_Static+TestSystem4+JobForComponents
                CacheJobDebugData2.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData2* data = (JobDebugData2*)CacheJobDebugData2.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData2*)_make(new JobDebugData2Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData2*)_make(new JobDebugData2(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData2.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerRO<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries_Static.TestSystem4.JobForComponents>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData2Unsafe) : typeof(JobDebugData2));
            }
            { // ME.BECS.Tests.Tests_Queries+Job2Unsafe
                CacheJobDebugData3.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData3* data = (JobDebugData3*)CacheJobDebugData3.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData3*)_make(new JobDebugData3Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData3*)_make(new JobDebugData3(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData3.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job2Unsafe*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job2Unsafe>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData3Unsafe) : typeof(JobDebugData3));
            }
            { // ME.BECS.Tests.Tests_Queries+Job2
                CacheJobDebugData4.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData4* data = (JobDebugData4*)CacheJobDebugData4.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData4*)_make(new JobDebugData4Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData4*)_make(new JobDebugData4(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData4.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job2*)jobData;
                    data->buffer = buffer;
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job2>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData4Unsafe) : typeof(JobDebugData4));
            }
            { // ME.BECS.Tests.Tests_Queries+JobComponents
                CacheJobDebugData5.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData5* data = (JobDebugData5*)CacheJobDebugData5.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData5*)_make(new JobDebugData5Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData5*)_make(new JobDebugData5(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData5.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.JobComponents*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerRO<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.JobComponents>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData5Unsafe) : typeof(JobDebugData5));
            }
            { // ME.BECS.Tests.Tests_Queries+Job1Unsafe
                CacheJobDebugData6.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData6* data = (JobDebugData6*)CacheJobDebugData6.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData6*)_make(new JobDebugData6Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData6*)_make(new JobDebugData6(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData6.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.Job1Unsafe*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test2Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test2Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.Job1Unsafe>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData6Unsafe) : typeof(JobDebugData6));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestDestroyJobFor
                CacheJobDebugData7.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData7* data = (JobDebugData7*)CacheJobDebugData7.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData7*)_make(new JobDebugData7Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData7*)_make(new JobDebugData7(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData7.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor*)jobData;
                    data->buffer = buffer;
                    data->c0 = buffer->state.ptr->components.GetRW<ME.BECS.Tests.TestTargetComponent>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRO<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestTargetComponent = new SafetyComponentContainerRO<ME.BECS.Tests.TestTargetComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestDestroyJobFor>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData7Unsafe) : typeof(JobDebugData7));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestSetJob
                CacheJobDebugData8.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData8* data = (JobDebugData8*)CacheJobDebugData8.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData8*)_make(new JobDebugData8Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData8*)_make(new JobDebugData8(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData8.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestSetJob*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.Test2Aspect>(buffer->state);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRW<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test4Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test4Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestSetJob>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData8Unsafe) : typeof(JobDebugData8));
            }
            { // ME.BECS.Tests.Tests_Queries+TestA2Job
                CacheJobDebugData9.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData9* data = (JobDebugData9*)CacheJobDebugData9.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData9*)_make(new JobDebugData9Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData9*)_make(new JobDebugData9(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData9.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.TestA2Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.TestAspect>(buffer->state);
                    data->ME_BECS_Tests_Test2Component = new SafetyComponentContainerRW<ME.BECS.Tests.Test2Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.TestA2Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData9Unsafe) : typeof(JobDebugData9));
            }
            { // ME.BECS.Tests.Tests_Queries+TestA1Job
                CacheJobDebugData10.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData10* data = (JobDebugData10*)CacheJobDebugData10.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData10*)_make(new JobDebugData10Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData10*)_make(new JobDebugData10(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData10.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Queries.TestA1Job*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.TestAspect>(buffer->state);
                    data->ME_BECS_Tests_Test5Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test5Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_TestComponent = new SafetyComponentContainerRW<ME.BECS.Tests.TestComponent>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Queries.TestA1Job>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData10Unsafe) : typeof(JobDebugData10));
            }
            { // ME.BECS.Tests.Tests_Aspects+TestJobFor
                CacheJobDebugData11.cache.Data = default;
                [BurstCompile]
                static void* Method(void* jobData, CommandBuffer* buffer, bool unsafeMode, ScheduleFlags scheduleFlags) {
                    JobDebugData11* data = (JobDebugData11*)CacheJobDebugData11.cache.Data;
                    if (data == null) {
                        if (unsafeMode == true) {
                            data = (JobDebugData11*)_make(new JobDebugData11Unsafe(), Constants.ALLOCATOR_DOMAIN).ptr;
                            } else {
                            data = (JobDebugData11*)_make(new JobDebugData11(), Constants.ALLOCATOR_DOMAIN).ptr;
                        }
                        CacheJobDebugData11.cache.Data = (System.IntPtr)data;
                    }
                    data->scheduleFlags = scheduleFlags;
                    data->jobData = *(ME.BECS.Tests.Tests_Aspects.TestJobFor*)jobData;
                    data->buffer = buffer;
                    data->a0 = buffer->state.ptr->aspectsStorage.Initialize<ME.BECS.Tests.Test2Aspect>(buffer->state);
                    data->ME_BECS_Tests_T1 = new SafetyComponentContainerRW<ME.BECS.Tests.T1>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test3Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test3Component>(buffer->state, buffer->worldId);
                    data->ME_BECS_Tests_Test4Component = new SafetyComponentContainerRO<ME.BECS.Tests.Test4Component>(buffer->state, buffer->worldId);
                    return data;
                }
                var fn = BurstCompiler.CompileFunctionPointer<CompiledJobCallback>(Method);
                CompiledJobs<ME.BECS.Tests.Tests_Aspects.TestJobFor>.SetFunction(fn, (unsafeMode) => unsafeMode == true ? typeof(JobDebugData11Unsafe) : typeof(JobDebugData11));
            }
        }
        #endif
        
        
        public static unsafe void NetworkLoad(ref ME.BECS.Network.UnsafeNetworkModule.MethodsStorage methods) {
        }
        public static unsafe void ViewsLoad(ref ME.BECS.Views.ViewsModuleData viewsModule) {
        }
        public static unsafe void AspectsConstruct(ref World world) {
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Aspect1>();
                aspect.t1Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test1Component>(in world);
                aspect.t2Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test2Component>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Aspect2>();
                aspect.t1Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test3Component>(in world);
                aspect.t2Value = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test4Component>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.TestAspect>();
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test1Component>(in world);
                aspect.dataPtr2 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test2Component>(in world);
                aspect.dataPtr3 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test3Component>(in world);
                aspect.dataPtr4 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test4Component>(in world);
                aspect.dataPtr5 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.Test5Component>(in world);
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.TestComponent>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Test2Aspect>();
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T1>(in world);
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T2>(in world);
            }
            {
                ref var aspect = ref world.InitializeAspect<ME.BECS.Tests.Tests_Aspects.TestAspect>();
                aspect.dataPtr = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T1>(in world);
                aspect.dataPtr1 = new ME.BECS.AspectDataPtr<ME.BECS.Tests.T2>(in world);
            }
        }
        [BurstCompile] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponent(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponent.Test>(in ent, data, length);
                }
            }
        }
        [BurstCompile] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestListComponent(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestListComponent*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.ListAuto<ME.BECS.Tests.Tests_EntityConfig.TestListComponent.Test>(in ent, data, length);
                }
            }
        }
        [BurstCompile] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentStatic(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentStatic.Test>(in ent, data, length);
                }
            }
        }
        [BurstCompile] public static unsafe void EntityConfigComponentApplyME_BECS_Tests_Tests_EntityConfig_TestArrayComponentShared(in UnsafeEntityConfig config, void* componentPtr, in Ent ent) {
            {
                var component = (ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared*)componentPtr;
                var res = config.GetCollectionById(component->arr.GetConfigId(), out var data, out var length);
                if (res == true) {
                    if (component->arr.IsCreated == true) component->arr.Dispose();
                    component->arr = new ME.BECS.MemArrayAuto<ME.BECS.Tests.Tests_EntityConfig.TestArrayComponentShared.Test>(in ent, data, length);
                }
            }
        }
    }
}
