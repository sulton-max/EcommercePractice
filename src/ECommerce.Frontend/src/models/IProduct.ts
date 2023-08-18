import type {IEntityBase} from "@/models/IEntityBase";

export interface IProduct extends IEntityBase {
    name: string;
    price: number;
    imageUrl: string;
}
