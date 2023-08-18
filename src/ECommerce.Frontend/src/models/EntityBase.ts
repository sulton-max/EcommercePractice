import type {Guid} from "guid-typescript";
import type {IEntityBase} from "@/models/IEntityBase";

export class EntityBase implements IEntityBase{
    id: Guid;
}