﻿using Godot;

/// <summary>
///   All nodes that can be spawned with the spawn system must implement this interface
/// </summary>
public interface ISpawned : IEntity
{
    /// <summary>
    ///   If the distance to the player of this object is
    ///   greater than this, it is despawned.
    /// </summary>
    float DespawnRadius { get; set; }

    /// <summary>
    ///   The Node that was spawned for this entity, used to tag it
    ///   for detecting despawning.
    /// </summary>
    Node SpawnedNode { get; }
}
