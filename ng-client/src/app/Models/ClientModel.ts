
export class ClientModel {

    constructor(
        public id: number,
        public primer_nombre: string,
        public segundo_nombre: string,
        public primer_apellido: string,
        public segundo_apellido: string,
        public tipo_doc: string,
        public celular: string,
        public direccion: string,
        public correo: string
    ){}
}