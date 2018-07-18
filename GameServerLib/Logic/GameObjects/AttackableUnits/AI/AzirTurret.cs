﻿using LeagueSandbox.GameServer.Logic.Enet;

namespace LeagueSandbox.GameServer.Logic.GameObjects.AttackableUnits.AI
{
    public class AzirTurret : BaseTurret
    {
        public AttackableUnit Owner { get; private set; }

        public AzirTurret(
            Game game,
            AttackableUnit owner,
            string name,
            string model,
            float x = 0,
            float y = 0,
            TeamId team = TeamId.TEAM_BLUE,
            uint netId = 0
        ) : base(game, name, model, x, y, team, netId)
        {
            Owner = owner;

            SetTeam(team);
            Stats.Range.BaseValue = 905.0f;
        }

        public override void OnAdded()
        {
            base.OnAdded();
            _game.PacketNotifier.NotifySpawn(this);
        }

        public override void RefreshWaypoints()
        {
        }

        public override float GetMoveSpeed()
        {
            return 0;
        }
    }
}
