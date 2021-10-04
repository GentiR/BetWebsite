import React from "react";
import axios, { AxiosResponse } from "axios";
import {Card, Table, Button} from 'react-bootstrap';
import Modal from "react-modal";
import "../../assets/scss/Modal.css";
import {useToasts } from "react-toast-notifications";

interface SerieA{
    matchId: number;
    teamsName: string;
    datat: string;
    scoreHome: number;
    scoreAway: number;
    moneys: number;
};

  const Projects = () => {
    const [data, setData] = React.useState<SerieA[]>([] as SerieA[]);
    const [selectedData, setSelectedData] = React.useState<SerieA>({} as SerieA);
    const [openModal, setOpenModal] = React.useState(false);
    const [formState, setFormState] = React.useState("");
    const { addToast } = useToasts(); 

    const OpenModal = () => 
        setOpenModal(true);

    const CloseModal = () => {
        setFormState("");
        setSelectedData({} as SerieA);
        setOpenModal(false);
    };

    const openInsert = () => {
        setFormState("insert");
        OpenModal();
      };
    
      const openDeleteModal = (item: SerieA) => {
        setSelectedData(item);
        setFormState("delete");
        setOpenModal(true);
      };
    
      const openEditModal = (item: SerieA) => {
        setSelectedData(item);
        setFormState("edit");
        setOpenModal(true);
      };

      const handleNotification = (res: AxiosResponse) => {
        if (res.data !== 400) {
          addToast(res.data, {
            appearance: "success",
            autoDismiss: true,
            autoDismissTimeout: 5000,
          });
          CloseModal();
        } else {
          addToast(
            "Kemi pasur probleme me insertimin e bastit. Ju lutem provoni përsëri.",
            {
              appearance: "error",
              autoDismiss: true,
              autoDismissTimeout: 5000,
            }
          );
        }
      };
      
      const updated = () => {
        return data === [];
      };

      React.useEffect(() => {
        axios
        .get("http://localhost:5000/api/SeriaA")
        .then((res) => setData(res.data));
    });

      const addBett = (item: SerieA) => {
        axios
          .post("http://localhost:5000/api/SeriaA/insertBett", item)
          .then((res) => {
            handleNotification(res);
            if (res.data !== 400) setData((data) => [...data, item]);
          });
      };

      const deleteBett = () => {
        axios
          .delete(
            "http://localhost:5000/api/SeriaA/deleteBett/" + selectedData.matchId
          )
          .then((res) => {
            if (res.data !== 400)
              setData(data.filter((bett) => bett.matchId !== selectedData.matchId));
            handleNotification(res);
          });
      };

      const editBett = (bett: SerieA) => {
        axios
          .put("http://localhost:5000/api/SeriaA/editBett/" + 
          bett.matchId, 
          bett
          )
          .then((res) => handleNotification(res));
      };

    return (
        <Card>
            <div className="d-flex align-items-center">
                <div>
                    <Button onClick={openInsert}>Insert Betts</Button>
                </div>
            </div>
            <Table className="no-wrap v-middle" responsive>
              <thead>
                  <tr className="border-0">
                    <th className="border-0">Match Number</th>
                    <th className="border-0">Teams</th>
                    <th className="border-0">Datat</th>
                    <th className="border-0">ScoreHome</th>
                    <th className="border-0">ScoreAway</th>
                    <th className="border-0">Money</th>
                    <th className="border-0">Options</th>
                  </tr>
                </thead>
                <tbody>
                {/* {!updated() && */}
                {data.map((item) => {
                  return(
                    <tr>
                      <td>{item.matchId}</td>
                      <td>{item.teamsName}</td>
                      <td>{item.datat}</td>
                      <td>{item.scoreHome}</td>
                      <td>{item.scoreAway}</td>
                      <td>{item.moneys}</td>
                      <td>
                        <Button onClick={()=> openEditModal(item)} id="edit-btn">
                          Edit    
                        </Button>
                        <br/>
                        <Button onClick={() => openDeleteModal(item)} id="delete-btn">
                          Delete
                        </Button>
                      </td>
                    </tr>
                  );
                })}
                </tbody>
            </Table>
 
            <Modal
              isOpen={openModal}
              contentLabel="Example"
              className="Modal"
              overlayClassName="Overlay"
            >
              {formState === "insert" && <InsertForm addBett={addBett} />}
              {formState === "delete" && (
            <DeleteForm deleteBett={deleteBett} />
              )}
              {formState === "edit" && (
            <EditForm selectedData={selectedData} editBett={editBett} />
              )}
            <button className="modal-button" onClick={CloseModal}>
              Anulo
            </button>
          </Modal>
      </Card>
    );
};
  interface InsertFormProps {
    addBett: (insertbett: SerieA) => void;
  }

  const InsertForm: React.FC<InsertFormProps> = ({ addBett }) => {
    const GetBettsFromInputs = () => {
      let insertbett: SerieA = {
        matchId: parseInt(
          (document.getElementsByName("match-id")[0] as HTMLInputElement).value
        ),
        teamsName: (
          document.getElementsByName("teams-name")[0] as HTMLInputElement)
        .value,
        datat: (
          document.getElementsByName("date-name")[0] as HTMLInputElement)
        .value,
        scoreHome: parseInt(
          (document.getElementsByName("scoreH-id")[0] as HTMLInputElement).value
        ),
        scoreAway: parseInt(
          (document.getElementsByName("scoreA-id")[0] as HTMLInputElement).value
        ),
        moneys: parseInt(
          (document.getElementsByName("money-id")[0] as HTMLInputElement).value
        ),   
      };
      addBett(insertbett);
    };

    return(
      <>
      <h1>- Shto bast -</h1>
      <label htmlFor="match-id">Match Id</label>
      <input name="match-id" type="number" min={1} max={100}/>

      <label htmlFor="teams-name">Teams Name</label>
      <input name="teams-name" type="text"/>

      <label htmlFor="date-name">Data</label>
      <input name="date-name" type="text"/>

      <label htmlFor="scoreH-id">ScoreHome</label>
      <input name="scoreH-id" type="number" min={1} max={2}/>

      <label htmlFor="scoreA-id">ScoreAway</label>
      <input name="scoreA-id" type="number" min={1} max={2}/>

      <label htmlFor="money-id">Money</label>
      <input name="money-id" type="number"/>

      <button onClick={GetBettsFromInputs} className="modal-button">
        Shto
      </button>
      </>
    );
  };

  interface DeleteFormProps {
    deleteBett: () => void;
  }
  
  const DeleteForm: React.FC<DeleteFormProps> = ({ deleteBett }) => {
    return (
      <>
        <h1>A jeni të sigurt që dëshironi ta shlyeni këtë të dhënë?</h1>
        <button onClick={deleteBett} className="modal-button">
          Konfirmo
        </button>
      </>
    );
  };

  interface EditFormProps {
    editBett: (bett: SerieA) => void;
    selectedData: SerieA;
  }
  
  const EditForm: React.FC<EditFormProps> = ({ editBett, selectedData }) => {
    const GetEditedBettFromInputs = () => {
      let editbett: SerieA = {
        matchId: parseInt(
          (document.getElementsByName("match-id")[0] as HTMLInputElement).value
        ),
        teamsName: (
          document.getElementsByName("teams-name")[0] as HTMLInputElement)
        .value,
        datat: (
          document.getElementsByName("date-name")[0] as HTMLInputElement)
        .value,
        scoreHome: parseInt(
          (document.getElementsByName("scoreH-id")[0] as HTMLInputElement).value
        ),
        scoreAway: parseInt(
          (document.getElementsByName("scoreA-id")[0] as HTMLInputElement).value
        ),
        moneys: parseInt(
          (document.getElementsByName("money-id")[0] as HTMLInputElement).value
        ),   
      };
      editBett(editbett);
    };
    return (
      <>
        <h1>- Ndrysho Bastin -</h1>
        <label htmlFor="match-id">Match Id</label>
        <input name="match-id"defaultValue={selectedData.matchId} type="number" min={1} max={100}/>

        <label htmlFor="teams-name">Teams Name</label>
        <input name="teams-name" defaultValue={selectedData.teamsName} type="text"/>

        <label htmlFor="date-name">Data</label>
        <input name="date-name"  defaultValue={selectedData.datat} type="text"/>

        <label htmlFor="scoreH-id">ScoreHome</label>
        <input name="scoreH-id" defaultValue={selectedData.scoreHome} type="number" min={1} max={100}/>

        <label htmlFor="scoreA-id">ScoreAway</label>
        <input name="scoreA-id" defaultValue={selectedData.scoreAway} type="number" min={1} max={100}/>

        <label htmlFor="money-id">Money</label>
        <input name="money-id"defaultValue={selectedData.moneys} type="number"/>

        <button onClick={GetEditedBettFromInputs} className="modal-button">
          Ndrysho
        </button>
      </>
    );
  };
export default Projects;