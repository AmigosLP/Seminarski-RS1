import { read } from "@popperjs/core";

export class ImageConverter
{
    public static async ToBase64(file:File):Promise<string|null>
    {
        return new Promise((encodedImage)=>{

            let reader=new FileReader();
            reader.readAsDataURL(file);
            reader.onload=()=>
            {
                encodedImage(<string|null>reader.result);
            }

        })
    }
}